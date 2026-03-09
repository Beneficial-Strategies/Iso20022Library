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
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat5Choice.Rate),nameof(InterestRateUsedForPaymentFormat5Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat5Choice.Amount),nameof(InterestRateUsedForPaymentFormat5Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate),nameof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_iS_3geEREd-1Ktb5rVaajw")]
    [DisplayName("Interest Rate Used For Payment Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateUsedForPaymentFormat5Choice_
    #else
    public abstract partial class InterestRateUsedForPaymentFormat5Choice_
    #endif
    {
    }
}
