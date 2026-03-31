// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the Identification of the parties settling the contract.
    /// </summary>
    [KnownType(typeof(SettlementParties32Choice.CentralSecuritiesDepositoryParticipant))]
    [KnownType(typeof(SettlementParties32Choice.IndirectParticipant))]
    [JsonDerivedType(
        typeof(SettlementParties32Choice.CentralSecuritiesDepositoryParticipant),
        nameof(SettlementParties32Choice.CentralSecuritiesDepositoryParticipant)
    )]
    [JsonDerivedType(
        typeof(SettlementParties32Choice.IndirectParticipant),
        nameof(SettlementParties32Choice.IndirectParticipant)
    )]
    [IsoId("_AvxQobQ0EemI67HK7aviyg")]
    [DisplayName("Settlement Parties 32 Choice")]
    public abstract record SettlementParties32Choice_ { }
}
