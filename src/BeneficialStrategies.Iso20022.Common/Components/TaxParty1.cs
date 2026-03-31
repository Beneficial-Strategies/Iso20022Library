// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the entity involved in the tax paid or to be paid.
/// </summary>
[IsoId("_PdBMxtp-Ed-ak6NoX_4Aeg_-1937885674")]
[DisplayName("Tax Party")]
public record TaxParty1
{
    /// <summary>
    /// Tax identification number of the creditor.
    /// </summary>
    [IsoId("_PdBMx9p-Ed-ak6NoX_4Aeg_-1937885612")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentification { get; init; }

    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_PdBMyNp-Ed-ak6NoX_4Aeg_-1937885613")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <summary>
    /// Type of tax payer.
    /// </summary>
    [IsoId("_PdKWsNp-Ed-ak6NoX_4Aeg_-1937885634")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; }
}
