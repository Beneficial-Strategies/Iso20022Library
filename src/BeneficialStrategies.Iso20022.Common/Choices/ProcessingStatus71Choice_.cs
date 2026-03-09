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
    [KnownType(typeof(ProcessingStatus71Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus71Choice.Pending))]
    [KnownType(typeof(ProcessingStatus71Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus71Choice.Repair))]
    [KnownType(typeof(ProcessingStatus71Choice.Denied))]
    [KnownType(typeof(ProcessingStatus71Choice.Completed))]
    [KnownType(typeof(ProcessingStatus71Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus71Choice.AcknowledgedAccepted),nameof(ProcessingStatus71Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Pending),nameof(ProcessingStatus71Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Rejected),nameof(ProcessingStatus71Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Repair),nameof(ProcessingStatus71Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Denied),nameof(ProcessingStatus71Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Completed),nameof(ProcessingStatus71Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus71Choice.Proprietary),nameof(ProcessingStatus71Choice.Proprietary))]
    #endif
    [IsoId("_mZpJceGKEeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 71 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus71Choice_
    #else
    public abstract partial class ProcessingStatus71Choice_
    #endif
    {
    }
}
