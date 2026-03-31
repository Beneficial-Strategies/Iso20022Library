// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit default swap derivative specific for reporting derivatives on a credit default swap index.
/// </summary>
[IsoId("_xfbL2X5eEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Index")]
public record CreditDefaultSwapIndex2
{
    /// <summary>
    /// Series number of the composition of the index if applicable.
    /// </summary>
    [IsoId("_xtQzgX5eEea2k7EBUopqxw")]
    [DisplayName("Series")]
    [IsoXmlTag("Srs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Series { get; init; }

    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    [IsoId("_xtQzg35eEea2k7EBUopqxw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// All months when the roll is expected as established by the index provider for a given year. Field should be repeated for each month in the roll.
    /// </summary>
    [IsoId("_xtQzhX5eEea2k7EBUopqxw")]
    [DisplayName("Roll Month")]
    [IsoXmlTag("RollMnth")]
    [IsoSimpleType(IsoSimpleType.RestrictedMonthExact2Number)]
    [MinLength(0)]
    [MaxLength(12)]
    public SimpleValueList<System.UInt64> RollMonth { get; init; } = [];

    /// <summary>
    /// To be populated in the case of a CDS Index or a derivative CDS Index with the next roll date of the index as established by the index provider.
    /// </summary>
    [IsoId("_xtQzh35eEea2k7EBUopqxw")]
    [DisplayName("Next Roll Date")]
    [IsoXmlTag("NxtRollDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? NextRollDate { get; init; }

    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_xtQziX5eEea2k7EBUopqxw")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; }
}
