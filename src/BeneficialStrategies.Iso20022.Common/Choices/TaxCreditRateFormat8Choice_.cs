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
    [KnownType(typeof(TaxCreditRateFormat8Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat8Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat8Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxCreditRateFormat8Choice.Rate),nameof(TaxCreditRateFormat8Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat8Choice.Amount),nameof(TaxCreditRateFormat8Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat8Choice.NotSpecifiedRate),nameof(TaxCreditRateFormat8Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_W5KBb0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Tax Credit Rate Format 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCreditRateFormat8Choice_
    #else
    public abstract partial class TaxCreditRateFormat8Choice_
    #endif
    {
    }
}
