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
    [KnownType(typeof(ProcessingStatus54Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus54Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus54Choice.Repair))]
    [KnownType(typeof(ProcessingStatus54Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus54Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus54Choice.Denied))]
    [KnownType(typeof(ProcessingStatus54Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus54Choice.PendingCancellation),nameof(ProcessingStatus54Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Rejected),nameof(ProcessingStatus54Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Repair),nameof(ProcessingStatus54Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.AcknowledgedAccepted),nameof(ProcessingStatus54Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Proprietary),nameof(ProcessingStatus54Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Denied),nameof(ProcessingStatus54Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus54Choice.Cancelled),nameof(ProcessingStatus54Choice.Cancelled))]
    #endif
    [IsoId("_29-eITp4EeWVrPy0StzzSg")]
    [DisplayName("Processing Status 54 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus54Choice_
    #else
    public abstract partial class ProcessingStatus54Choice_
    #endif
    {
    }
}
