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
    [KnownType(typeof(RatioFormat4Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat4Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat4Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat4Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat4Choice.QuantityToQuantity),nameof(RatioFormat4Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat4Choice.AmountToAmount),nameof(RatioFormat4Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat4Choice.AmountToQuantity),nameof(RatioFormat4Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat4Choice.QuantityToAmount),nameof(RatioFormat4Choice.QuantityToAmount))]
    #endif
    [IsoId("_Q1h31dp-Ed-ak6NoX_4Aeg_544072927")]
    [DisplayName("Ratio Format 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat4Choice_
    #else
    public abstract partial class RatioFormat4Choice_
    #endif
    {
    }
}
