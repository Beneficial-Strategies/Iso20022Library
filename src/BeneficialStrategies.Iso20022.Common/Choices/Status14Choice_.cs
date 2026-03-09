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
    [KnownType(typeof(Status14Choice.Status))]
    [KnownType(typeof(Status14Choice.Rejected))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status14Choice.Status),nameof(Status14Choice.Status))]
    [JsonDerivedType(typeof(Status14Choice.Rejected),nameof(Status14Choice.Rejected))]
    #endif
    [IsoId("_HT5NMR6rEeODgY9qxg6TFA")]
    [DisplayName("Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status14Choice_
    #else
    public abstract partial class Status14Choice_
    #endif
    {
    }
}
