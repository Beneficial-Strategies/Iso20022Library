// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

[IsoId("_XT0h88PAEfCvjKJD91zEUA")]
[DisplayName("Business Payload1")]
public record BusinessPayload1
{
    /// <summary>
    /// Manifest that describes the related items or attachments.
    /// </summary>
    [IsoId("_XT0h9MPAEfCvjKJD91zEUA")]
    [DisplayName("Manifest Data")]
    [IsoXmlTag("MnfstData")]
    public ValueList<ManifestData4> ManifestData { get; init; } = [];

    /// <summary>
    /// Used to include the individual business messages within the file structure.
    /// </summary>
    [IsoId("_XT0h9cPAEfCvjKJD91zEUA")]
    [DisplayName("Business Content")]
    [IsoXmlTag("BizCntt")]
    [MinLength(1)]
    public SimpleValueList<IsoLaxPayload> BusinessContent { get; init; } = [];
}
