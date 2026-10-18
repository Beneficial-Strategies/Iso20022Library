// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IReferredMandateDocument1"/>
[IsoId("_p5hTAWVHEeacpJ-gG9kyUQ")]
[DisplayName("Referred Mandate Document")]
public partial record ReferredMandateDocument1
{
    /// <inheritdoc cref="IReferredMandateDocument1.Type"/>
    [IsoId("_qDMMY2VHEeacpJ-gG9kyUQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType4? Type { get; init; }

    /// <inheritdoc cref="IReferredMandateDocument1.Number"/>
    [IsoId("_qDMMZWVHEeacpJ-gG9kyUQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <inheritdoc cref="IReferredMandateDocument1.CreditorReference"/>
    [IsoId("_Jec5YGVIEeacpJ-gG9kyUQ")]
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorReference { get; init; }

    /// <inheritdoc cref="IReferredMandateDocument1.RelatedDate"/>
    [IsoId("_qDMMZ2VHEeacpJ-gG9kyUQ")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }
}
