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
    [KnownType(typeof(RateType49Choice.Code))]
    [KnownType(typeof(RateType49Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType49Choice.Code),nameof(RateType49Choice.Code))]
    [JsonDerivedType(typeof(RateType49Choice.Proprietary),nameof(RateType49Choice.Proprietary))]
    #endif
    [IsoId("_ckMxC5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 49 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType49Choice_
    #else
    public abstract partial class RateType49Choice_
    #endif
    {
    }
}
