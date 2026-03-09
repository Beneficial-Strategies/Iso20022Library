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
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.FromAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.ToAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.FromToAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.EqualAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.NotEqualAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRangeChoice.FromAmount),nameof(ImpliedCurrencyAmountRangeChoice.FromAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRangeChoice.ToAmount),nameof(ImpliedCurrencyAmountRangeChoice.ToAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRangeChoice.FromToAmount),nameof(ImpliedCurrencyAmountRangeChoice.FromToAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRangeChoice.EqualAmount),nameof(ImpliedCurrencyAmountRangeChoice.EqualAmount))]
    [JsonDerivedType(typeof(ImpliedCurrencyAmountRangeChoice.NotEqualAmount),nameof(ImpliedCurrencyAmountRangeChoice.NotEqualAmount))]
    #endif
    [IsoId("_PU-ECtp-Ed-ak6NoX_4Aeg_847262836")]
    [DisplayName("Implied Currency Amount Range Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ImpliedCurrencyAmountRangeChoice_
    #else
    public abstract partial class ImpliedCurrencyAmountRangeChoice_
    #endif
    {
    }
}
