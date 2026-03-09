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
    [KnownType(typeof(TaxCreditRateFormat1Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat1Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat1Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.Rate),nameof(TaxCreditRateFormat1Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.Amount),nameof(TaxCreditRateFormat1Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.NotSpecifiedRate),nameof(TaxCreditRateFormat1Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UOVmvNp-Ed-ak6NoX_4Aeg_465502986")]
    [DisplayName("Tax Credit Rate Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCreditRateFormat1Choice_
    #else
    public abstract partial class TaxCreditRateFormat1Choice_
    #endif
    {
    }
}
