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
[IsoId("_T4ItMtp-Ed-ak6NoX_4Aeg_604337645")]
[DisplayName("Creditor Reference Type")]
public record CreditorReferenceType2
{
    /// <summary>
    /// Coded or proprietary format creditor reference type.
    /// </summary>
    [IsoId("_T4ItM9p-Ed-ak6NoX_4Aeg_710539957")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required CreditorReferenceType1Choice_ CodeOrProprietary { get; init; }

    /// <summary>
    /// Entity that assigns the credit reference type.
    /// </summary>
    [IsoId("_T4ItNNp-Ed-ak6NoX_4Aeg_604337984")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
