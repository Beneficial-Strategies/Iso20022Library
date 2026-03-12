// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem4Choice.Code))]
    [KnownType(typeof(CashSettlementSystem4Choice.Proprietary))]
    [JsonDerivedType(typeof(CashSettlementSystem4Choice.Code),nameof(CashSettlementSystem4Choice.Code))]
    [JsonDerivedType(typeof(CashSettlementSystem4Choice.Proprietary),nameof(CashSettlementSystem4Choice.Proprietary))]
    [IsoId("_AF_qMTqHEeWVrPy0StzzSg")]
    [DisplayName("Cash Settlement System 4 Choice")]
    public abstract partial record CashSettlementSystem4Choice_
    {
    }
}
