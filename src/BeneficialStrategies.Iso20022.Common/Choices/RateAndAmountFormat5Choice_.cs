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
    /// Choice of format between rate and amount.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat5Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat5Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat5Choice.Rate),nameof(RateAndAmountFormat5Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat5Choice.Amount),nameof(RateAndAmountFormat5Choice.Amount))]
    #endif
    [IsoId("_UOCrwNp-Ed-ak6NoX_4Aeg_722186259")]
    [DisplayName("Rate And Amount Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat5Choice_
    #else
    public abstract partial class RateAndAmountFormat5Choice_
    #endif
    {
    }
}
