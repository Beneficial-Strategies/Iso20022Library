// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a document.
/// </summary>
[IsoId("_XdB_6H1wEeGlwNeVP9egyg")]
[DisplayName("Document")]
public record Document11
{
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_XdB_7n1wEeGlwNeVP9egyg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PresentationDocumentFormat1Choice_? Type { get; init; }

    /// <summary>
    /// Wording for document.
    /// </summary>
    [IsoId("_XdB_8X1wEeGlwNeVP9egyg")]
    [DisplayName("Wording")]
    [IsoXmlTag("Wrdg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? Wording { get; init; }

    /// <summary>
    /// Details related to an electronic presentation.
    /// </summary>
    [IsoId("_XdB_631wEeGlwNeVP9egyg")]
    [DisplayName("Electronic Details")]
    [IsoXmlTag("ElctrncDtls")]
    public ValueList<Presentation3> ElectronicDetails { get; init; } = [];
}
