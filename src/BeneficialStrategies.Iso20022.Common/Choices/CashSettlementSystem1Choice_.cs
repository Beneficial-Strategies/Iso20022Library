// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cash settlement system.
    /// </summary>
    [KnownType(typeof(CashSettlementSystem1Choice.Code))]
    [KnownType(typeof(CashSettlementSystem1Choice.Proprietary))]
    [JsonDerivedType(typeof(CashSettlementSystem1Choice.Code),nameof(CashSettlementSystem1Choice.Code))]
    [JsonDerivedType(typeof(CashSettlementSystem1Choice.Proprietary),nameof(CashSettlementSystem1Choice.Proprietary))]
    [IsoId("_Qv3Ut9p-Ed-ak6NoX_4Aeg_-955027637")]
    [DisplayName("Cash Settlement System 1 Choice")]
    public abstract partial record CashSettlementSystem1Choice_
    {
    }
}
