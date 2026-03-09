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
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus10Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus10Choice.Rejected),nameof(IntraPositionProcessingStatus10Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus10Choice.Repair),nameof(IntraPositionProcessingStatus10Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus10Choice.Cancelled),nameof(IntraPositionProcessingStatus10Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus10Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus10Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus10Choice.Proprietary),nameof(IntraPositionProcessingStatus10Choice.Proprietary))]
    #endif
    [IsoId("_cdk0oTi8Eeydid5dcNPKvg")]
    [DisplayName("Intra Position Processing Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus10Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus10Choice_
    #endif
    {
    }
}
