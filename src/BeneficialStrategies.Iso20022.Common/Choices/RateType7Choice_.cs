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
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType7Choice.Code))]
    [KnownType(typeof(RateType7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType7Choice.Code),nameof(RateType7Choice.Code))]
    [JsonDerivedType(typeof(RateType7Choice.Proprietary),nameof(RateType7Choice.Proprietary))]
    #endif
    [IsoId("_Q2bPutp-Ed-ak6NoX_4Aeg_655622014")]
    [DisplayName("Rate Type 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType7Choice_
    #else
    public abstract partial class RateType7Choice_
    #endif
    {
    }
}
