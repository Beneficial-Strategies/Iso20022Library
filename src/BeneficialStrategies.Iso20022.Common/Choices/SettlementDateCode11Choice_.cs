// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode11Choice.Code))]
    [KnownType(typeof(SettlementDateCode11Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementDateCode11Choice.Code),nameof(SettlementDateCode11Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode11Choice.Proprietary),nameof(SettlementDateCode11Choice.Proprietary))]
    [IsoId("_6BMwg5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Date Code 11 Choice")]
    public abstract partial record SettlementDateCode11Choice_
    {
    }
}
