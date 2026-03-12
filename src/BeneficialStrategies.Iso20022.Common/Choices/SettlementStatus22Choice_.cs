// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus22Choice.Pending))]
    [KnownType(typeof(SettlementStatus22Choice.Failing))]
    [KnownType(typeof(SettlementStatus22Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus22Choice.Pending),nameof(SettlementStatus22Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus22Choice.Failing),nameof(SettlementStatus22Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus22Choice.Proprietary),nameof(SettlementStatus22Choice.Proprietary))]
    [IsoId("_6QBPv5NLEeWGlc8L7oPDIg")]
    [DisplayName("Settlement Status 22 Choice")]
    public abstract partial record SettlementStatus22Choice_
    {
    }
}
