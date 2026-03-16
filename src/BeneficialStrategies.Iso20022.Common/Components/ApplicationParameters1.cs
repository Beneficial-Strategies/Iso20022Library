// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
[IsoId("_Kszxt31DEeCF8NjrBemJWQ_-1395067707")]
[DisplayName("Application Parameters")]
public record ApplicationParameters1
{
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_KszxuH1DEeCF8NjrBemJWQ_612888040")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_Ks9isH1DEeCF8NjrBemJWQ_-1037235663")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text Version { get; init; }

    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_Ks9isX1DEeCF8NjrBemJWQ_43960857")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public SimpleValueList<IsoMax10000Binary> Parameters { get; init; } = [];

    /// <summary>
    /// Sensitive parameters (sequence of Parameters including the enveloppes) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_Ks9isn1DEeCF8NjrBemJWQ_1230522082")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType2? EncryptedParameters { get; init; }
}
