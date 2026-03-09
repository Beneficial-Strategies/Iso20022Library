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
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Rejected),nameof(IntraPositionProcessingStatus3Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Repair),nameof(IntraPositionProcessingStatus3Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Cancelled),nameof(IntraPositionProcessingStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus3Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus3Choice.Proprietary),nameof(IntraPositionProcessingStatus3Choice.Proprietary))]
    #endif
    [IsoId("_ifpDQf4wEeClUvPNHKL9Zw")]
    [DisplayName("Intra Position Processing Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus3Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus3Choice_
    #endif
    {
    }
}
