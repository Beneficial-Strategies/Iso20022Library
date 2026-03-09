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
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat6Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat6Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat6Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat6Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat6Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat6Choice.QuantityToQuantity),nameof(RatioFormat6Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat6Choice.NotSpecifiedRate),nameof(RatioFormat6Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat6Choice.AmountToAmount),nameof(RatioFormat6Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat6Choice.AmountToQuantity),nameof(RatioFormat6Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat6Choice.QuantityToAmount),nameof(RatioFormat6Choice.QuantityToAmount))]
    #endif
    [IsoId("_Q1-jxdp-Ed-ak6NoX_4Aeg_-2128705050")]
    [DisplayName("Ratio Format 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat6Choice_
    #else
    public abstract partial class RatioFormat6Choice_
    #endif
    {
    }
}
