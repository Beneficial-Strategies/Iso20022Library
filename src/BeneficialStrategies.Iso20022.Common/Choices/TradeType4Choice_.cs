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
    /// Choice of format for the trade type.
    /// </summary>
    [KnownType(typeof(TradeType4Choice.Code))]
    [KnownType(typeof(TradeType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeType4Choice.Code),nameof(TradeType4Choice.Code))]
    [JsonDerivedType(typeof(TradeType4Choice.Proprietary),nameof(TradeType4Choice.Proprietary))]
    #endif
    [IsoId("_6gAJsZBgEeakHoV5BVecAQ")]
    [DisplayName("Trade Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeType4Choice_
    #else
    public abstract partial class TradeType4Choice_
    #endif
    {
    }
}
