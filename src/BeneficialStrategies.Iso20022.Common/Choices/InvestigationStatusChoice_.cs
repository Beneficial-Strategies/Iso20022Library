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
    /// Choice between different statuses of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatusChoice.Confirmation))]
    [KnownType(typeof(InvestigationStatusChoice.RejectedModification))]
    [KnownType(typeof(InvestigationStatusChoice.RejectedCancellation))]
    [KnownType(typeof(InvestigationStatusChoice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatusChoice.AssignmentCancellationConfirmation))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationStatusChoice.Confirmation),nameof(InvestigationStatusChoice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.RejectedModification),nameof(InvestigationStatusChoice.RejectedModification))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.RejectedCancellation),nameof(InvestigationStatusChoice.RejectedCancellation))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.DuplicateOf),nameof(InvestigationStatusChoice.DuplicateOf))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.AssignmentCancellationConfirmation),nameof(InvestigationStatusChoice.AssignmentCancellationConfirmation))]
    #endif
    [IsoId("_UuYYstp-Ed-ak6NoX_4Aeg_788596093")]
    [DisplayName("Investigation Status Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationStatusChoice_
    #else
    public abstract partial class InvestigationStatusChoice_
    #endif
    {
    }
}
