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
    /// Specifies the status and the reason of the operation.
    /// </summary>
    [KnownType(typeof(ProcessingStatus72Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus72Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus72Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus72Choice.Completed))]
    [KnownType(typeof(ProcessingStatus72Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus72Choice.AcknowledgedAccepted),nameof(ProcessingStatus72Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.PendingProcessing),nameof(ProcessingStatus72Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.Rejected),nameof(ProcessingStatus72Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.Completed),nameof(ProcessingStatus72Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus72Choice.Proprietary),nameof(ProcessingStatus72Choice.Proprietary))]
    #endif
    [IsoId("_atiHUeLtEeWOD7aAy2fAcA")]
    [DisplayName("Processing Status 72 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus72Choice_
    #else
    public abstract partial class ProcessingStatus72Choice_
    #endif
    {
    }
}
