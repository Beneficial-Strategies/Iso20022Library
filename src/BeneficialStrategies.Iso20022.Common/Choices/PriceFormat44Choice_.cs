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
    [KnownType(typeof(PriceFormat44Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat44Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat44Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat44Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat44Choice.PercentagePrice),nameof(PriceFormat44Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat44Choice.AmountPrice),nameof(PriceFormat44Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat44Choice.NotSpecifiedPrice),nameof(PriceFormat44Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat44Choice.IndexPoints),nameof(PriceFormat44Choice.IndexPoints))]
    #endif
    [IsoId("_J1Q0u0EFEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat44Choice_
    #else
    public abstract partial class PriceFormat44Choice_
    #endif
    {
    }
}
