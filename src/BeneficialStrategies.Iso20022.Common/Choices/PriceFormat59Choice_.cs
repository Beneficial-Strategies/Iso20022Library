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
    /// Choice between a percentage price or an amount price or an unspecified price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat59Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat59Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat59Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat59Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat59Choice.PercentagePrice),nameof(PriceFormat59Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat59Choice.AmountPrice),nameof(PriceFormat59Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat59Choice.NotSpecifiedPrice),nameof(PriceFormat59Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat59Choice.IndexPoints),nameof(PriceFormat59Choice.IndexPoints))]
    #endif
    [IsoId("_ctkvAZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 59 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat59Choice_
    #else
    public abstract partial class PriceFormat59Choice_
    #endif
    {
    }
}
