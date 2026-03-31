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
[IsoId("_AxQTQNokEeC60axPepSq7g_-153529059")]
[DisplayName("Agreement")]
public record Agreement3
{
    /// <summary>
    /// Full name of the base standard agreement, annexes and amendments in place between the principals and applicable to this deal.
    /// </summary>
    [IsoId("_AxQTQdokEeC60axPepSq7g_-267368125")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Description { get; init; }

    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    [IsoId("_AxQTQtokEeC60axPepSq7g_2033454465")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? Date { get; init; }

    /// <summary>
    /// Contractual currency forming the basis of a financing agreement and associated transactions. Usually, but not always, the same as the trade currency.
    /// </summary>
    [IsoId("_AxaEQNokEeC60axPepSq7g_1036382112")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; }

    /// <summary>
    /// Type of financing closing.
    /// </summary>
    [IsoId("_AxaEQdokEeC60axPepSq7g_39309759")]
    [DisplayName("Closing Type")]
    [IsoXmlTag("ClsgTp")]
    public ClosingType1Code? ClosingType { get; init; }

    /// <summary>
    /// Start date of a financing deal that is the date the buyer pays the seller cash and takes control of the collateral.
    /// </summary>
    [IsoId("_AxaEQtokEeC60axPepSq7g_-957762594")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? StartDate { get; init; }

    /// <summary>
    /// Identifies type of settlement.
    /// </summary>
    [IsoId("_AxaEQ9okEeC60axPepSq7g_-1954834947")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public DeliveryType2Code? DeliveryType { get; init; }

    /// <summary>
    /// Fraction of the cash consideration that must be collateralized, expressed as a percent. A margin ratio of 02% indicates that the value of the collateral (after deducting for &quot;haircut&quot;) must exceed the cash consideration by 2%.
    /// </summary>
    [IsoId("_AxaERNokEeC60axPepSq7g_1343059996")]
    [DisplayName("Margin Ratio")]
    [IsoXmlTag("MrgnRatio")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MarginRatio { get; init; }
}
