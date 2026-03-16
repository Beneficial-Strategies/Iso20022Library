// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing data. protected by a digital signature.
/// </summary>
[IsoId("_NW_1sYtNEeSxlKlAGYErFg")]
[DisplayName("Content Information Type")]
public record ContentInformationType14
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_NjOT0YtNEeSxlKlAGYErFg")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_NjOT14tNEeSxlKlAGYErFg")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public required SignedData4 SignedData { get; init; }
}
