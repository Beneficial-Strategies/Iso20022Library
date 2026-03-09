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
    [KnownType(typeof(ProcessingStatus18Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus18Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus18Choice.Completed))]
    [KnownType(typeof(ProcessingStatus18Choice.Denied))]
    [KnownType(typeof(ProcessingStatus18Choice.Pending))]
    [KnownType(typeof(ProcessingStatus18Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus18Choice.AcknowledgedAccepted),nameof(ProcessingStatus18Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Rejected),nameof(ProcessingStatus18Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Completed),nameof(ProcessingStatus18Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Denied),nameof(ProcessingStatus18Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Pending),nameof(ProcessingStatus18Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus18Choice.Proprietary),nameof(ProcessingStatus18Choice.Proprietary))]
    #endif
    [IsoId("_OJMkAf4vEeClUvPNHKL9Zw")]
    [DisplayName("Processing Status 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus18Choice_
    #else
    public abstract partial class ProcessingStatus18Choice_
    #endif
    {
    }
}
