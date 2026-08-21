// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of creditor reference.
/// </summary>
[IsoId("_7xH-hTEsEe6GxLzpkVnWYg")]
[Description(@"Specifies the type of creditor reference.")]
[DisplayName("Creditor Reference Type3")]
public record CreditorReferenceType3
{
    /// <summary>
    /// Coded or proprietary format creditor reference type.
    /// </summary>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required CreditorReferenceType2Choice_ CodeOrProprietary { get; init; }

    /// <summary>
    /// Entity that assigns the credit reference type.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; }
}
