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
    /// Choice between a percentage price or an amount price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat6Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat6Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat6Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat6Choice.PercentagePrice),nameof(PriceFormat6Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat6Choice.AmountPrice),nameof(PriceFormat6Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat6Choice.IndexPoints),nameof(PriceFormat6Choice.IndexPoints))]
    #endif
    [IsoId("_Q1ro3Np-Ed-ak6NoX_4Aeg_633561620")]
    [DisplayName("Price Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat6Choice_
    #else
    public abstract partial class PriceFormat6Choice_
    #endif
    {
    }
}
