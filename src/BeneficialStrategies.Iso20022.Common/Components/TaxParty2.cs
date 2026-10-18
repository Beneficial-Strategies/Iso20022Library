// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxParty2"/>
[IsoId("_PdBMwdp-Ed-ak6NoX_4Aeg_920823246")]
[DisplayName("Tax Party")]
public partial record TaxParty2
{
    /// <inheritdoc cref="ITaxParty2.TaxIdentification"/>
    [IsoId("_PdBMwtp-Ed-ak6NoX_4Aeg_920823361")]
    [DisplayName("Tax Identification")]
    [IsoXmlTag("TaxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxIdentification { get; init; }

    /// <inheritdoc cref="ITaxParty2.RegistrationIdentification"/>
    [IsoId("_PdBMw9p-Ed-ak6NoX_4Aeg_920823300")]
    [DisplayName("Registration Identification")]
    [IsoXmlTag("RegnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrationIdentification { get; init; }

    /// <inheritdoc cref="ITaxParty2.TaxType"/>
    [IsoId("_PdBMxNp-Ed-ak6NoX_4Aeg_920823277")]
    [DisplayName("Tax Type")]
    [IsoXmlTag("TaxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TaxType { get; init; }

    /// <inheritdoc cref="ITaxParty2.Authorisation"/>
    [IsoId("_PdBMxdp-Ed-ak6NoX_4Aeg_-137944593")]
    [DisplayName("Authorisation")]
    [IsoXmlTag("Authstn")]
    public TaxAuthorisation1? Authorisation { get; init; }
}
