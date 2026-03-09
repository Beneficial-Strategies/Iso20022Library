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
    /// Choice between a percentage price or an amount price.
    /// </summary>
    [KnownType(typeof(PriceFormat52Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat52Choice.AmountPrice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat52Choice.PercentagePrice),nameof(PriceFormat52Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat52Choice.AmountPrice),nameof(PriceFormat52Choice.AmountPrice))]
    #endif
    [IsoId("_chez55KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat52Choice_
    #else
    public abstract partial class PriceFormat52Choice_
    #endif
    {
    }
}
