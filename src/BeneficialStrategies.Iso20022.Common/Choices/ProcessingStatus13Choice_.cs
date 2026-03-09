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
    [KnownType(typeof(ProcessingStatus13Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus13Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus13Choice.Repair))]
    [KnownType(typeof(ProcessingStatus13Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus13Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus13Choice.Denied))]
    [KnownType(typeof(ProcessingStatus13Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus13Choice.PendingCancellation),nameof(ProcessingStatus13Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus13Choice.Rejected),nameof(ProcessingStatus13Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus13Choice.Repair),nameof(ProcessingStatus13Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus13Choice.AcknowledgedAccepted),nameof(ProcessingStatus13Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus13Choice.Proprietary),nameof(ProcessingStatus13Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus13Choice.Denied),nameof(ProcessingStatus13Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus13Choice.Cancelled),nameof(ProcessingStatus13Choice.Cancelled))]
    #endif
    [IsoId("_ZH-k4eZgEd-q8fx_Zl_34A")]
    [DisplayName("Processing Status 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus13Choice_
    #else
    public abstract partial class ProcessingStatus13Choice_
    #endif
    {
    }
}
