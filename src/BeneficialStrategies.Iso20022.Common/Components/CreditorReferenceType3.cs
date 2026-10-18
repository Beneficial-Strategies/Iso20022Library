// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditorReferenceType3"/>
[IsoId("_7xH-hTEsEe6GxLzpkVnWYg")]
[Description(@"Specifies the type of creditor reference.")]
[DisplayName("Creditor Reference Type3")]
public partial record CreditorReferenceType3
{
    /// <inheritdoc cref="ICreditorReferenceType3.CodeOrProprietary"/>
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required CreditorReferenceType2Choice_ CodeOrProprietary { get; init; }

    /// <inheritdoc cref="ICreditorReferenceType3.Issuer"/>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public IsoMax35Text? Issuer { get; init; }
}
