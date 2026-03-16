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
[IsoId("_-FthiHltEeG7BsjMvd1mEw_-1983093565")]
[DisplayName("Undertaking")]
public record Undertaking8
{
    /// <summary>
    /// Unique and unambiguous identifier assigned by the issuer to the undertaking, for example the guarantee or standby number.
    /// </summary>
    [IsoId("_-F3SgHltEeG7BsjMvd1mEw_-9844509")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party that issues the undertaking.
    /// </summary>
    [IsoId("_-F3SgXltEeG7BsjMvd1mEw_444242760")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification43 Issuer { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the applicant to the undertaking.
    /// </summary>
    [IsoId("_-F3SgnltEeG7BsjMvd1mEw_1980172388")]
    [DisplayName("Applicant Reference Number")]
    [IsoXmlTag("ApplcntRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicantReferenceNumber { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier assigned by the beneficiary to the undertaking.
    /// </summary>
    [IsoId("_-F3Sg3ltEeG7BsjMvd1mEw_1024554528")]
    [DisplayName("Beneficiary Reference Number")]
    [IsoXmlTag("BnfcryRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BeneficiaryReferenceNumber { get; init; }
}
