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
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat57Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat57Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat57Choice.NotSpecifiedPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat57Choice.PercentagePrice),nameof(PriceFormat57Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat57Choice.AmountPrice),nameof(PriceFormat57Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat57Choice.NotSpecifiedPrice),nameof(PriceFormat57Choice.NotSpecifiedPrice))]
    #endif
    [IsoId("_ctfPh5KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 57 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat57Choice_
    #else
    public abstract partial class PriceFormat57Choice_
    #endif
    {
    }
}
