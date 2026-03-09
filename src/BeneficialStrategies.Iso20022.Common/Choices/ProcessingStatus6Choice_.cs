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
    [KnownType(typeof(ProcessingStatus6Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus6Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus6Choice.Repair))]
    [KnownType(typeof(ProcessingStatus6Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus6Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus6Choice.CancellationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus6Choice.AcknowledgedAccepted),nameof(ProcessingStatus6Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.PendingProcessing),nameof(ProcessingStatus6Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.Repair),nameof(ProcessingStatus6Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.PendingCancellation),nameof(ProcessingStatus6Choice.PendingCancellation))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.Proprietary),nameof(ProcessingStatus6Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus6Choice.CancellationRequested),nameof(ProcessingStatus6Choice.CancellationRequested))]
    #endif
    [IsoId("_UVMcpNp-Ed-ak6NoX_4Aeg_-399020300")]
    [DisplayName("Processing Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus6Choice_
    #else
    public abstract partial class ProcessingStatus6Choice_
    #endif
    {
    }
}
