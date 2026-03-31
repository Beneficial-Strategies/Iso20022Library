// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification of the document.
/// </summary>
[IsoId("_ThMM0tp-Ed-ak6NoX_4Aeg_-727158599")]
[DisplayName("Document Identification")]
public record DocumentIdentification12
{
    /// <summary>
    /// Unique identifier of the document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_ThMM09p-Ed-ak6NoX_4Aeg_-726238455")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date and time at which the document (message) was created by the sender.
    /// </summary>
    [IsoId("_ThMM1Np-Ed-ak6NoX_4Aeg_-725313985")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; }

    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_ThMM1dp-Ed-ak6NoX_4Aeg_-725313812")]
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }

    /// <summary>
    /// When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_ThMM1tp-Ed-ak6NoX_4Aeg_-383609129")]
    [DisplayName("Change Instruction Indicator")]
    [IsoXmlTag("ChngInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; }
}
