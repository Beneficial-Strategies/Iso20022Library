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
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat9Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat9Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxCreditRateFormat9Choice.Rate),nameof(TaxCreditRateFormat9Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat9Choice.Amount),nameof(TaxCreditRateFormat9Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat9Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    #endif
    [IsoId("_ckCYvpKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Credit Rate Format 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCreditRateFormat9Choice_
    #else
    public abstract partial class TaxCreditRateFormat9Choice_
    #endif
    {
    }
}
