// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDocumentLineType1"/>
[IsoId("_cX4kMablEeKvUvwX_r3tzA")]
[DisplayName("Document Line Type")]
public partial record DocumentLineType1
{
    /// <inheritdoc cref="IDocumentLineType1.CodeOrProprietary"/>
    [IsoId("_ciKhlablEeKvUvwX_r3tzA")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required DocumentLineType1Choice_ CodeOrProprietary { get; init; }

    /// <inheritdoc cref="IDocumentLineType1.Issuer"/>
    [IsoId("_ciKhmablEeKvUvwX_r3tzA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
