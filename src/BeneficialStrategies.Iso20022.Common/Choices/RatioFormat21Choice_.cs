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
    [KnownType(typeof(RatioFormat21Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat21Choice.AmountToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat21Choice.QuantityToQuantity),nameof(RatioFormat21Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat21Choice.AmountToAmount),nameof(RatioFormat21Choice.AmountToAmount))]
    #endif
    [IsoId("_ckBxt5KQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat21Choice_
    #else
    public abstract partial class RatioFormat21Choice_
    #endif
    {
    }
}
