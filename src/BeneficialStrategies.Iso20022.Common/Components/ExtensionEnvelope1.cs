// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Technical component that contains the validated extension information. This technical envelope allows to segregate the extension information from any other information.
/// </summary>
[IsoId("_QzJSM9p-Ed-ak6NoX_4Aeg_-1719963560")]
[DisplayName("Extension Envelope")]
public record ExtensionEnvelope1
{
    /// <summary>
    /// Technical element that specifies the extension.
    /// </summary>
    [IsoId("_QzJSNNp-Ed-ak6NoX_4Aeg_-2120876746")]
    [DisplayName("Extension Contents")]
    [IsoXmlTag("XtnsnCnts")]
    public required ExtensionContents1 ExtensionContents { get; init; }
}
