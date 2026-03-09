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
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat14Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat14Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat14Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat14Choice.Rate),nameof(RateAndAmountFormat14Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat14Choice.NotSpecifiedRate),nameof(RateAndAmountFormat14Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat14Choice.Amount),nameof(RateAndAmountFormat14Choice.Amount))]
    #endif
    [IsoId("_po6BweGYEd-1Ktb5rVaajw")]
    [DisplayName("Rate And Amount Format 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat14Choice_
    #else
    public abstract partial class RateAndAmountFormat14Choice_
    #endif
    {
    }
}
