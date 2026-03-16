// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Method and data intended to be verified as well as the related results.
/// </summary>
[IsoId("_cQ8dAcVVEeuPIIgba4mCug")]
[DisplayName("Verification")]
public record Verification4
{
    /// <summary>
    /// Type of authentication or verification.
    /// </summary>
    [IsoId("_cV-G8cVVEeuPIIgba4mCug")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalAuthenticationMethod1Code? Type { get; init; }

    /// <summary>
    /// Other type of authentication.
    /// </summary>
    [IsoId("_cV-G88VVEeuPIIgba4mCug")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Type of authentication for a given method (for example, three domain authentication, scheme proprietary solution, type of cryptogram, etc.).
    /// </summary>
    [IsoId("_cV-G9cVVEeuPIIgba4mCug")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Additional information about the verification.
    /// </summary>
    [IsoId("_cV-G98VVEeuPIIgba4mCug")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Result of verifications performed prior or after the transaction.
    /// </summary>
    [IsoId("_cV-G-cVVEeuPIIgba4mCug")]
    [DisplayName("Verification Result")]
    [IsoXmlTag("VrfctnRslt")]
    public VerificationResult2? VerificationResult { get; init; }
}
