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
    [KnownType(typeof(ProcessingStatus64Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus64Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus64Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProcessingStatus64Choice.AcknowledgedAccepted),nameof(ProcessingStatus64Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(ProcessingStatus64Choice.Rejected),nameof(ProcessingStatus64Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus64Choice.Proprietary),nameof(ProcessingStatus64Choice.Proprietary))]
    #endif
    [IsoId("_8Rtax5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 64 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus64Choice_
    #else
    public abstract partial class ProcessingStatus64Choice_
    #endif
    {
    }
}
