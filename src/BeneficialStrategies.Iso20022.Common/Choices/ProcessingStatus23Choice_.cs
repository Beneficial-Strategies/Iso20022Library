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
    [KnownType(typeof(ProcessingStatus23Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus23Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus23Choice.Repair))]
    [KnownType(typeof(ProcessingStatus23Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus23Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus23Choice.CancellationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus23Choice.AcknowledgedAccepted),nameof(ProcessingStatus23Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.PendingProcessing),nameof(ProcessingStatus23Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.Repair),nameof(ProcessingStatus23Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.PendingCancellation),nameof(ProcessingStatus23Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.Proprietary),nameof(ProcessingStatus23Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus23Choice.CancellationRequested),nameof(ProcessingStatus23Choice.CancellationRequested))]
    #endif
    [IsoId("_tTjyYf7sEeCvPoRGOxRobQ")]
    [DisplayName("Processing Status 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus23Choice_
    #else
    public abstract partial class ProcessingStatus23Choice_
    #endif
    {
    }
}
