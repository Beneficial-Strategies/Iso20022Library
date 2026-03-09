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
    [KnownType(typeof(ProcessingStatus53Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus53Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus53Choice.Repair))]
    [KnownType(typeof(ProcessingStatus53Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus53Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus53Choice.Denied))]
    [KnownType(typeof(ProcessingStatus53Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus53Choice.PendingCancellation),nameof(ProcessingStatus53Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus53Choice.Rejected),nameof(ProcessingStatus53Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus53Choice.Repair),nameof(ProcessingStatus53Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus53Choice.AcknowledgedAccepted),nameof(ProcessingStatus53Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus53Choice.Proprietary),nameof(ProcessingStatus53Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus53Choice.Denied),nameof(ProcessingStatus53Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus53Choice.Cancelled),nameof(ProcessingStatus53Choice.Cancelled))]
    #endif
    [IsoId("_2dJB8Tp4EeWVrPy0StzzSg")]
    [DisplayName("Processing Status 53 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus53Choice_
    #else
    public abstract partial class ProcessingStatus53Choice_
    #endif
    {
    }
}
