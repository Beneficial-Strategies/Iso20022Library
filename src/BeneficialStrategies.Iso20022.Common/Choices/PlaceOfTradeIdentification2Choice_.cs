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
    /// Indicates whether the trade was executed on or off-market.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification2Choice.MarketIdentification))]
    [KnownType(typeof(PlaceOfTradeIdentification2Choice.OffMarket))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PlaceOfTradeIdentification2Choice.MarketIdentification),nameof(PlaceOfTradeIdentification2Choice.MarketIdentification))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification2Choice.OffMarket),nameof(PlaceOfTradeIdentification2Choice.OffMarket))]
    #endif
    [IsoId("_TCfepNp-Ed-ak6NoX_4Aeg_2102299149")]
    [DisplayName("Place Of Trade Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PlaceOfTradeIdentification2Choice_
    #else
    public abstract partial class PlaceOfTradeIdentification2Choice_
    #endif
    {
    }
}
