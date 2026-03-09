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
    [KnownType(typeof(RatioFormat22Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat22Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat22Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat22Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat22Choice.QuantityToQuantity),nameof(RatioFormat22Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat22Choice.AmountToAmount),nameof(RatioFormat22Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat22Choice.AmountToQuantity),nameof(RatioFormat22Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat22Choice.QuantityToAmount),nameof(RatioFormat22Choice.QuantityToAmount))]
    #endif
    [IsoId("_ckCYWJKQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat22Choice_
    #else
    public abstract partial class RatioFormat22Choice_
    #endif
    {
    }
}
