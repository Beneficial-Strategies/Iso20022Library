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
    /// Provides the status of a transaction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus56Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus56Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus56Choice.Accepted))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus56Choice.Rejected),nameof(ProcessingStatus56Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus56Choice.Cancelled),nameof(ProcessingStatus56Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus56Choice.Accepted),nameof(ProcessingStatus56Choice.Accepted))]
    #endif
    [IsoId("_c72FMTt5EeW638lNyHKv7A")]
    [DisplayName("Processing Status 56 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus56Choice_
    #else
    public abstract partial class ProcessingStatus56Choice_
    #endif
    {
    }
}
