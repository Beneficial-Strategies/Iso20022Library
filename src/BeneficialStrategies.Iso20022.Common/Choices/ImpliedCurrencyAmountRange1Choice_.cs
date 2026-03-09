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
    /// Choice between ranges of values in which an amount is considered valid or a specified amount value which has to be matched or unmatched to be valid.
    /// </summary>
    [KnownType(typeof(ImpliedCurrencyAmountRange1Choice.FromAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRange1Choice.ToAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRange1Choice.FromToAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRange1Choice.EqualAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRange1Choice.NotEqualAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRange1Choice.FromAmount),nameof(ImpliedCurrencyAmountRange1Choice.FromAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRange1Choice.ToAmount),nameof(ImpliedCurrencyAmountRange1Choice.ToAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRange1Choice.FromToAmount),nameof(ImpliedCurrencyAmountRange1Choice.FromToAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRange1Choice.EqualAmount),nameof(ImpliedCurrencyAmountRange1Choice.EqualAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRange1Choice.NotEqualAmount),nameof(ImpliedCurrencyAmountRange1Choice.NotEqualAmount))]
    #endif
    [IsoId("_O3sLVZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Implied Currency Amount Range 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ImpliedCurrencyAmountRange1Choice_
    #else
    public abstract partial class ImpliedCurrencyAmountRange1Choice_
    #endif
    {
    }
}
