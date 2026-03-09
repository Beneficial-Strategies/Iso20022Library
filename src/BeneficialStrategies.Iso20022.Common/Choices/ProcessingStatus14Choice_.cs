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
    [KnownType(typeof(ProcessingStatus14Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus14Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus14Choice.Completed))]
    [KnownType(typeof(ProcessingStatus14Choice.Denied))]
    [KnownType(typeof(ProcessingStatus14Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus14Choice.Pending))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus14Choice.AcknowledgedAccepted),nameof(ProcessingStatus14Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus14Choice.Rejected),nameof(ProcessingStatus14Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus14Choice.Completed),nameof(ProcessingStatus14Choice.Completed))]
    [JsonDerivedType(typeof(ProcessingStatus14Choice.Denied),nameof(ProcessingStatus14Choice.Denied))]
    [JsonDerivedType(typeof(ProcessingStatus14Choice.Proprietary),nameof(ProcessingStatus14Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingStatus14Choice.Pending),nameof(ProcessingStatus14Choice.Pending))]
    #endif
    [IsoId("_KXLkUfI4Ed-dOvqmSLSz5g")]
    [DisplayName("Processing Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus14Choice_
    #else
    public abstract partial class ProcessingStatus14Choice_
    #endif
    {
    }
}
