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
    [KnownType(typeof(InvestigationStatus5Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus5Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus5Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus5Choice.AssignmentCancellationConfirmation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationStatus5Choice.Confirmation),nameof(InvestigationStatus5Choice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationStatus5Choice.RejectedModification),nameof(InvestigationStatus5Choice.RejectedModification))]
    [JsonDerivedType(typeof(InvestigationStatus5Choice.DuplicateOf),nameof(InvestigationStatus5Choice.DuplicateOf))]
    [JsonDerivedType(typeof(InvestigationStatus5Choice.AssignmentCancellationConfirmation),nameof(InvestigationStatus5Choice.AssignmentCancellationConfirmation))]
    #endif
    [IsoId("_NIe3H249EeiU9cctagi5ow")]
    [DisplayName("Investigation Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationStatus5Choice_
    #else
    public abstract partial class InvestigationStatus5Choice_
    #endif
    {
    }
}
