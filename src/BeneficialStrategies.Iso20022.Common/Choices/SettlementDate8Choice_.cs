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
    [KnownType(typeof(SettlementDate8Choice.Date))]
    [KnownType(typeof(SettlementDate8Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementDate8Choice.Date),nameof(SettlementDate8Choice.Date))]
    [JsonDerivedType(typeof(SettlementDate8Choice.Code),nameof(SettlementDate8Choice.Code))]
    #endif
    [IsoId("_AcsYgtokEeC60axPepSq7g_-1335452175")]
    [DisplayName("Settlement Date 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementDate8Choice_
    #else
    public abstract partial class SettlementDate8Choice_
    #endif
    {
    }
}
