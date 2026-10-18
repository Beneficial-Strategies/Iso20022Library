// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditorReferenceInformation1"/>
[IsoId("_T3_jRNp-Ed-ak6NoX_4Aeg_1085128342")]
[DisplayName("Creditor Reference Information")]
public partial record CreditorReferenceInformation1
{
    /// <inheritdoc cref="ICreditorReferenceInformation1.CreditorReferenceType"/>
    [IsoId("_T3_jRdp-Ed-ak6NoX_4Aeg_1086051228")]
    [DisplayName("Creditor Reference Type")]
    [IsoXmlTag("CdtrRefTp")]
    public CreditorReferenceType1? CreditorReferenceType { get; init; }

    /// <inheritdoc cref="ICreditorReferenceInformation1.CreditorReference"/>
    [IsoId("_T3_jRtp-Ed-ak6NoX_4Aeg_1086049788")]
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorReference { get; init; }
}
