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
[IsoId("_ODM5MDI2-AOSNFX-3397728")]
[DisplayName("Payment Terms")]
public record PaymentTerms6
{
    /// <summary>
    /// Due date specified for the payment terms.
    /// </summary>
    [IsoId("_ODM5MDI3-AOSNFX-3397728")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Payment period specified for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDI4-AOSNFX-3397728")]
    [DisplayName("Payment Period")]
    [IsoXmlTag("PmtPrd")]
    public PaymentPeriod1? PaymentPeriod { get; init; }

    /// <summary>
    /// Textual description of these payment terms.
    /// </summary>
    [IsoId("_ODM5MDI5-AOSNFX-3397728")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public SimpleValueList<IsoMax140Text> Description { get; init; } = [];

    /// <summary>
    /// Partial payment, expressed as a percentage, for the payment terms.
    /// </summary>
    [IsoId("_ODM5MDMw-AOSNFX-3397728")]
    [DisplayName("Partial Payment Percent")]
    [IsoXmlTag("PrtlPmtPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialPaymentPercent { get; init; }

    /// <summary>
    /// Direct debit mandate identification specified for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDMx-AOSNFX-3397728")]
    [DisplayName("Direct Debit Mandate Identification")]
    [IsoXmlTag("DrctDbtMndtId")]
    public SimpleValueList<IsoMax35Text> DirectDebitMandateIdentification { get; init; } = [];

    /// <summary>
    /// Amount used as a basis to calculate the discount amount for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDMy-AOSNFX-3397728")]
    [DisplayName("Basis Amount")]
    [IsoXmlTag("BsisAmt")]
    public CurrencyAndAmount? BasisAmount { get; init; }

    /// <summary>
    /// Amount of money that results from the application of an agreed discount percentage to the basis amount and payable to the creditor.
    /// </summary>
    [IsoId("_ODM5MDMz-AOSNFX-3397729")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public CurrencyAndAmount? DiscountAmount { get; init; }

    /// <summary>
    /// Percent rate used to calculate the discount for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDM0-AOSNFX-3397729")]
    [DisplayName("Discount Percent Rate")]
    [IsoXmlTag("DscntPctRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? DiscountPercentRate { get; init; }

    /// <summary>
    /// Amount of money that results from the application of an agreed penalty percentage to the basis amount and payable by the creditor.
    /// </summary>
    [IsoId("_ODM5MDM1-AOSNFX-3397729")]
    [DisplayName("Penalty Amount")]
    [IsoXmlTag("PnltyAmt")]
    public CurrencyAndAmount? PenaltyAmount { get; init; }

    /// <summary>
    /// Percent rate used to calculate the penalty for these payment terms.
    /// </summary>
    [IsoId("_ODM5MDM2-AOSNFX-3397729")]
    [DisplayName("Penalty Percent Rate")]
    [IsoXmlTag("PnltyPctRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PenaltyPercentRate { get; init; }
}
