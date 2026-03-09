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
    [KnownType(typeof(RateAndAmountFormat48Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat48Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat48Choice.Amount),nameof(RateAndAmountFormat48Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat48Choice.NotSpecifiedRate),nameof(RateAndAmountFormat48Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_ctpnW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 48 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat48Choice_
    #else
    public abstract partial class RateAndAmountFormat48Choice_
    #endif
    {
    }
}
