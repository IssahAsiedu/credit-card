using System.ComponentModel.DataAnnotations;

namespace CreditCardWeb.Data;
public class BankCardDetails
{
    public Guid Id { get; set; }

    [Required, MinLength(16, ErrorMessage = "The required length is 16.")]
    public string CardNumber { get; set; } = "";

    [Required, MinLength(2, ErrorMessage = "The minimum length of a name is 2.")]
    public string? CardName { get; set; }

    [Required, CVV(ErrorMessage = "The minimum length of cvv is 3.")]
    public int? CardCvv { get; set; }

    [YearMonth(ErrorMessage = "Month must be provided.")]
    public int ExpiryMonth { get; set; }

    [YearMonth(ErrorMessage = "Year must be provided.")]
    public int ExpiryYear { get; set; }

    public void Clear()
    {
        CardNumber = "";
        CardName = null;
        CardCvv = null;
        ExpiryMonth = 0;
        ExpiryYear = 0;
    }
}
