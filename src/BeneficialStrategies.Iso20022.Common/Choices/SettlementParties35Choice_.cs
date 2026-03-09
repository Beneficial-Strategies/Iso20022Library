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
    [KnownType(typeof(SettlementParties35Choice.DeliveringSettlementParties))]
    [KnownType(typeof(SettlementParties35Choice.ReceivingSettlementParties))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementParties35Choice.DeliveringSettlementParties),nameof(SettlementParties35Choice.DeliveringSettlementParties))]
    [JsonDerivedType(typeof(SettlementParties35Choice.ReceivingSettlementParties),nameof(SettlementParties35Choice.ReceivingSettlementParties))]
    #endif
    [IsoId("_TJKXdyqSEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Parties 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementParties35Choice_
    #else
    public abstract partial class SettlementParties35Choice_
    #endif
    {
    }
}
