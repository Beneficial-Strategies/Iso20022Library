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
    [KnownType(typeof(RatioFormat18Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat18Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat18Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat18Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat18Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat18Choice.QuantityToQuantity),nameof(RatioFormat18Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat18Choice.NotSpecifiedRate),nameof(RatioFormat18Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat18Choice.AmountToAmount),nameof(RatioFormat18Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat18Choice.AmountToQuantity),nameof(RatioFormat18Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat18Choice.QuantityToAmount),nameof(RatioFormat18Choice.QuantityToAmount))]
    #endif
    [IsoId("_7Z03EUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Ratio Format 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat18Choice_
    #else
    public abstract partial class RatioFormat18Choice_
    #endif
    {
    }
}
