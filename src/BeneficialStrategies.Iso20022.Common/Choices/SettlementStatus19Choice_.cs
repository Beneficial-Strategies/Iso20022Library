// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus19Choice.Code))]
    [KnownType(typeof(SettlementStatus19Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus19Choice.Code),nameof(SettlementStatus19Choice.Code))]
    [JsonDerivedType(typeof(SettlementStatus19Choice.Proprietary),nameof(SettlementStatus19Choice.Proprietary))]
    [IsoId("_5XEwwTqqEeWyoP0PbocV1Q")]
    [DisplayName("Settlement Status 19 Choice")]
    public abstract partial record SettlementStatus19Choice_
    {
    }
}
