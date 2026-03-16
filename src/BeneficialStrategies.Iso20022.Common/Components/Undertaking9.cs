// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an undertaking.
/// </summary>
[IsoId("_-GKNcXltEeG7BsjMvd1mEw_-1016448236")]
[DisplayName("Undertaking")]
public record Undertaking9
{
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [IsoId("_-GKNcnltEeG7BsjMvd1mEw_153618864")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party that issues the undertaking.
    /// </summary>
    [IsoId("_-GKNc3ltEeG7BsjMvd1mEw_2114872489")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification43 Issuer { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_-GKNdHltEeG7BsjMvd1mEw_-848102774")]
    [DisplayName("Applicant Reference Number")]
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicantReferenceNumber { get; init; }
}
