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
    /// Choice of format between a rate, an amount, index points or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat50Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat50Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat50Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat50Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat50Choice.Rate),nameof(RateAndAmountFormat50Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat50Choice.NotSpecifiedRate),nameof(RateAndAmountFormat50Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat50Choice.Amount),nameof(RateAndAmountFormat50Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat50Choice.IndexPoints),nameof(RateAndAmountFormat50Choice.IndexPoints))]
    #endif
    [IsoId("_c5SQhZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 50 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat50Choice_
    #else
    public abstract partial class RateAndAmountFormat50Choice_
    #endif
    {
    }
}
