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
    [KnownType(typeof(RateAndAmountFormat12Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat12Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat12Choice.Rate),nameof(RateAndAmountFormat12Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat12Choice.Amount),nameof(RateAndAmountFormat12Choice.Amount))]
    #endif
    [IsoId("_UOCrxtp-Ed-ak6NoX_4Aeg_1164166315")]
    [DisplayName("Rate And Amount Format 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat12Choice_
    #else
    public abstract partial class RateAndAmountFormat12Choice_
    #endif
    {
    }
}
