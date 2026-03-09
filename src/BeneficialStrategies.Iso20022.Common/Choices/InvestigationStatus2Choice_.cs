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
    [KnownType(typeof(InvestigationStatus2Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus2Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus2Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus2Choice.AssignmentCancellationConfirmation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationStatus2Choice.Confirmation),nameof(InvestigationStatus2Choice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationStatus2Choice.RejectedModification),nameof(InvestigationStatus2Choice.RejectedModification))]
    [JsonDerivedType(typeof(InvestigationStatus2Choice.DuplicateOf),nameof(InvestigationStatus2Choice.DuplicateOf))]
    [JsonDerivedType(typeof(InvestigationStatus2Choice.AssignmentCancellationConfirmation),nameof(InvestigationStatus2Choice.AssignmentCancellationConfirmation))]
    #endif
    [IsoId("_T-P8RNp-Ed-ak6NoX_4Aeg_523812389")]
    [DisplayName("Investigation Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationStatus2Choice_
    #else
    public abstract partial class InvestigationStatus2Choice_
    #endif
    {
    }
}
