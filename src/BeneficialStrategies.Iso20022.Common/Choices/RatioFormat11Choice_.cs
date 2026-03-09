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
    [KnownType(typeof(RatioFormat11Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat11Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat11Choice.AmountToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat11Choice.QuantityToQuantity),nameof(RatioFormat11Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat11Choice.NotSpecifiedRate),nameof(RatioFormat11Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat11Choice.AmountToAmount),nameof(RatioFormat11Choice.AmountToAmount))]
    #endif
    [IsoId("_anZPgOwOEd-sn-FiNtktcA")]
    [DisplayName("Ratio Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat11Choice_
    #else
    public abstract partial class RatioFormat11Choice_
    #endif
    {
    }
}
