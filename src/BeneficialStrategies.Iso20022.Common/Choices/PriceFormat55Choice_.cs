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
    [KnownType(typeof(PriceFormat55Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat55Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat55Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat55Choice.PercentagePrice),nameof(PriceFormat55Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat55Choice.AmountPrice),nameof(PriceFormat55Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat55Choice.IndexPoints),nameof(PriceFormat55Choice.IndexPoints))]
    #endif
    [IsoId("_ckDmi5KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 55 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat55Choice_
    #else
    public abstract partial class PriceFormat55Choice_
    #endif
    {
    }
}
