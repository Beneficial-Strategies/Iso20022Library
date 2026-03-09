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
    [KnownType(typeof(RatioFormat5Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat5Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat5Choice.AmountToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat5Choice.QuantityToQuantity),nameof(RatioFormat5Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat5Choice.NotSpecifiedRate),nameof(RatioFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat5Choice.AmountToAmount),nameof(RatioFormat5Choice.AmountToAmount))]
    #endif
    [IsoId("_Q2IUxdp-Ed-ak6NoX_4Aeg_1134486617")]
    [DisplayName("Ratio Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat5Choice_
    #else
    public abstract partial class RatioFormat5Choice_
    #endif
    {
    }
}
