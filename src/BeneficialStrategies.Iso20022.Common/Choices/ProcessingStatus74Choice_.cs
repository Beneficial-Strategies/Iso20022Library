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
    [KnownType(typeof(ProcessingStatus74Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus74Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus74Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus74Choice.Repair))]
    [KnownType(typeof(ProcessingStatus74Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus74Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus74Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus74Choice.CancellationRequested))]
    [KnownType(typeof(ProcessingStatus74Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus74Choice.AcknowledgedAccepted),nameof(ProcessingStatus74Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.PendingProcessing),nameof(ProcessingStatus74Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.Rejected),nameof(ProcessingStatus74Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.Repair),nameof(ProcessingStatus74Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.Cancelled),nameof(ProcessingStatus74Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.PendingCancellation),nameof(ProcessingStatus74Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.Proprietary),nameof(ProcessingStatus74Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.CancellationRequested),nameof(ProcessingStatus74Choice.CancellationRequested))]
    [JsonDerivedType(typeof(ProcessingStatus74Choice.ModificationRequested),nameof(ProcessingStatus74Choice.ModificationRequested))]
    #endif
    [IsoId("_GLFV8dB7EeihG9bKfarOOA")]
    [DisplayName("Processing Status 74 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus74Choice_
    #else
    public abstract partial class ProcessingStatus74Choice_
    #endif
    {
    }
}
