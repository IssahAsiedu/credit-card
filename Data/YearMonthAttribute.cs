using System.ComponentModel.DataAnnotations;

namespace CreditCardWeb.Data;
public class YearMonthAttribute: ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value == null) return false;

        if (value is not int || (int)value == 0)
        {
            return false;
        }

        return true;
    }
}


public class CVVAttribute: ValidationAttribute
{
    public override bool IsValid(object? value)
    {

        if (value is int intValue)
        {
            var cvv = intValue.ToString();

            return cvv.Length >= 3;
        }

        return false;
    }
}