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
    /// expressed as a ISO20022 code.
    /// </summary>
    [KnownType(typeof(TradeDate4Choice.Date))]
    [KnownType(typeof(TradeDate4Choice.Value))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradeDate4Choice.Date),nameof(TradeDate4Choice.Date))]
    [JsonDerivedType(typeof(TradeDate4Choice.Value),nameof(TradeDate4Choice.Value))]
    #endif
    [IsoId("_AXK_UdokEeC60axPepSq7g_-1712034418")]
    [DisplayName("Trade Date 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeDate4Choice_
    #else
    public abstract partial class TradeDate4Choice_
    #endif
    {
    }
}
