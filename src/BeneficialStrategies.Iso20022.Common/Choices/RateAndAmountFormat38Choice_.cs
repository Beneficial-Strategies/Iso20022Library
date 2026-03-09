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
    /// Choice of format between a rate, an amount, index points or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat38Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat38Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat38Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat38Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.Rate),nameof(RateAndAmountFormat38Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.NotSpecifiedRate),nameof(RateAndAmountFormat38Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.Amount),nameof(RateAndAmountFormat38Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat38Choice.IndexPoints),nameof(RateAndAmountFormat38Choice.IndexPoints))]
    #endif
    [IsoId("_yF0j0UEEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat38Choice_
    #else
    public abstract partial class RateAndAmountFormat38Choice_
    #endif
    {
    }
}
