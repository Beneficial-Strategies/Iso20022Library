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
    [KnownType(typeof(Status31Choice.Status))]
    [KnownType(typeof(Status31Choice.Rejected))]
    [KnownType(typeof(Status31Choice.Complete))]
    [KnownType(typeof(Status31Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status31Choice.Status),nameof(Status31Choice.Status))]
    [JsonDerivedType(typeof(Status31Choice.Rejected),nameof(Status31Choice.Rejected))]
    [JsonDerivedType(typeof(Status31Choice.Complete),nameof(Status31Choice.Complete))]
    [JsonDerivedType(typeof(Status31Choice.Pending),nameof(Status31Choice.Pending))]
    #endif
    [IsoId("_ySVFQZM6EemKz5EOjv82iQ")]
    [DisplayName("Status 31 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status31Choice_
    #else
    public abstract partial class Status31Choice_
    #endif
    {
    }
}
