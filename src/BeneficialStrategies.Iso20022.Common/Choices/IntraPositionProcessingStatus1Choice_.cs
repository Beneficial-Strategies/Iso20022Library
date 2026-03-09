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
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntraPositionProcessingStatus1Choice.Rejected),nameof(IntraPositionProcessingStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus1Choice.Repair),nameof(IntraPositionProcessingStatus1Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus1Choice.Cancelled),nameof(IntraPositionProcessingStatus1Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus1Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus1Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus1Choice.Proprietary),nameof(IntraPositionProcessingStatus1Choice.Proprietary))]
    #endif
    [IsoId("_UW1baNp-Ed-ak6NoX_4Aeg_252032743")]
    [DisplayName("Intra Position Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus1Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus1Choice_
    #endif
    {
    }
}
