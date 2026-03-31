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
    public IsoMax35Text? AdditionalType { get; init; }

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
    public IsoMax70Text? Description { get; init; }

    /// <summary>
    /// Percentage.
    /// </summary>
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    public IsoPercentageRate? Percentage { get; init; }

    /// <summary>
    /// Promotion Code.
    /// </summary>
    [DisplayName("Promotion Code")]
    [IsoXmlTag("PrmtnCd")]
    public IsoMax35Text? PromotionCode { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public IsoMax35Text? Reason { get; init; }

    /// <summary>
    /// Tax On Original Amount.
    /// </summary>
    [DisplayName("Tax On Original Amount")]
    [IsoXmlTag("TaxOnOrgnlAmt")]
    public IsoTrueFalseIndicator? TaxOnOriginalAmount { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; }
}
