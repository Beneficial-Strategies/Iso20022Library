// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Destination of the message.
/// </summary>
[IsoId("_ZQh2YE95EeePXdaAO32Uew")]
[DisplayName("Destination")]
public record Destination1
{
    /// <summary>
    /// Identification of the destination of the transaction.
    /// </summary>
    [IsoId("_HtvVFE95EeePXdaAO32Uew")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Identification of the entity assigning the destination identification.
    /// </summary>
    [IsoId("_HtvVFU95EeePXdaAO32Uew")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Country of the destination.
    /// </summary>
    [IsoId("_HtvVFk95EeePXdaAO32Uew")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short name of the destination.
    /// </summary>
    [IsoId("_HtvVF095EeePXdaAO32Uew")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
