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
    [IsoId("_l0ndcT1vEfCQAqQ9lolFUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalAuthenticationMethod1Code? Type { get; init; }

    [IsoId("_l0nddT1vEfCQAqQ9lolFUg")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public IsoMax35Text? SubType { get; init; }

    [IsoId("_l0nddz1vEfCQAqQ9lolFUg")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<VerificationValue1> Data { get; init; } = [];

    [IsoId("_l0ndeT1vEfCQAqQ9lolFUg")]
    [DisplayName("PIN Data")]
    [IsoXmlTag("PINData")]
    public PINData1? PINData { get; init; }

    [IsoId("_l0ndjT1vEfCQAqQ9lolFUg")]
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity3Code? Entity { get; init; }

    [IsoId("_l0ndkT1vEfCQAqQ9lolFUg")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification4Code? Result { get; init; }

    [IsoId("_l0ndlT1vEfCQAqQ9lolFUg")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public IsoATICALaxProcessing? ResultDetails { get; init; }
}
