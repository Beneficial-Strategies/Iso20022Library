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
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType4Choice.Code))]
    [KnownType(typeof(MarketType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketType4Choice.Code),nameof(MarketType4Choice.Code))]
    [JsonDerivedType(typeof(MarketType4Choice.Proprietary),nameof(MarketType4Choice.Proprietary))]
    #endif
    [IsoId("_Qwm7l9p-Ed-ak6NoX_4Aeg_-1402096058")]
    [DisplayName("Market Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketType4Choice_
    #else
    public abstract partial class MarketType4Choice_
    #endif
    {
    }
}
