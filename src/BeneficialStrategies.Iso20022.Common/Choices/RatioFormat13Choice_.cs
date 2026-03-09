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
    [KnownType(typeof(RatioFormat13Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat13Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat13Choice.AmountToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat13Choice.QuantityToQuantity),nameof(RatioFormat13Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat13Choice.NotSpecifiedRate),nameof(RatioFormat13Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat13Choice.AmountToAmount),nameof(RatioFormat13Choice.AmountToAmount))]
    #endif
    [IsoId("_feZYGQgYEeCVlvYcV4HKqQ")]
    [DisplayName("Ratio Format 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat13Choice_
    #else
    public abstract partial class RatioFormat13Choice_
    #endif
    {
    }
}
