// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Adjustment14.
/// </summary>
[IsoId("_tuRtAXNSEe6Y1uOeeiF_Eg")]
[DisplayName("Adjustment14")]
public record Adjustment14
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public Max35Text? Type { get; init; }

    /// <summary>
    /// Additional Type.
    /// </summary>
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    public Max35Text? AdditionalType { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public Max70Text? Description { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Max35Text? Reason { get; init; }

    /// <summary>
    /// Promotion Eligibility.
    /// </summary>
    [DisplayName("Promotion Eligibility")]
    [IsoXmlTag("PrmtnElgblty")]
    public TrueFalseIndicator? PromotionEligibility { get; init; }

    /// <summary>
    /// Promotion Code.
    /// </summary>
    [DisplayName("Promotion Code")]
    [IsoXmlTag("PrmtnCd")]
    public Max35Text? PromotionCode { get; init; }

    /// <summary>
    /// Promotion Coupon Number.
    /// </summary>
    [DisplayName("Promotion Coupon Number")]
    [IsoXmlTag("PrmtnCpnNb")]
    public Max35Text? PromotionCouponNumber { get; init; }

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public DecimalNumber? Quantity { get; init; }

    /// <summary>
    /// Unit Price.
    /// </summary>
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; }

    /// <summary>
    /// Percentage.
    /// </summary>
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    public PercentageRate? Percentage { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Tax On Original Amount.
    /// </summary>
    [DisplayName("Tax On Original Amount")]
    [IsoXmlTag("TaxOnOrgnlAmt")]
    public TrueFalseIndicator? TaxOnOriginalAmount { get; init; }
}
