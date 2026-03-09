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
    /// Choice of format between a rate, an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat37Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat37Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat37Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat37Choice.Rate),nameof(RateAndAmountFormat37Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat37Choice.NotSpecifiedRate),nameof(RateAndAmountFormat37Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat37Choice.Amount),nameof(RateAndAmountFormat37Choice.Amount))]
    #endif
    [IsoId("_qDDni0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 37 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat37Choice_
    #else
    public abstract partial class RateAndAmountFormat37Choice_
    #endif
    {
    }
}
