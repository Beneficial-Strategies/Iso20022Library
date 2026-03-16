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
[IsoId("_TCHyDQEcEeCQm6a_G2yO_w_-1177730425")]
[DisplayName("Payment Terms")]
public record PaymentTerms3
{
    /// <summary>
    /// Due date specified for the payment terms.
    /// </summary>
    [IsoId("_TCHyDgEcEeCQm6a_G2yO_w_909551142")]
    [DisplayName("Due Date")]
    [IsoXmlTag("DueDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DueDate { get; init; }

    /// <summary>
    /// Payment period specified for these payment terms.
    /// </summary>
    [IsoId("_TCHyDwEcEeCQm6a_G2yO_w_1401606121")]
    [DisplayName("Payment Period")]
    [IsoXmlTag("PmtPrd")]
    public PaymentPeriod1? PaymentPeriod { get; init; }

    /// <summary>
    /// Textual description of these payment terms.
    /// </summary>
    [IsoId("_TCHyEAEcEeCQm6a_G2yO_w_202278077")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; }

    /// <summary>
    /// Partial payment, expressed as a percentage, for the payment terms.
    /// </summary>
    [IsoId("_TCRjAAEcEeCQm6a_G2yO_w_-716100957")]
    [DisplayName("Partial Payment Percent")]
    [IsoXmlTag("PrtlPmtPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PartialPaymentPercent { get; init; }

    /// <summary>
    /// Direct debit mandate identification specified for these payment terms.
    /// </summary>
    [IsoId("_TCRjAQEcEeCQm6a_G2yO_w_-1812933723")]
    [DisplayName("Direct Debit Mandate Identification")]
    [IsoXmlTag("DrctDbtMndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DirectDebitMandateIdentification { get; init; }

    /// <summary>
    /// Monetary value used as a basis to calculate the discount in these payment terms.
    /// </summary>
    [IsoId("_TCRjAgEcEeCQm6a_G2yO_w_1766790805")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public CurrencyAndAmount? DiscountAmount { get; init; }

    /// <summary>
    /// Percent rate used to calculate the discount for these payment terms.
    /// </summary>
    [IsoId("_TCRjAwEcEeCQm6a_G2yO_w_-774400512")]
    [DisplayName("Discount Percent Rate")]
    [IsoXmlTag("DscntPctRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? DiscountPercentRate { get; init; }

    /// <summary>
    /// Monetary value used as a basis to calculate the discount in these payment terms.
    /// </summary>
    [IsoId("_TCRjBAEcEeCQm6a_G2yO_w_-1837790910")]
    [DisplayName("Discount Basis Amount")]
    [IsoXmlTag("DscntBsisAmt")]
    public CurrencyAndAmount? DiscountBasisAmount { get; init; }

    /// <summary>
    /// Monetary value used as a basis to calculate the penalty in the payment terms.
    /// </summary>
    [IsoId("_TCRjBQEcEeCQm6a_G2yO_w_-189165825")]
    [DisplayName("Penalty Amount")]
    [IsoXmlTag("PnltyAmt")]
    public CurrencyAndAmount? PenaltyAmount { get; init; }

    /// <summary>
    /// Percent rate used to calculate the penalty for these payment terms.
    /// </summary>
    [IsoId("_TCRjBgEcEeCQm6a_G2yO_w_499443934")]
    [DisplayName("Penalty Percent Rate")]
    [IsoXmlTag("PnltyPctRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PenaltyPercentRate { get; init; }

    /// <summary>
    /// Amount used as a basis to calculate the penalty amount.
    /// </summary>
    [IsoId("_TCRjBwEcEeCQm6a_G2yO_w_-1503806956")]
    [DisplayName("Penalty Basis Amount")]
    [IsoXmlTag("PnltyBsisAmt")]
    public CurrencyAndAmount? PenaltyBasisAmount { get; init; }
}
