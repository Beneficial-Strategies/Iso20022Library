// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode9Choice.Code))]
    [KnownType(typeof(SettlementDateCode9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SettlementDateCode9Choice.Code),
        nameof(SettlementDateCode9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SettlementDateCode9Choice.Proprietary),
        nameof(SettlementDateCode9Choice.Proprietary)
    )]
    [IsoId("_5TGUu5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date Code 9 Choice")]
    public abstract record SettlementDateCode9Choice_ { }
}
