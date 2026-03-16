// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of verifications performed prior or after the transaction.
/// </summary>
[IsoId("_8prHcSYDEeym0KcvJF9aDQ")]
[DisplayName("Verification Result")]
public record VerificationResult2
{
    /// <summary>
    /// Type of the verification or authentication.
    /// </summary>
    [IsoId("_8uxp4SYDEeym0KcvJF9aDQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Entity who actually performed the verification.
    /// ISO 8583:93 bit 22-9
    /// </summary>
    [IsoId("_8uxp4yYDEeym0KcvJF9aDQ")]
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity2Code? Entity { get; init; }

    /// <summary>
    /// Other national or private entity in charge of the verification.
    /// </summary>
    [IsoId("_8uxp5SYDEeym0KcvJF9aDQ")]
    [DisplayName("Other Entity")]
    [IsoXmlTag("OthrNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherEntity { get; init; }

    /// <summary>
    /// Result of the verification.
    /// </summary>
    [IsoId("_8uxp5yYDEeym0KcvJF9aDQ")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification3Code? Result { get; init; }

    /// <summary>
    /// Additional result of the verification, for instance for electronic commerce.
    /// </summary>
    [IsoId("_8uxp6SYDEeym0KcvJF9aDQ")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? OtherResult { get; init; }

    /// <summary>
    /// Details of the result.
    /// </summary>
    [IsoId("_8uxp6yYDEeym0KcvJF9aDQ")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public AdditionalData1? ResultDetails { get; init; }
}
