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
    [KnownType(typeof(RateAndAmountFormat36Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat36Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat36Choice.Rate),nameof(RateAndAmountFormat36Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat36Choice.Amount),nameof(RateAndAmountFormat36Choice.Amount))]
    #endif
    [IsoId("_UZkV4XaCEeOzT_JN45r5OQ")]
    [DisplayName("Rate And Amount Format 36 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat36Choice_
    #else
    public abstract partial class RateAndAmountFormat36Choice_
    #endif
    {
    }
}
