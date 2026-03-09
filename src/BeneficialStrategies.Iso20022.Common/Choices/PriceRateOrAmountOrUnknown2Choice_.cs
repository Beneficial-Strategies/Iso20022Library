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
    [KnownType(typeof(PriceRateOrAmountOrUnknown2Choice.Rate))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown2Choice.Amount))]
    [KnownType(typeof(PriceRateOrAmountOrUnknown2Choice.UnknownIndicator))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown2Choice.Rate),nameof(PriceRateOrAmountOrUnknown2Choice.Rate))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown2Choice.Amount),nameof(PriceRateOrAmountOrUnknown2Choice.Amount))]
    [JsonDerivedType(typeof(PriceRateOrAmountOrUnknown2Choice.UnknownIndicator),nameof(PriceRateOrAmountOrUnknown2Choice.UnknownIndicator))]
    #endif
    [IsoId("_LWuZEbQCEee1Ke-6rZgsrA")]
    [DisplayName("Price Rate Or Amount Or Unknown 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceRateOrAmountOrUnknown2Choice_
    #else
    public abstract partial class PriceRateOrAmountOrUnknown2Choice_
    #endif
    {
    }
}
