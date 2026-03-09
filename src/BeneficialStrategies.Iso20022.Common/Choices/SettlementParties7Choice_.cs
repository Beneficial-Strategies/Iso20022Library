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
    /// Provides details on either the delivering or receiving parties.
    /// </summary>
    [KnownType(typeof(SettlementParties7Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties7Choice.ReceivingSettlementParties))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementParties7Choice.DeliveringSettlementParties),nameof(SettlementParties7Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties7Choice.ReceivingSettlementParties),nameof(SettlementParties7Choice.ReceivingSettlementParties))]
    #endif
    [IsoId("_tQ_Rl4pIEeaNTaanBSMWmg")]
    [DisplayName("Settlement Parties 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties7Choice_
    #else
    public abstract partial class SettlementParties7Choice_
    #endif
    {
    }
}
