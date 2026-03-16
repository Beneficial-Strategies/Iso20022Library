// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of garnishment.
/// </summary>
[IsoId("_LLLooYnnEeOORMXOfBk1Bw")]
[DisplayName("Garnishment Type")]
public record GarnishmentType1
{
    /// <summary>
    /// Provides the type details of the garnishment.
    /// </summary>
    [IsoId("_LWYzE4nnEeOORMXOfBk1Bw")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required GarnishmentType1Choice_ CodeOrProprietary { get; init; }

    /// <summary>
    /// Identification of the issuer of the garnishment type.
    /// </summary>
    [IsoId("_LWYzFYnnEeOORMXOfBk1Bw")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
