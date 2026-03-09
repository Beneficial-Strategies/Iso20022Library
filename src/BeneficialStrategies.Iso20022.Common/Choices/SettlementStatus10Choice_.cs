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
    [KnownType(typeof(SettlementStatus10Choice.Pending))]
    [KnownType(typeof(SettlementStatus10Choice.Failing))]
    [KnownType(typeof(SettlementStatus10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementStatus10Choice.Pending),nameof(SettlementStatus10Choice.Pending))]
    [JsonDerivedType(typeof(SettlementStatus10Choice.Failing),nameof(SettlementStatus10Choice.Failing))]
    [JsonDerivedType(typeof(SettlementStatus10Choice.Proprietary),nameof(SettlementStatus10Choice.Proprietary))]
    #endif
    [IsoId("_bfizof7rEeCvPoRGOxRobQ")]
    [DisplayName("Settlement Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus10Choice_
    #else
    public abstract partial class SettlementStatus10Choice_
    #endif
    {
    }
}
