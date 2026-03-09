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
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus5Choice.Rejected),nameof(IntraPositionProcessingStatus5Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus5Choice.Repair),nameof(IntraPositionProcessingStatus5Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus5Choice.Cancelled),nameof(IntraPositionProcessingStatus5Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus5Choice.Proprietary),nameof(IntraPositionProcessingStatus5Choice.Proprietary))]
    #endif
    [IsoId("_DwdiUTnuEeWfSKvvZlhRKg")]
    [DisplayName("Intra Position Processing Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus5Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus5Choice_
    #endif
    {
    }
}
