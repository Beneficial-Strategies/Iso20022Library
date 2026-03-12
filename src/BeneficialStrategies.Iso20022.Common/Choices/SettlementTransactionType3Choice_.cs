// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement transaction type information.
    /// </summary>
    [KnownType(typeof(SettlementTransactionType3Choice.Code))]
    [KnownType(typeof(SettlementTransactionType3Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementTransactionType3Choice.Code),nameof(SettlementTransactionType3Choice.Code))]
    [JsonDerivedType(typeof(SettlementTransactionType3Choice.Proprietary),nameof(SettlementTransactionType3Choice.Proprietary))]
    [IsoId("_vaMsYZCAEeakHoV5BVecAQ")]
    [DisplayName("Settlement Transaction Type 3 Choice")]
    public abstract partial record SettlementTransactionType3Choice_
    {
    }
}
