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
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice7Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice7Choice.MarketPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndicativeOrMarketPrice7Choice.IndicativePrice),nameof(IndicativeOrMarketPrice7Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice7Choice.MarketPrice),nameof(IndicativeOrMarketPrice7Choice.MarketPrice))]
    #endif
    [IsoId("_dJ4jPUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Indicative Or Market Price 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndicativeOrMarketPrice7Choice_
    #else
    public abstract partial class IndicativeOrMarketPrice7Choice_
    #endif
    {
    }
}
