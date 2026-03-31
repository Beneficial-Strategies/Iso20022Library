// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contractual details related to the agreement between parties.
/// </summary>
[IsoId("_ozNtAY-eEeaEa8S_GI1QNA")]
[DisplayName("Agreement")]
public record Agreement5
{
    /// <summary>
    /// Full name of the base standard agreement, annexes and amendments in place between the principals and applicable to this deal.
    /// </summary>
    [IsoId("_pB8Fh4-eEeaEa8S_GI1QNA")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; }

    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    [IsoId("_pB8Fj4-eEeaEa8S_GI1QNA")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? Date { get; init; }

    /// <summary>
    /// Contractual currency forming the basis of a financing agreement and associated transactions. Usually, but not always, the same as the trade currency.
    /// </summary>
    [IsoId("_pB8Fl4-eEeaEa8S_GI1QNA")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Type of financing closing.
    /// </summary>
    [IsoId("_pB8Fn4-eEeaEa8S_GI1QNA")]
    [DisplayName("Closing Type")]
    [IsoXmlTag("ClsgTp")]
    public ClosingType1Code? ClosingType { get; init; }

    /// <summary>
    /// Start date of a financing deal that is the date the buyer pays the seller cash and takes control of the collateral.
    /// </summary>
    [IsoId("_pB8Fp4-eEeaEa8S_GI1QNA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartDate { get; init; }

    /// <summary>
    /// Identifies type of settlement.
    /// </summary>
    [IsoId("_pB8Fr4-eEeaEa8S_GI1QNA")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public DeliveryType2Code? DeliveryType { get; init; }

    /// <summary>
    /// Fraction of the cash consideration that must be collateralized, expressed as a percent. A margin ratio of 02% indicates that the value of the collateral (after deducting for &quot;haircut&quot;) must exceed the cash consideration by 2%.
    /// </summary>
    [IsoId("_pB8Ft4-eEeaEa8S_GI1QNA")]
    [DisplayName("Margin Ratio")]
    [IsoXmlTag("MrgnRatio")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MarginRatio { get; init; }
}
