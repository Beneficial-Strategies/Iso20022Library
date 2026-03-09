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
    [KnownType(typeof(RateAndAmountFormat39Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat39Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat39Choice.Rate),nameof(RateAndAmountFormat39Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat39Choice.Amount),nameof(RateAndAmountFormat39Choice.Amount))]
    #endif
    [IsoId("_7YUqLUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat39Choice_
    #else
    public abstract partial class RateAndAmountFormat39Choice_
    #endif
    {
    }
}
