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
[IsoId("_lx7V0T1vEfCQAqQ9lolFUg")]
[DisplayName("Verification8")]
public record Verification8
{
    /// <summary>
    /// Type of authentication or verification. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_l0ndcT1vEfCQAqQ9lolFUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalAuthenticationMethod1Code? Type { get; init; }

    /// <summary>
    /// Type of authentication for a given method (for example, three domain authentication, scheme proprietary solution, type of cryptogram, etc.).
    /// </summary>
    [IsoId("_l0nddT1vEfCQAqQ9lolFUg")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    /// <summary>
    /// Contains verification or authentication data.
    /// </summary>
    [IsoId("_l0nddz1vEfCQAqQ9lolFUg")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<VerificationValue1> Data { get; init; } = [];

    /// <summary>
    /// Personal Identification Number data.
    /// </summary>
    [IsoId("_l0ndeT1vEfCQAqQ9lolFUg")]
    [DisplayName("PIN Data")]
    [IsoXmlTag("PINData")]
    public PINData1? PINData { get; init; }

    /// <summary>
    /// Entity who actually performed the verification. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_l0ndjT1vEfCQAqQ9lolFUg")]
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity3Code? Entity { get; init; }

    /// <summary>
    /// Result of the verification. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_l0ndkT1vEfCQAqQ9lolFUg")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification4Code? Result { get; init; }

    /// <summary>
    /// Details of the result.
    /// </summary>
    [IsoId("_l0ndlT1vEfCQAqQ9lolFUg")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public IsoATICALaxProcessing? ResultDetails { get; init; }
}
