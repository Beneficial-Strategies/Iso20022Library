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
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus85Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus85Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus85Choice.Completed))]
    [KnownType(typeof(ProcessingStatus85Choice.Denied))]
    [KnownType(typeof(ProcessingStatus85Choice.Pending))]
    [KnownType(typeof(ProcessingStatus85Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus85Choice.AcknowledgedAccepted),nameof(ProcessingStatus85Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus85Choice.Rejected),nameof(ProcessingStatus85Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus85Choice.Completed),nameof(ProcessingStatus85Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus85Choice.Denied),nameof(ProcessingStatus85Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus85Choice.Pending),nameof(ProcessingStatus85Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus85Choice.Proprietary),nameof(ProcessingStatus85Choice.Proprietary))]
    #endif
    [IsoId("_nnJUAytVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 85 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus85Choice_
    #else
    public abstract partial class ProcessingStatus85Choice_
    #endif
    {
    }
}
