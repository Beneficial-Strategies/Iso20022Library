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
    [KnownType(typeof(SettlementStatus30Choice.Pending))]
    [KnownType(typeof(SettlementStatus30Choice.Failing))]
    [KnownType(typeof(SettlementStatus30Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus30Choice.Pending),nameof(SettlementStatus30Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus30Choice.Failing),nameof(SettlementStatus30Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus30Choice.Proprietary),nameof(SettlementStatus30Choice.Proprietary))]
    #endif
    [IsoId("_coFnuSW-EeygjNFjAlVoPA")]
    [DisplayName("Settlement Status 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus30Choice_
    #else
    public abstract partial class SettlementStatus30Choice_
    #endif
    {
    }
}
