// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies the parties settling the contract.
    /// </summary>
    [KnownType(typeof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant))]
    [KnownType(typeof(SettlementParties34Choice.IndirectParticipant))]
    [JsonDerivedType(typeof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant),nameof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant))]
    [JsonDerivedType(typeof(SettlementParties34Choice.IndirectParticipant),nameof(SettlementParties34Choice.IndirectParticipant))]
    [IsoId("_vgeGIcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Settlement Parties 34 Choice")]
    public abstract partial record SettlementParties34Choice_
    {
    }
}
