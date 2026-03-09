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
    [KnownType(typeof(RateType21Choice.Code))]
    [KnownType(typeof(RateType21Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateType21Choice.Code),nameof(RateType21Choice.Code))]
    [JsonDerivedType(typeof(RateType21Choice.Proprietary),nameof(RateType21Choice.Proprietary))]
    #endif
    [IsoId("_OuazSRFbEeKp2ZN13DI_pA")]
    [DisplayName("Rate Type 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateType21Choice_
    #else
    public abstract partial class RateType21Choice_
    #endif
    {
    }
}
