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
    /// Choice of the source (place) of the price quotation.
    /// </summary>
    [KnownType(typeof(PriceSourceFormatChoice.LocalMarketPlace))]
    [KnownType(typeof(PriceSourceFormatChoice.NonLocalMarketPlace))]
    [KnownType(typeof(PriceSourceFormatChoice.PlaceAsDSS))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceSourceFormatChoice.LocalMarketPlace),nameof(PriceSourceFormatChoice.LocalMarketPlace))]
    [JsonDerivedType(typeof(PriceSourceFormatChoice.NonLocalMarketPlace),nameof(PriceSourceFormatChoice.NonLocalMarketPlace))]
    [JsonDerivedType(typeof(PriceSourceFormatChoice.PlaceAsDSS),nameof(PriceSourceFormatChoice.PlaceAsDSS))]
    #endif
    [IsoId("_RCDQ49p-Ed-ak6NoX_4Aeg_2134054867")]
    [DisplayName("Price Source Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceSourceFormatChoice_
    #else
    public abstract partial class PriceSourceFormatChoice_
    #endif
    {
    }
}
