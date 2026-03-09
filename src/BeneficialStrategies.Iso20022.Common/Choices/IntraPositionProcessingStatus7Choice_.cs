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
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus7Choice.Rejected),nameof(IntraPositionProcessingStatus7Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus7Choice.Repair),nameof(IntraPositionProcessingStatus7Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus7Choice.Cancelled),nameof(IntraPositionProcessingStatus7Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus7Choice.Proprietary),nameof(IntraPositionProcessingStatus7Choice.Proprietary))]
    #endif
    [IsoId("_4EhzQewLEeiazoAmcoGsBQ")]
    [DisplayName("Intra Position Processing Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus7Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus7Choice_
    #endif
    {
    }
}
