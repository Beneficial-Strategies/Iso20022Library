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
    [KnownType(typeof(SettlementStatus9Choice.Pending))]
    [KnownType(typeof(SettlementStatus9Choice.Failing))]
    [KnownType(typeof(SettlementStatus9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus9Choice.Pending),nameof(SettlementStatus9Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus9Choice.Failing),nameof(SettlementStatus9Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus9Choice.Proprietary),nameof(SettlementStatus9Choice.Proprietary))]
    #endif
    [IsoId("_mz-M8f41EeClUvPNHKL9Zw")]
    [DisplayName("Settlement Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus9Choice_
    #else
    public abstract partial class SettlementStatus9Choice_
    #endif
    {
    }
}
