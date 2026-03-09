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
    [KnownType(typeof(RatioFormat1Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat1Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat1Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RatioFormat1Choice.QuantityToQuantity),nameof(RatioFormat1Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat1Choice.AmountToAmount),nameof(RatioFormat1Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat1Choice.NotSpecifiedRate),nameof(RatioFormat1Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_Rjuamtp-Ed-ak6NoX_4Aeg_-320337061")]
    [DisplayName("Ratio Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RatioFormat1Choice_
    #else
    public abstract partial class RatioFormat1Choice_
    #endif
    {
    }
}
