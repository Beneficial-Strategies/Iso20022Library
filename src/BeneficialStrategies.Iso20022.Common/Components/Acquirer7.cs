// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
/// </summary>
[IsoId("_077-4Yn1EeS9F4Qrq_eaVA")]
[DisplayName("Acquirer")]
public record Acquirer7
{
    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    [IsoId("_1Ivr0Yn1EeS9F4Qrq_eaVA")]
    [DisplayName("Acquiring Institution")]
    [IsoXmlTag("AcqrgInstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AcquiringInstitution { get; init; }

    /// <summary>
    /// Identification of the acquirer branch.
    /// </summary>
    [IsoId("_1Ivr04n1EeS9F4Qrq_eaVA")]
    [DisplayName("Branch")]
    [IsoXmlTag("Brnch")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Branch { get; init; }
}
