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
    /// Choice of format to express a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat23Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat23Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat23Choice.AmountToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat23Choice.QuantityToQuantity),nameof(RatioFormat23Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat23Choice.NotSpecifiedRate),nameof(RatioFormat23Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat23Choice.AmountToAmount),nameof(RatioFormat23Choice.AmountToAmount))]
    #endif
    [IsoId("_cti6FpKQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat23Choice_
    #else
    public abstract partial class RatioFormat23Choice_
    #endif
    {
    }
}
