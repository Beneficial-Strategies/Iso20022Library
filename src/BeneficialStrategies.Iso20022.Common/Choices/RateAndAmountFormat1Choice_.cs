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
    /// Choice of format between rate, amount and not specified.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat1Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat1Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat1Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat1Choice.Rate),nameof(RateAndAmountFormat1Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat1Choice.Amount),nameof(RateAndAmountFormat1Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat1Choice.NotSpecifiedRate),nameof(RateAndAmountFormat1Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UPrqg9p-Ed-ak6NoX_4Aeg_238520249")]
    [DisplayName("Rate And Amount Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat1Choice_
    #else
    public abstract partial class RateAndAmountFormat1Choice_
    #endif
    {
    }
}
