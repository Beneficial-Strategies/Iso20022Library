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
    [KnownType(typeof(ProcessingStatus62Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus62Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus62Choice.Repair))]
    [KnownType(typeof(ProcessingStatus62Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus62Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus62Choice.CancellationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus62Choice.AcknowledgedAccepted),nameof(ProcessingStatus62Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.PendingProcessing),nameof(ProcessingStatus62Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.Repair),nameof(ProcessingStatus62Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.PendingCancellation),nameof(ProcessingStatus62Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.Proprietary),nameof(ProcessingStatus62Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus62Choice.CancellationRequested),nameof(ProcessingStatus62Choice.CancellationRequested))]
    #endif
    [IsoId("_6d7vh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 62 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus62Choice_
    #else
    public abstract partial class ProcessingStatus62Choice_
    #endif
    {
    }
}
