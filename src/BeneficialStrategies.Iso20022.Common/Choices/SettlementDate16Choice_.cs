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
    /// Choice of format for the settlement date.
    /// </summary>
    [KnownType(typeof(SettlementDate16Choice.Date))]
    [KnownType(typeof(SettlementDate16Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate16Choice.Date),nameof(SettlementDate16Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate16Choice.Code),nameof(SettlementDate16Choice.Code))]
    #endif
    [IsoId("_GhdJYZBhEeakHoV5BVecAQ")]
    [DisplayName("Settlement Date 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate16Choice_
    #else
    public abstract partial class SettlementDate16Choice_
    #endif
    {
    }
}
