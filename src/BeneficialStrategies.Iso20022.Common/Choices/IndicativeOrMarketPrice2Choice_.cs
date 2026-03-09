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
    [KnownType(typeof(IndicativeOrMarketPrice2Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice2Choice.MarketPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IndicativeOrMarketPrice2Choice.IndicativePrice),nameof(IndicativeOrMarketPrice2Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice2Choice.MarketPrice),nameof(IndicativeOrMarketPrice2Choice.MarketPrice))]
    #endif
    [IsoId("_UKwuRdp-Ed-ak6NoX_4Aeg_-1375580741")]
    [DisplayName("Indicative Or Market Price 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IndicativeOrMarketPrice2Choice_
    #else
    public abstract partial class IndicativeOrMarketPrice2Choice_
    #endif
    {
    }
}
