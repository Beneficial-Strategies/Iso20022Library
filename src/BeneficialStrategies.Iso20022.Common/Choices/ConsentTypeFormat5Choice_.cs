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
    /// Choice between a standard code or proprietary code to specify the consent type format required.
    /// </summary>
    [KnownType(typeof(ConsentTypeFormat5Choice.Code))]
    [KnownType(typeof(ConsentTypeFormat5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConsentTypeFormat5Choice.Code),nameof(ConsentTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(ConsentTypeFormat5Choice.Proprietary),nameof(ConsentTypeFormat5Choice.Proprietary))]
    #endif
    [IsoId("_c5Whf5KQEeWHWpTQn1FFVg")]
    [DisplayName("Consent Type Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConsentTypeFormat5Choice_
    #else
    public abstract partial class ConsentTypeFormat5Choice_
    #endif
    {
    }
}
