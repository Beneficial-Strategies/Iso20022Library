// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus5Choice.Code))]
    [KnownType(typeof(SettlementStatus5Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus5Choice.Code),nameof(SettlementStatus5Choice.Code))]
    [JsonDerivedType(typeof(SettlementStatus5Choice.Proprietary),nameof(SettlementStatus5Choice.Proprietary))]
    [IsoId("_w2B8LkABEeCaq78Ig8ATcA")]
    [DisplayName("Settlement Status 5 Choice")]
    public abstract partial record SettlementStatus5Choice_
    {
    }
}
