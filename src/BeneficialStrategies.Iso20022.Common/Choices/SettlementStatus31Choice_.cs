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
    [KnownType(typeof(SettlementStatus31Choice.Pending))]
    [KnownType(typeof(SettlementStatus31Choice.Failing))]
    [KnownType(typeof(SettlementStatus31Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus31Choice.Pending),nameof(SettlementStatus31Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus31Choice.Failing),nameof(SettlementStatus31Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus31Choice.Proprietary),nameof(SettlementStatus31Choice.Proprietary))]
    #endif
    [IsoId("_f99L9Ti8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Status 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus31Choice_
    #else
    public abstract partial class SettlementStatus31Choice_
    #endif
    {
    }
}
