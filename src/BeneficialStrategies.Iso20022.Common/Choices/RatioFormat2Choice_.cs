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
    [KnownType(typeof(RatioFormat2Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat2Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat2Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat2Choice.QuantityToAmount))]
    [KnownType(typeof(RatioFormat2Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat2Choice.QuantityToQuantity),nameof(RatioFormat2Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat2Choice.AmountToAmount),nameof(RatioFormat2Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat2Choice.AmountToQuantity),nameof(RatioFormat2Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat2Choice.QuantityToAmount),nameof(RatioFormat2Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat2Choice.NotSpecifiedRate),nameof(RatioFormat2Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_Rj3kg9p-Ed-ak6NoX_4Aeg_1081569462")]
    [DisplayName("Ratio Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat2Choice_
    #else
    public abstract partial class RatioFormat2Choice_
    #endif
    {
    }
}
