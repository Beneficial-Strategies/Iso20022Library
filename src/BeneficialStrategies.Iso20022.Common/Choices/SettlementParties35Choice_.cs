// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties35Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties35Choice.ReceivingSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties35Choice.DeliveringSettlementParties),nameof(SettlementParties35Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties35Choice.ReceivingSettlementParties),nameof(SettlementParties35Choice.ReceivingSettlementParties))]
    [IsoId("_TJKXdyqSEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Parties 35 Choice")]
    public abstract partial record SettlementParties35Choice_
    {
    }
}
