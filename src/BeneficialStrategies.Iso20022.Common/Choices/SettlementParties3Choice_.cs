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
    [KnownType(typeof(SettlementParties3Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties3Choice.ReceivingSettlementParties))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementParties3Choice.DeliveringSettlementParties),nameof(SettlementParties3Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties3Choice.ReceivingSettlementParties),nameof(SettlementParties3Choice.ReceivingSettlementParties))]
    #endif
    [IsoId("__eyMsWQQEeSTN56gbbyx2g")]
    [DisplayName("Settlement Parties 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties3Choice_
    #else
    public abstract partial class SettlementParties3Choice_
    #endif
    {
    }
}
