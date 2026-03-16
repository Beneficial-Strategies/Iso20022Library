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
[IsoId("_T-GLS9p-Ed-ak6NoX_4Aeg_-1949574113")]
[DisplayName("Case Status")]
public record CaseStatus2
{
    /// <summary>
    /// Date and time of the status.
    /// </summary>
    [IsoId("_T-GLTNp-Ed-ak6NoX_4Aeg_-1949574096")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; }

    /// <summary>
    /// Status of the case.
    /// </summary>
    [IsoId("_T-P8QNp-Ed-ak6NoX_4Aeg_-1949574078")]
    [DisplayName("Case Status")]
    [IsoXmlTag("CaseSts")]
    public required CaseStatus2Code CaseStatus { get; init; }

    /// <summary>
    /// Free text justification of the status.
    /// </summary>
    [IsoId("_T-P8Qdp-Ed-ak6NoX_4Aeg_-1949574053")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Reason { get; init; }
}
