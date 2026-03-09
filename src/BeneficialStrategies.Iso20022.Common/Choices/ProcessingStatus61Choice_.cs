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
    [KnownType(typeof(ProcessingStatus61Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus61Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus61Choice.Repair))]
    [KnownType(typeof(ProcessingStatus61Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus61Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus61Choice.Denied))]
    [KnownType(typeof(ProcessingStatus61Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus61Choice.PendingCancellation),nameof(ProcessingStatus61Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Rejected),nameof(ProcessingStatus61Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Repair),nameof(ProcessingStatus61Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.AcknowledgedAccepted),nameof(ProcessingStatus61Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Proprietary),nameof(ProcessingStatus61Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Denied),nameof(ProcessingStatus61Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus61Choice.Cancelled),nameof(ProcessingStatus61Choice.Cancelled))]
    #endif
    [IsoId("_6QDryZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 61 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus61Choice_
    #else
    public abstract partial class ProcessingStatus61Choice_
    #endif
    {
    }
}
