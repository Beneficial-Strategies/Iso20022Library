// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode5Choice.Code))]
    [KnownType(typeof(SettlementDateCode5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementDateCode5Choice.Code),
        nameof(SettlementDateCode5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementDateCode5Choice.Proprietary),
        nameof(SettlementDateCode5Choice.Proprietary)
    )]
    [IsoId("_AcsYhdokEeC60axPepSq7g_-1982124379")]
    [DisplayName("Settlement Date Code 5 Choice")]
    public abstract record SettlementDateCode5Choice_ { }
}
