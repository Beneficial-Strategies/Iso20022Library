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
    /// Specifies the status of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatus4Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus4Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus4Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus4Choice.AssignmentCancellationConfirmation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationStatus4Choice.Confirmation),nameof(InvestigationStatus4Choice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationStatus4Choice.RejectedModification),nameof(InvestigationStatus4Choice.RejectedModification))]
    [JsonDerivedType(typeof(InvestigationStatus4Choice.DuplicateOf),nameof(InvestigationStatus4Choice.DuplicateOf))]
    [JsonDerivedType(typeof(InvestigationStatus4Choice.AssignmentCancellationConfirmation),nameof(InvestigationStatus4Choice.AssignmentCancellationConfirmation))]
    #endif
    [IsoId("_nTQy8YmxEeeKR__nUfxjwA")]
    [DisplayName("Investigation Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationStatus4Choice_
    #else
    public abstract partial class InvestigationStatus4Choice_
    #endif
    {
    }
}
