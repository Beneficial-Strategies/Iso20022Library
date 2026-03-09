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
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat9Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat9Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat9Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat9Choice.Rate),nameof(InterestRateUsedForPaymentFormat9Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat9Choice.Amount),nameof(InterestRateUsedForPaymentFormat9Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat9Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat9Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_cj-G-ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate Used For Payment Format 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateUsedForPaymentFormat9Choice_
    #else
    public abstract partial class InterestRateUsedForPaymentFormat9Choice_
    #endif
    {
    }
}
