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
    [KnownType(typeof(ProcessingStatus69Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus69Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus69Choice.Repair))]
    [KnownType(typeof(ProcessingStatus69Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus69Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus69Choice.Denied))]
    [KnownType(typeof(ProcessingStatus69Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus69Choice.PendingCancellation),nameof(ProcessingStatus69Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus69Choice.Rejected),nameof(ProcessingStatus69Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus69Choice.Repair),nameof(ProcessingStatus69Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus69Choice.AcknowledgedAccepted),nameof(ProcessingStatus69Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus69Choice.Proprietary),nameof(ProcessingStatus69Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus69Choice.Denied),nameof(ProcessingStatus69Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus69Choice.Cancelled),nameof(ProcessingStatus69Choice.Cancelled))]
    #endif
    [IsoId("_1m2RQeF7EeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 69 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus69Choice_
    #else
    public abstract partial class ProcessingStatus69Choice_
    #endif
    {
    }
}
