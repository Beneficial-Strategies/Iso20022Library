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
    [KnownType(typeof(ProcessingStatus67Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus67Choice.Repair))]
    [KnownType(typeof(ProcessingStatus67Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus67Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus67Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus67Choice.Rejected),nameof(ProcessingStatus67Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus67Choice.Repair),nameof(ProcessingStatus67Choice.Repair))]
    [JsonDerivedType(typeof(ProcessingStatus67Choice.Cancelled),nameof(ProcessingStatus67Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus67Choice.AcknowledgedAccepted),nameof(ProcessingStatus67Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus67Choice.Proprietary),nameof(ProcessingStatus67Choice.Proprietary))]
    #endif
    [IsoId("_W7Icl-FUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 67 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus67Choice_
    #else
    public abstract partial class ProcessingStatus67Choice_
    #endif
    {
    }
}
