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
    [KnownType(typeof(ProcessingStatus55Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus55Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus55Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus55Choice.AcknowledgedAccepted),nameof(ProcessingStatus55Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus55Choice.Rejected),nameof(ProcessingStatus55Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus55Choice.Proprietary),nameof(ProcessingStatus55Choice.Proprietary))]
    #endif
    [IsoId("_3-jxeTp4EeWVrPy0StzzSg")]
    [DisplayName("Processing Status 55 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus55Choice_
    #else
    public abstract partial class ProcessingStatus55Choice_
    #endif
    {
    }
}
