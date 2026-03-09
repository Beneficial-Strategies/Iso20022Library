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
    [KnownType(typeof(RatioFormat12Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat12Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat12Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat12Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat12Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat12Choice.QuantityToQuantity),nameof(RatioFormat12Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat12Choice.NotSpecifiedRate),nameof(RatioFormat12Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat12Choice.AmountToAmount),nameof(RatioFormat12Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat12Choice.AmountToQuantity),nameof(RatioFormat12Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat12Choice.QuantityToAmount),nameof(RatioFormat12Choice.QuantityToAmount))]
    #endif
    [IsoId("_g3oegOwOEd-sn-FiNtktcA")]
    [DisplayName("Ratio Format 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat12Choice_
    #else
    public abstract partial class RatioFormat12Choice_
    #endif
    {
    }
}
