// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditorReferenceType1"/>
[IsoId("_T31ySNp-Ed-ak6NoX_4Aeg_96960704")]
[DisplayName("Creditor Reference Type")]
public partial record CreditorReferenceType1
{
    /// <inheritdoc cref="ICreditorReferenceType1.Code"/>
    [IsoId("_T31ySdp-Ed-ak6NoX_4Aeg_96961291")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DocumentType3Code Code { get; init; }

    /// <inheritdoc cref="ICreditorReferenceType1.Proprietary"/>
    [IsoId("_T31yStp-Ed-ak6NoX_4Aeg_96961652")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Proprietary { get; init; }

    /// <inheritdoc cref="ICreditorReferenceType1.Issuer"/>
    [IsoId("_T3_jQNp-Ed-ak6NoX_4Aeg_96961712")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
