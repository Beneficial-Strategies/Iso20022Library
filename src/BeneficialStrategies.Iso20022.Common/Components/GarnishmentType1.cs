// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGarnishmentType1"/>
[IsoId("_LLLooYnnEeOORMXOfBk1Bw")]
[DisplayName("Garnishment Type")]
public partial record GarnishmentType1
{
    /// <inheritdoc cref="IGarnishmentType1.CodeOrProprietary"/>
    [IsoId("_LWYzE4nnEeOORMXOfBk1Bw")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required GarnishmentType1Choice_ CodeOrProprietary { get; init; }

    /// <inheritdoc cref="IGarnishmentType1.Issuer"/>
    [IsoId("_LWYzFYnnEeOORMXOfBk1Bw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
