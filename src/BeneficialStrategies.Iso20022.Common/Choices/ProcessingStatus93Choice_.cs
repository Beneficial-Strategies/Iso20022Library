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
    [KnownType(typeof(ProcessingStatus93Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus93Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus93Choice.Repair))]
    [KnownType(typeof(ProcessingStatus93Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus93Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus93Choice.Denied))]
    [KnownType(typeof(ProcessingStatus93Choice.Cancelled))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus93Choice.PendingCancellation),nameof(ProcessingStatus93Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus93Choice.Rejected),nameof(ProcessingStatus93Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus93Choice.Repair),nameof(ProcessingStatus93Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus93Choice.AcknowledgedAccepted),nameof(ProcessingStatus93Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus93Choice.Proprietary),nameof(ProcessingStatus93Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus93Choice.Denied),nameof(ProcessingStatus93Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus93Choice.Cancelled),nameof(ProcessingStatus93Choice.Cancelled))]
    #endif
    [IsoId("_ds1dYTi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 93 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus93Choice_
    #else
    public abstract partial class ProcessingStatus93Choice_
    #endif
    {
    }
}
