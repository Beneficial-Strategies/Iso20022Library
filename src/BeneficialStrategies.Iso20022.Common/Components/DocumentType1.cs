// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentType1"/>
[IsoId("_O2EK4TE0Ee62xuUQ2zyZww")]
[DisplayName("Document Type1")]
public partial record DocumentType1
{
    /// <inheritdoc cref="IDocumentType1.CodeOrProprietary"/>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required DocumentType2Choice_ CodeOrProprietary { get; init; }

    /// <inheritdoc cref="IDocumentType1.Issuer"/>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; }
}
