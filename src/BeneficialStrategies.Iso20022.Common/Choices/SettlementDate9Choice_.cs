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
    [KnownType(typeof(SettlementDate9Choice.Date))]
    [KnownType(typeof(SettlementDate9Choice.DateCode))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate9Choice.Date),nameof(SettlementDate9Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate9Choice.DateCode),nameof(SettlementDate9Choice.DateCode))]
    #endif
    [IsoId("_bUxy4TqLEeWVrPy0StzzSg")]
    [DisplayName("Settlement Date 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate9Choice_
    #else
    public abstract partial class SettlementDate9Choice_
    #endif
    {
    }
}
