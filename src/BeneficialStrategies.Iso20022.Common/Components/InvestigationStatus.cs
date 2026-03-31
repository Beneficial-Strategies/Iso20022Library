// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investigation Status.
/// </summary>
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
[IsoId("_T99BX9p-Ed-ak6NoX_4Aeg_1223362204")]
[DisplayName("Investigation Status")]
public record InvestigationStatus
{
    /// <summary>
    /// Assignment Cancellation Confirmation.
    /// </summary>
    [DisplayName("Assignment Cancellation Confirmation")]
    [IsoXmlTag("AssgnmtCxlConf")]
    public required IsoYesNoIndicator AssignmentCancellationConfirmation { get; init; }

    /// <summary>
    /// Confirmation.
    /// </summary>
    [DisplayName("Confirmation")]
    [IsoXmlTag("Conf")]
    public required InvestigationExecutionConfirmation2Code Confirmation { get; init; }

    /// <summary>
    /// Duplicate Of.
    /// </summary>
    [DisplayName("Duplicate Of")]
    [IsoXmlTag("DplctOf")]
    public required Case DuplicateOf { get; init; }

    /// <summary>
    /// Rejected Cancellation.
    /// </summary>
    [DisplayName("Rejected Cancellation")]
    [IsoXmlTag("RjctdCxl")]
    public required RejectedCancellationJustification RejectedCancellation { get; init; }

    /// <summary>
    /// Rejected Modification.
    /// </summary>
    [DisplayName("Rejected Modification")]
    [IsoXmlTag("RjctdMod")]
    public required PaymentModificationRejection1Code RejectedModification { get; init; }

    /// <summary>
    /// Return Information.
    /// </summary>
    [DisplayName("Return Information")]
    [IsoXmlTag("RtrInf")]
    public ReturnInformation1? ReturnInformation { get; init; }
}
