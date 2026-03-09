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
    [KnownType(typeof(RatioFormat15Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat15Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat15Choice.QuantityToAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat15Choice.QuantityToQuantity),nameof(RatioFormat15Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat15Choice.AmountToAmount),nameof(RatioFormat15Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat15Choice.QuantityToAmount),nameof(RatioFormat15Choice.QuantityToAmount))]
    #endif
    [IsoId("_CTIcofpYEeCRofvVIFrSrw")]
    [DisplayName("Ratio Format 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat15Choice_
    #else
    public abstract partial class RatioFormat15Choice_
    #endif
    {
    }
}
