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
    [KnownType(typeof(ProcessingStatus86Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus86Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus86Choice.Repair))]
    [KnownType(typeof(ProcessingStatus86Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus86Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus86Choice.Denied))]
    [KnownType(typeof(ProcessingStatus86Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus86Choice.PendingCancellation),nameof(ProcessingStatus86Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Rejected),nameof(ProcessingStatus86Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Repair),nameof(ProcessingStatus86Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.AcknowledgedAccepted),nameof(ProcessingStatus86Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Proprietary),nameof(ProcessingStatus86Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Denied),nameof(ProcessingStatus86Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus86Choice.Cancelled),nameof(ProcessingStatus86Choice.Cancelled))]
    #endif
    [IsoId("_oYBXVytVEeyhipY4f42fZQ")]
    [DisplayName("Processing Status 86 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus86Choice_
    #else
    public abstract partial class ProcessingStatus86Choice_
    #endif
    {
    }
}
