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
    [KnownType(typeof(PriceFormat8Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat8Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat8Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat8Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat8Choice.PercentagePrice),nameof(PriceFormat8Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat8Choice.AmountPrice),nameof(PriceFormat8Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat8Choice.NotSpecifiedPrice),nameof(PriceFormat8Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat8Choice.IndexPoints),nameof(PriceFormat8Choice.IndexPoints))]
    #endif
    [IsoId("_Q2Reutp-Ed-ak6NoX_4Aeg_1518172190")]
    [DisplayName("Price Format 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat8Choice_
    #else
    public abstract partial class PriceFormat8Choice_
    #endif
    {
    }
}
