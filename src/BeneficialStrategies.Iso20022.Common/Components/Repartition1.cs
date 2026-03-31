// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates how the amount of the investment plan is split amongst the funds.
/// </summary>
[IsoId("_RQptnNp-Ed-ak6NoX_4Aeg_421967977")]
[DisplayName("Repartition")]
public record Repartition1
{
    /// <summary>
    /// Percentage of amount invested in a funds.
    /// </summary>
    [IsoId("_RQptndp-Ed-ak6NoX_4Aeg_175124020")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Percentage { get; init; }

    /// <summary>
    /// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
    /// </summary>
    [IsoId("_RQy3gNp-Ed-ak6NoX_4Aeg_-466396001")]
    [DisplayName("Financial Instrument")]
    [IsoXmlTag("FinInstrm")]
    public required FinancialInstrument10 FinancialInstrument { get; init; }
}
