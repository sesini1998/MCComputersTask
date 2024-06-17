using MCComputers.API.Data;
using MCComputers.API.IService;
using MCComputers.API.Models;
using MCComputers.API.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MCComputers.API.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IProductService _productService;
        private readonly ITransactionService _transactionService;
        private readonly ILogger<InvoiceController> _logger;
        private readonly ApplicationDbContext _context;

        public InvoiceController(IProductService productService, ITransactionService transactionService,
            ILogger<InvoiceController> logger, ApplicationDbContext context)
        {
            this._productService = productService;
            this._transactionService = transactionService;
            this._logger = logger;
            this._context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var invoices = await _transactionService.GetAllAsync();
                return View(invoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving invoices.");
                return View(new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    Message = "An error occurred while processing your request. Please try again later."
                });
            }
        }


        public async Task<IActionResult> Details(Guid id)
        {
            try
            {
                var invoice = await _transactionService.GetByIdWithItemsAsync(id);
                if (invoice == null)
                {
                    _logger.LogWarning("Invoice with ID {InvoiceId} was not found.", id);
                    return NotFound(new ErrorViewModel
                    {
                        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                        Message = "Invoice not found."
                    });
                }

                return View(invoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving invoice details.");
                return View(new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    Message = "An error occurred while processing your request. Please try again later."
                });
            }
        }

        public async Task<IActionResult> Create()
        {
            var products = await _productService.GetAllAsync();
            ViewBag.Products = products;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TransactionCreate transactionCreate)
        {
            var strategy = _context.Database.CreateExecutionStrategy();

            try
            {
                await strategy.ExecuteAsync(async () =>
                {
                    using (var transaction = await _context.Database.BeginTransactionAsync())
                    {
                        try
                        {
                            var invoice = new Invoice
                            {
                                Id = Guid.NewGuid(),
                                Quantity = transactionCreate.InvoiceItems.Sum(x => x.ProductQuantity),
                                TotalAmount = transactionCreate.InvoiceItems.Sum(x => x.ProductQuantity * x.ProductPrice),
                                TransactionDate = DateTime.Now,
                                CustomerId = transactionCreate.CustomerId
                            };

                            await _transactionService.CreateTransAsync(invoice, 
                                transactionCreate.InvoiceItems.Select(x => x.ProductId));

                            var invoiceItems = transactionCreate.InvoiceItems.Select(item => new InvoiceItem
                            {
                                Id = Guid.NewGuid(),
                                ProductQuantity = item.ProductQuantity,
                                ProductPrice = item.ProductPrice,
                                Amount = item.ProductQuantity * item.ProductPrice,
                                ProductId = item.ProductId,
                                InvoiceId = invoice.Id
                            }).ToList();

                            await _transactionService.AddInvoiceItemsAsync(invoiceItems);

                            await transaction.CommitAsync();
                        }
                        catch (Exception)
                        {
                            await transaction.RollbackAsync();
                            throw;
                        }
                    }
                });

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the transaction.");
                return View(new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    Message = "An error occurred while processing your request. Please try again later."
                });
            }
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var invoice = await _transactionService.GetByIdWithItemsAsync(id);
                if (invoice == null)
                {
                    _logger.LogWarning("Invoice with ID {InvoiceId} was not found.", id);
                    return NotFound(new ErrorViewModel
                    {
                        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                        Message = "Invoice not found."
                    });
                }

                return View(invoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving invoice details.");
                return View(new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    Message = "An error occurred while processing your request. Please try again later."
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteComfirm(Guid id)
        {
            try
            {
                await _transactionService.DeleteAsync(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the invoice.");
                return View(new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                    Message = "An error occurred while processing your request. Please try again later."
                });
            }
        }
    }
}
