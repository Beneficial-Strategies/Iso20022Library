// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate12Choice.Date))]
    [KnownType(typeof(SettlementDate12Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate12Choice.Date), nameof(SettlementDate12Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate12Choice.DateCode),
        nameof(SettlementDate12Choice.DateCode)
    )]
    [IsoId("_5TGUn5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date 12 Choice")]
    public abstract record SettlementDate12Choice_ { }
}
