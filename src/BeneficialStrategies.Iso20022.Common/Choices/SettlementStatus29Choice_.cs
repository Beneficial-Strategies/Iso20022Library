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
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus29Choice.Pending))]
    [KnownType(typeof(SettlementStatus29Choice.Failing))]
    [KnownType(typeof(SettlementStatus29Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus29Choice.Pending),nameof(SettlementStatus29Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus29Choice.Failing),nameof(SettlementStatus29Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus29Choice.Proprietary),nameof(SettlementStatus29Choice.Proprietary))]
    #endif
    [IsoId("_qTHeGSAdEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Status 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus29Choice_
    #else
    public abstract partial class SettlementStatus29Choice_
    #endif
    {
    }
}
