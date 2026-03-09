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
    [KnownType(typeof(PriceFormat19Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat19Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat19Choice.NotSpecifiedPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat19Choice.PercentagePrice),nameof(PriceFormat19Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat19Choice.AmountPrice),nameof(PriceFormat19Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat19Choice.NotSpecifiedPrice),nameof(PriceFormat19Choice.NotSpecifiedPrice))]
    #endif
    [IsoId("_oc2EQeEJEd-udr336SN7mQ")]
    [DisplayName("Price Format 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat19Choice_
    #else
    public abstract partial class PriceFormat19Choice_
    #endif
    {
    }
}
