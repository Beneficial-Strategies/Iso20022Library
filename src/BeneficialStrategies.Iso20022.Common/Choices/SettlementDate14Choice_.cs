// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate14Choice.Date))]
    [KnownType(typeof(SettlementDate14Choice.DateCode))]
    [JsonDerivedType(typeof(SettlementDate14Choice.Date),nameof(SettlementDate14Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate14Choice.DateCode),nameof(SettlementDate14Choice.DateCode))]
    [IsoId("_5mslU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date 14 Choice")]
    public abstract partial record SettlementDate14Choice_
    {
    }
}
