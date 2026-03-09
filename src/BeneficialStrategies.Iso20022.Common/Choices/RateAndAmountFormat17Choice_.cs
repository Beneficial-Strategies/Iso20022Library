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
    [KnownType(typeof(RateAndAmountFormat17Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat17Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat17Choice.Amount),nameof(RateAndAmountFormat17Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat17Choice.NotSpecifiedRate),nameof(RateAndAmountFormat17Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_fq6xMggYEeCVlvYcV4HKqQ")]
    [DisplayName("Rate And Amount Format 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat17Choice_
    #else
    public abstract partial class RateAndAmountFormat17Choice_
    #endif
    {
    }
}
