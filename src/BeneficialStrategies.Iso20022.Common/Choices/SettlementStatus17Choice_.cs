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
    [KnownType(typeof(SettlementStatus17Choice.Pending))]
    [KnownType(typeof(SettlementStatus17Choice.Failing))]
    [KnownType(typeof(SettlementStatus17Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus17Choice.Pending),nameof(SettlementStatus17Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus17Choice.Failing),nameof(SettlementStatus17Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus17Choice.Proprietary),nameof(SettlementStatus17Choice.Proprietary))]
    #endif
    [IsoId("_z2VXwTp4EeWVrPy0StzzSg")]
    [DisplayName("Settlement Status 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus17Choice_
    #else
    public abstract partial class SettlementStatus17Choice_
    #endif
    {
    }
}
