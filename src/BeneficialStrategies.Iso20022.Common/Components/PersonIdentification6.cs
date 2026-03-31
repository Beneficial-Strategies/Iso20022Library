// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_QENImdp-Ed-ak6NoX_4Aeg_1939129475")]
[DisplayName("Person Identification")]
public record PersonIdentification6
{
    /// <summary>
    /// Entity that assigns the identifier.
    /// </summary>
    [IsoId("_QENImtp-Ed-ak6NoX_4Aeg_1939130030")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }

    /// <summary>
    /// Personal identification type.
    /// </summary>
    [IsoId("_QEW5kNp-Ed-ak6NoX_4Aeg_2117937583")]
    [DisplayName("Person Identification Type")]
    [IsoXmlTag("PrsnIdTp")]
    public required PersonIdentificationType1Choice_ PersonIdentificationType { get; init; }
}
