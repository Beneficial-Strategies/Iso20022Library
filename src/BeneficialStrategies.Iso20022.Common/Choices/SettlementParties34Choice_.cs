// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies the parties settling the contract.
    /// </summary>
    [KnownType(typeof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant))]
    [KnownType(typeof(SettlementParties34Choice.IndirectParticipant))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant),nameof(SettlementParties34Choice.CentralSecuritiesDepositoryParticipant))]
    [JsonDerivedType(typeof(SettlementParties34Choice.IndirectParticipant),nameof(SettlementParties34Choice.IndirectParticipant))]
    #endif
    [IsoId("_vgeGIcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Settlement Parties 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties34Choice_
    #else
    public abstract partial class SettlementParties34Choice_
    #endif
    {
    }
}
