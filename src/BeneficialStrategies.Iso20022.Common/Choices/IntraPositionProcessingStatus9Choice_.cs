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
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Rejected),nameof(IntraPositionProcessingStatus9Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Repair),nameof(IntraPositionProcessingStatus9Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Cancelled),nameof(IntraPositionProcessingStatus9Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus9Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Proprietary),nameof(IntraPositionProcessingStatus9Choice.Proprietary))]
    #endif
    [IsoId("_ZJraQStUEeyhipY4f42fZQ")]
    [DisplayName("Intra Position Processing Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus9Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus9Choice_
    #endif
    {
    }
}
