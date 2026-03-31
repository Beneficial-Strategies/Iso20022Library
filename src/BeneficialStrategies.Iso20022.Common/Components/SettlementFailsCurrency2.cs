// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the settlement fails per currency.
/// </summary>
[IsoId("_antbaR2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Currency")]
public record SettlementFailsCurrency2
{
    /// <summary>
    /// Currency of the cash counter value specified in a settlement instruction.
    /// Usage: this is the currency in which the aggregate values have to be reported for the settlement fails per currency.
    /// </summary>
    [IsoId("_ao5uMR2lEeqF2P5v-Rtejg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Aggregated data of all settlement transactions per currency.
    /// </summary>
    [IsoId("_ao5uMx2lEeqF2P5v-Rtejg")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required SettlementTotalData1 Data { get; init; }
}
