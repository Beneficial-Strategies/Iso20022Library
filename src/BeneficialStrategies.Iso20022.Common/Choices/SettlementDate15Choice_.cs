// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate15Choice.Date))]
    [KnownType(typeof(SettlementDate15Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate15Choice.Date), nameof(SettlementDate15Choice.Date))]
    [JsonDerivedType(
        typeof(SettlementDate15Choice.DateCode),
        nameof(SettlementDate15Choice.DateCode)
    )]
    [IsoId("_6BMwZ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date 15 Choice")]
    public abstract record SettlementDate15Choice_ { }
}
