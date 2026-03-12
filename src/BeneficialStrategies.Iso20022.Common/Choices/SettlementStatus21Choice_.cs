// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus21Choice.Pending))]
    [KnownType(typeof(SettlementStatus21Choice.Failing))]
    [KnownType(typeof(SettlementStatus21Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus21Choice.Pending),nameof(SettlementStatus21Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus21Choice.Failing),nameof(SettlementStatus21Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus21Choice.Proprietary),nameof(SettlementStatus21Choice.Proprietary))]
    [IsoId("_6BJtO5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Status 21 Choice")]
    public abstract partial record SettlementStatus21Choice_
    {
    }
}
