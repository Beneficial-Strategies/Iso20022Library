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
    /// Choice of response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus8Choice.Consented))]
    [KnownType(typeof(ResponseStatus8Choice.Rejected))]
    [KnownType(typeof(ResponseStatus8Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResponseStatus8Choice.Consented),nameof(ResponseStatus8Choice.Consented))]
    [JsonDerivedType(typeof(ResponseStatus8Choice.Rejected),nameof(ResponseStatus8Choice.Rejected))]
    [JsonDerivedType(typeof(ResponseStatus8Choice.Pending),nameof(ResponseStatus8Choice.Pending))]
    #endif
    [IsoId("_Vl2wJZNSEeWGlc8L7oPDIg")]
    [DisplayName("Response Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseStatus8Choice_
    #else
    public abstract partial class ResponseStatus8Choice_
    #endif
    {
    }
}
