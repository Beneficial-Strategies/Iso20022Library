// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Option106.
/// </summary>
[IsoId("_2dVQQ4V4Ee-oeNhl-Tk6YQ")]
[DisplayName("Cash Option106")]
public partial record CashOption106
{
    #nullable enable

    /// <summary>
    /// Cash Account Identification.
    /// </summary>
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification9Choice_? CashAccountIdentification { get; init; } 

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 

    /// <summary>
    /// Earliest Payment Date.
    /// </summary>
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateAndDateTime2Choice_? EarliestPaymentDate { get; init; } 

    /// <summary>
    /// Entitled Amount.
    /// </summary>
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public required ActiveCurrencyAndAmount EntitledAmount { get; init; } 

    /// <summary>
    /// Gross Cash Amount.
    /// </summary>
    [DisplayName("Gross Cash Amount")]
    [IsoXmlTag("GrssCshAmt")]
    public ActiveCurrencyAndAmount? GrossCashAmount { get; init; } 

    /// <summary>
    /// Net Cash Amount.
    /// </summary>
    [DisplayName("Net Cash Amount")]
    [IsoXmlTag("NetCshAmt")]
    public ActiveCurrencyAndAmount? NetCashAmount { get; init; } 

    /// <summary>
    /// Payment Date.
    /// </summary>
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat43Choice_ PaymentDate { get; init; } 

    /// <summary>
    /// Withholding Tax Amount.
    /// </summary>
    [DisplayName("Withholding Tax Amount")]
    [IsoXmlTag("WhldgTaxAmt")]
    public ActiveCurrencyAndAmount? WithholdingTaxAmount { get; init; } 

    /// <summary>
    /// Withholding Tax Rate.
    /// </summary>
    [DisplayName("Withholding Tax Rate")]
    [IsoXmlTag("WhldgTaxRate")]
    public ValueList<RateAndAmountFormat55Choice_> WithholdingTaxRate { get; init; } = [];

    
    #nullable disable
    
}
