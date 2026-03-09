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
    [KnownType(typeof(ResponseStatus6Choice.Consented))]
    [KnownType(typeof(ResponseStatus6Choice.Rejected))]
    [KnownType(typeof(ResponseStatus6Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ResponseStatus6Choice.Consented),nameof(ResponseStatus6Choice.Consented))]
    [JsonDerivedType(typeof(ResponseStatus6Choice.Rejected),nameof(ResponseStatus6Choice.Rejected))]
    [JsonDerivedType(typeof(ResponseStatus6Choice.Pending),nameof(ResponseStatus6Choice.Pending))]
    #endif
    [IsoId("_l8zcITzpEeWeNtT0s2RbkQ")]
    [DisplayName("Response Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ResponseStatus6Choice_
    #else
    public abstract partial class ResponseStatus6Choice_
    #endif
    {
    }
}
