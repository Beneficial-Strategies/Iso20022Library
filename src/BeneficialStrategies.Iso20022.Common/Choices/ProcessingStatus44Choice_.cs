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
    [KnownType(typeof(ProcessingStatus44Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus44Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus44Choice.Completed))]
    [KnownType(typeof(ProcessingStatus44Choice.Denied))]
    [KnownType(typeof(ProcessingStatus44Choice.Pending))]
    [KnownType(typeof(ProcessingStatus44Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus44Choice.AcknowledgedAccepted),nameof(ProcessingStatus44Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus44Choice.Rejected),nameof(ProcessingStatus44Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus44Choice.Completed),nameof(ProcessingStatus44Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus44Choice.Denied),nameof(ProcessingStatus44Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus44Choice.Pending),nameof(ProcessingStatus44Choice.Pending))]
    [JsonDerivedType(typeof(ProcessingStatus44Choice.Proprietary),nameof(ProcessingStatus44Choice.Proprietary))]
    #endif
    [IsoId("_h_e0t1hgEeS8HfHHd4stCA")]
    [DisplayName("Processing Status 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus44Choice_
    #else
    public abstract partial class ProcessingStatus44Choice_
    #endif
    {
    }
}
