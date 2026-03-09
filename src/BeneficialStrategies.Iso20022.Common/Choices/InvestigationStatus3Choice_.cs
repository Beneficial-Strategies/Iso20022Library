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
    [KnownType(typeof(InvestigationStatus3Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus3Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus3Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus3Choice.AssignmentCancellationConfirmation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationStatus3Choice.Confirmation),nameof(InvestigationStatus3Choice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationStatus3Choice.RejectedModification),nameof(InvestigationStatus3Choice.RejectedModification))]
    [JsonDerivedType(typeof(InvestigationStatus3Choice.DuplicateOf),nameof(InvestigationStatus3Choice.DuplicateOf))]
    [JsonDerivedType(typeof(InvestigationStatus3Choice.AssignmentCancellationConfirmation),nameof(InvestigationStatus3Choice.AssignmentCancellationConfirmation))]
    #endif
    [IsoId("_tx5SAVkyEeGeoaLUQk__nA_-868345500")]
    [DisplayName("Investigation Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationStatus3Choice_
    #else
    public abstract partial class InvestigationStatus3Choice_
    #endif
    {
    }
}
