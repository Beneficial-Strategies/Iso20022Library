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
    /// Choice of formats for a processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus94Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus94Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus94Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus94Choice.Repair))]
    [KnownType(typeof(ProcessingStatus94Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus94Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus94Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus94Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus94Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus94Choice.AcknowledgedAccepted),nameof(ProcessingStatus94Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.PendingProcessing),nameof(ProcessingStatus94Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.Rejected),nameof(ProcessingStatus94Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.Repair),nameof(ProcessingStatus94Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.Cancelled),nameof(ProcessingStatus94Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.PendingCancellation),nameof(ProcessingStatus94Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.Proprietary),nameof(ProcessingStatus94Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.CancellationRequested),nameof(ProcessingStatus94Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus94Choice.ModificationRequested),nameof(ProcessingStatus94Choice.ModificationRequested))]
    #endif
    [IsoId("_f979JTi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 94 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus94Choice_
    #else
    public abstract partial class ProcessingStatus94Choice_
    #endif
    {
    }
}
