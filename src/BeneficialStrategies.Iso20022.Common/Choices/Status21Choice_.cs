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
    /// Choice of formats for the specification of the status.
    /// </summary>
    [KnownType(typeof(Status21Choice.Status))]
    [KnownType(typeof(Status21Choice.Rejected))]
    [KnownType(typeof(Status21Choice.Complete))]
    [KnownType(typeof(Status21Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status21Choice.Status),nameof(Status21Choice.Status))]
    [JsonDerivedType(typeof(Status21Choice.Rejected),nameof(Status21Choice.Rejected))]
    [JsonDerivedType(typeof(Status21Choice.Complete),nameof(Status21Choice.Complete))]
    [JsonDerivedType(typeof(Status21Choice.Pending),nameof(Status21Choice.Pending))]
    #endif
    [IsoId("_zx7jgSYtEeW_ZNn8gbfY7Q")]
    [DisplayName("Status 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status21Choice_
    #else
    public abstract partial class Status21Choice_
    #endif
    {
    }
}
