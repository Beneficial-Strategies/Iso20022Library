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
    [KnownType(typeof(SettlementStatus7Choice.Pending))]
    [KnownType(typeof(SettlementStatus7Choice.Failing))]
    [KnownType(typeof(SettlementStatus7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus7Choice.Pending),nameof(SettlementStatus7Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus7Choice.Failing),nameof(SettlementStatus7Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus7Choice.Proprietary),nameof(SettlementStatus7Choice.Proprietary))]
    #endif
    [IsoId("_Bsv4If40EeClUvPNHKL9Zw")]
    [DisplayName("Settlement Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus7Choice_
    #else
    public abstract partial class SettlementStatus7Choice_
    #endif
    {
    }
}
