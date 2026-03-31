// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the status of an investigation case.
/// </summary>
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
[IsoId("_VJDih9p-Ed-ak6NoX_4Aeg_964129193")]
[DisplayName("Case Status")]
public record CaseStatus
{
    /// <summary>
    /// Date and time of the status.
    /// </summary>
    [IsoId("_VJDiiNp-Ed-ak6NoX_4Aeg_964129600")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; }

    /// <summary>
    /// Status of the case.
    /// </summary>
    [IsoXmlTag("CaseSts")]
    public required CaseStatus1Code Value { get; init; }

    /// <summary>
    /// Status of the investigation.
    /// </summary>
    [IsoId("_VJMscNp-Ed-ak6NoX_4Aeg_-392540477")]
    [DisplayName("Investigation Status")]
    [IsoXmlTag("InvstgtnSts")]
    public InvestigationExecutionConfirmation1Code? InvestigationStatus { get; init; }

    /// <summary>
    /// Free text justification of the status.
    /// </summary>
    [IsoId("_VJMscdp-Ed-ak6NoX_4Aeg_-1534881594")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Reason { get; init; }
}
