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
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Rejected),nameof(IntraPositionProcessingStatus8Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Repair),nameof(IntraPositionProcessingStatus8Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Cancelled),nameof(IntraPositionProcessingStatus8Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus8Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Proprietary),nameof(IntraPositionProcessingStatus8Choice.Proprietary))]
    #endif
    [IsoId("_65NaH_fUEeiNZp_PtLohLw")]
    [DisplayName("Intra Position Processing Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus8Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus8Choice_
    #endif
    {
    }
}
