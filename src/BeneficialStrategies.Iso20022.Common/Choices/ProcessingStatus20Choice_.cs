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
    [KnownType(typeof(ProcessingStatus20Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus20Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus20Choice.Repair))]
    [KnownType(typeof(ProcessingStatus20Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus20Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus20Choice.Denied))]
    [KnownType(typeof(ProcessingStatus20Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus20Choice.PendingCancellation),nameof(ProcessingStatus20Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus20Choice.Rejected),nameof(ProcessingStatus20Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus20Choice.Repair),nameof(ProcessingStatus20Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus20Choice.AcknowledgedAccepted),nameof(ProcessingStatus20Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus20Choice.Proprietary),nameof(ProcessingStatus20Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus20Choice.Denied),nameof(ProcessingStatus20Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus20Choice.Cancelled),nameof(ProcessingStatus20Choice.Cancelled))]
    #endif
    [IsoId("_MxzBUf4xEeClUvPNHKL9Zw")]
    [DisplayName("Processing Status 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus20Choice_
    #else
    public abstract partial class ProcessingStatus20Choice_
    #endif
    {
    }
}
