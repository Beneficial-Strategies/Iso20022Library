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
    [KnownType(typeof(IndicativeOrMarketPrice11Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice11Choice.MarketPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndicativeOrMarketPrice11Choice.IndicativePrice),nameof(IndicativeOrMarketPrice11Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice11Choice.MarketPrice),nameof(IndicativeOrMarketPrice11Choice.MarketPrice))]
    #endif
    [IsoId("_ctkH_ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Or Market Price 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndicativeOrMarketPrice11Choice_
    #else
    public abstract partial class IndicativeOrMarketPrice11Choice_
    #endif
    {
    }
}
