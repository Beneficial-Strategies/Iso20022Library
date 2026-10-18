// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Adjustment13.
/// </summary>
[IsoId("_BERt0XNSEe6Y1uOeeiF_Eg")]
[DisplayName("Adjustment13")]
public record Adjustment13
{
    /// <summary>
    /// Additional Type.
    /// </summary>
    [DisplayName("Additional Type")]
    [IsoXmlTag("AddtlTp")]
    public Max35Text? AdditionalType { get; init; }

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public Max70Text? Description { get; init; }

    /// <summary>
    /// Percentage.
    /// </summary>
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    public PercentageRate? Percentage { get; init; }

    /// <summary>
    /// Promotion Code.
    /// </summary>
    [DisplayName("Promotion Code")]
    [IsoXmlTag("PrmtnCd")]
    public Max35Text? PromotionCode { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public Max35Text? Reason { get; init; }

    /// <summary>
    /// Tax On Original Amount.
    /// </summary>
    [DisplayName("Tax On Original Amount")]
    [IsoXmlTag("TaxOnOrgnlAmt")]
    public TrueFalseIndicator? TaxOnOriginalAmount { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public Max35Text? Type { get; init; }
}
