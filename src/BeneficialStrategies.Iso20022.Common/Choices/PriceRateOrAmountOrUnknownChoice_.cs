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
    /// Choice of formats for the price.
    /// </summary>
    [KnownType(typeof(PriceRateOrAmountOrUnknownChoice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknownChoice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknownChoice.Rate),nameof(PriceRateOrAmountOrUnknownChoice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknownChoice.Amount),nameof(PriceRateOrAmountOrUnknownChoice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator),nameof(PriceRateOrAmountOrUnknownChoice.UnknownIndicator))]
    #endif
    [IsoId("_QaaCFNp-Ed-ak6NoX_4Aeg_974375674")]
    [DisplayName("Price Rate Or Amount Or Unknown Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateOrAmountOrUnknownChoice_
    #else
    public abstract partial class PriceRateOrAmountOrUnknownChoice_
    #endif
    {
    }
}
