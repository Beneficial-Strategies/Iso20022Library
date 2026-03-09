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
    [KnownType(typeof(SettlementStatus28Choice.Pending))]
    [KnownType(typeof(SettlementStatus28Choice.Failing))]
    [KnownType(typeof(SettlementStatus28Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus28Choice.Pending),nameof(SettlementStatus28Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus28Choice.Failing),nameof(SettlementStatus28Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus28Choice.Proprietary),nameof(SettlementStatus28Choice.Proprietary))]
    #endif
    [IsoId("_BH0PmQpIEeup4r-PFG2T5Q")]
    [DisplayName("Settlement Status 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus28Choice_
    #else
    public abstract partial class SettlementStatus28Choice_
    #endif
    {
    }
}
