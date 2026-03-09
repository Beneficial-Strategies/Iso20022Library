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
    [KnownType(typeof(RatioFormat19Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat19Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat19Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat19Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat19Choice.QuantityToQuantity),nameof(RatioFormat19Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat19Choice.AmountToAmount),nameof(RatioFormat19Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat19Choice.AmountToQuantity),nameof(RatioFormat19Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat19Choice.QuantityToAmount),nameof(RatioFormat19Choice.QuantityToAmount))]
    #endif
    [IsoId("_7_6m0UEKEeWVgfuHGaKtRQ")]
    [DisplayName("Ratio Format 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat19Choice_
    #else
    public abstract partial class RatioFormat19Choice_
    #endif
    {
    }
}
