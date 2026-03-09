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
    [KnownType(typeof(RatioFormat14Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat14Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat14Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat14Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat14Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat14Choice.QuantityToQuantity),nameof(RatioFormat14Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat14Choice.NotSpecifiedRate),nameof(RatioFormat14Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat14Choice.AmountToAmount),nameof(RatioFormat14Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat14Choice.AmountToQuantity),nameof(RatioFormat14Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat14Choice.QuantityToAmount),nameof(RatioFormat14Choice.QuantityToAmount))]
    #endif
    [IsoId("_fflq5ggYEeCVlvYcV4HKqQ")]
    [DisplayName("Ratio Format 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat14Choice_
    #else
    public abstract partial class RatioFormat14Choice_
    #endif
    {
    }
}
