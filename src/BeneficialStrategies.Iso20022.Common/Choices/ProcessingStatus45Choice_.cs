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
    [KnownType(typeof(ProcessingStatus45Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus45Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus45Choice.Repair))]
    [KnownType(typeof(ProcessingStatus45Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus45Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus45Choice.Denied))]
    [KnownType(typeof(ProcessingStatus45Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus45Choice.PendingCancellation),nameof(ProcessingStatus45Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Rejected),nameof(ProcessingStatus45Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Repair),nameof(ProcessingStatus45Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.AcknowledgedAccepted),nameof(ProcessingStatus45Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Proprietary),nameof(ProcessingStatus45Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Denied),nameof(ProcessingStatus45Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus45Choice.Cancelled),nameof(ProcessingStatus45Choice.Cancelled))]
    #endif
    [IsoId("_iZ9xMVhgEeS8HfHHd4stCA")]
    [DisplayName("Processing Status 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus45Choice_
    #else
    public abstract partial class ProcessingStatus45Choice_
    #endif
    {
    }
}
