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
    [KnownType(typeof(ResponseStatus3Choice.Consented))]
    [KnownType(typeof(ResponseStatus3Choice.Rejected))]
    [KnownType(typeof(ResponseStatus3Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResponseStatus3Choice.Consented),nameof(ResponseStatus3Choice.Consented))]
    [JsonDerivedType(typeof(ResponseStatus3Choice.Rejected),nameof(ResponseStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(ResponseStatus3Choice.Pending),nameof(ResponseStatus3Choice.Pending))]
    #endif
    [IsoId("_0j-I4AlIEeGATtfOBToyew_1037532092")]
    [DisplayName("Response Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseStatus3Choice_
    #else
    public abstract partial class ResponseStatus3Choice_
    #endif
    {
    }
}
