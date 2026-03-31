// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Classification Type4.
/// </summary>
[IsoId("_-66U4eJIEe-5wchdE0oJYw")]
[DisplayName("Classification Type4")]
public record ClassificationType4
{
    /// <summary>
    /// Information Type.
    /// </summary>
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public required ExternalRegulatoryInformationType1Code InformationType { get; init; }

    /// <summary>
    /// Legal Framework.
    /// </summary>
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public ValueList<ExternalLegalFramework1Code> LegalFramework { get; init; } = [];
}
