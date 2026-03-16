// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_T6ZIUVm_EeOQYsoJizpkVw")]
[DisplayName("Early Payment")]
public record EarlyPayment1
{
    /// <summary>
    /// Date before which the early payment discount is valid for payment.
    /// </summary>
    [IsoId("_eUAngFm_EeOQYsoJizpkVw")]
    [DisplayName("Early Payment Date")]
    [IsoXmlTag("EarlyPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate EarlyPaymentDate { get; init; }

    /// <summary>
    /// Discount percent for early payment.
    /// </summary>
    [IsoId("_UGcnaVm_EeOQYsoJizpkVw")]
    [DisplayName("Discount Percent")]
    [IsoXmlTag("DscntPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate DiscountPercent { get; init; }

    /// <summary>
    /// Early payment discount with tax, with currency.
    /// </summary>
    [IsoId("_UGcnZVm_EeOQYsoJizpkVw")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public required CurrencyAndAmount DiscountAmount { get; init; }

    /// <summary>
    /// In tax specification for early payment discount one defined the applied tax rates for specific early payment. VAT stands for value added tax.
    /// </summary>
    [IsoId("_EkXkEFnAEeOQYsoJizpkVw")]
    [DisplayName("Early Payment Tax Specification")]
    [IsoXmlTag("EarlyPmtTaxSpcfctn")]
    public EarlyPaymentsVAT1? EarlyPaymentTaxSpecification { get; init; }

    /// <summary>
    /// Tax total in early payment, with currency.
    /// </summary>
    [IsoId("_sh6QoFm_EeOQYsoJizpkVw")]
    [DisplayName("Early Payment Tax Total")]
    [IsoXmlTag("EarlyPmtTaxTtl")]
    public CurrencyAndAmount? EarlyPaymentTaxTotal { get; init; }

    /// <summary>
    /// Payable amount with discount of early payment, with currency.
    /// </summary>
    [IsoId("_3UqokFm_EeOQYsoJizpkVw")]
    [DisplayName("Due Payable Amount With Early Payment")]
    [IsoXmlTag("DuePyblAmtWthEarlyPmt")]
    public CurrencyAndAmount? DuePayableAmountWithEarlyPayment { get; init; }
}
