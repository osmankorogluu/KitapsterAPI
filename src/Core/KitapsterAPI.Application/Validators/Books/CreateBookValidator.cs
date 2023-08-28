using FluentValidation;
using KitapsterAPI.Application.WiewModels.Books;
using KitapsterAPI.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapsterAPI.Application.Validators.Books
{
    public class CreateBookValidator : AbstractValidator<VM_Create_Book>
    {
        public CreateBookValidator()
        {
            RuleFor(b => b.BookName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen kitap adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(5)
                .WithMessage("Lütfen kitap adını 5 ile 150 karakter arasında giriniz");

            RuleFor(b => b.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen stok bilgisini boş geçmeyiniz ")
                .Must(s => s >= 0)
                .WithMessage("Stok bilgisi negatif olamaz");

            RuleFor(b => b.ProductCode)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen ürün kodunu boş geçmeyiniz ");
                
        }
    }
}
