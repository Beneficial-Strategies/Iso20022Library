// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties4Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties4Choice.ReceivingSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties4Choice.DeliveringSettlementParties),nameof(SettlementParties4Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties4Choice.ReceivingSettlementParties),nameof(SettlementParties4Choice.ReceivingSettlementParties))]
    [IsoId("_Bjd9wWpSEeSgo9vJrfSF_Q")]
    [DisplayName("Settlement Parties 4 Choice")]
    public abstract partial record SettlementParties4Choice_
    {
    }
}
