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
    [KnownType(typeof(RatioFormat17Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat17Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat17Choice.AmountToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat17Choice.QuantityToQuantity),nameof(RatioFormat17Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat17Choice.NotSpecifiedRate),nameof(RatioFormat17Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat17Choice.AmountToAmount),nameof(RatioFormat17Choice.AmountToAmount))]
    #endif
    [IsoId("_vQLksUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Ratio Format 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat17Choice_
    #else
    public abstract partial class RatioFormat17Choice_
    #endif
    {
    }
}
