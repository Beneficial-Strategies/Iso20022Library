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
    [KnownType(typeof(ProcessingStatus91Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus91Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus91Choice.Completed))]
    [KnownType(typeof(ProcessingStatus91Choice.Denied))]
    [KnownType(typeof(ProcessingStatus91Choice.Pending))]
    [KnownType(typeof(ProcessingStatus91Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus91Choice.AcknowledgedAccepted),nameof(ProcessingStatus91Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Rejected),nameof(ProcessingStatus91Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Completed),nameof(ProcessingStatus91Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Denied),nameof(ProcessingStatus91Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Pending),nameof(ProcessingStatus91Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus91Choice.Proprietary),nameof(ProcessingStatus91Choice.Proprietary))]
    #endif
    [IsoId("_diXTAzi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 91 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus91Choice_
    #else
    public abstract partial class ProcessingStatus91Choice_
    #endif
    {
    }
}
