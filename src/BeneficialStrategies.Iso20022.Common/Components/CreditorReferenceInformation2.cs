// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditorReferenceInformation2"/>
[IsoId("_T3_jR9p-Ed-ak6NoX_4Aeg_252475969")]
[DisplayName("Creditor Reference Information")]
public partial record CreditorReferenceInformation2
{
    /// <inheritdoc cref="ICreditorReferenceInformation2.Type"/>
    [IsoId("_T3_jSNp-Ed-ak6NoX_4Aeg_252476093")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CreditorReferenceType2? Type { get; init; }

    /// <inheritdoc cref="ICreditorReferenceInformation2.Reference"/>
    [IsoId("_T3_jSdp-Ed-ak6NoX_4Aeg_252476000")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }
}
