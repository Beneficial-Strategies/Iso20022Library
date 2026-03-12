// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus16Choice.Pending))]
    [KnownType(typeof(SettlementStatus16Choice.Failing))]
    [KnownType(typeof(SettlementStatus16Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementStatus16Choice.Pending),nameof(SettlementStatus16Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus16Choice.Failing),nameof(SettlementStatus16Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus16Choice.Proprietary),nameof(SettlementStatus16Choice.Proprietary))]
    [IsoId("_zV8niTp4EeWVrPy0StzzSg")]
    [DisplayName("Settlement Status 16 Choice")]
    public abstract partial record SettlementStatus16Choice_
    {
    }
}
