// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the documents referred to in the remittance information.
/// </summary>
[IsoId("_p5hTAWVHEeacpJ-gG9kyUQ")]
[DisplayName("Referred Mandate Document")]
public record ReferredMandateDocument1
{
    /// <summary>
    /// Specifies the type of referred document.
    /// </summary>
    [IsoId("_qDMMY2VHEeacpJ-gG9kyUQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ReferredDocumentType4? Type { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the referred document.
    /// </summary>
    [IsoId("_qDMMZWVHEeacpJ-gG9kyUQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Number { get; init; }

    /// <summary>
    /// Unique and unambiguous identification as assigned by the creditor to the referred document shared with the debtor for its own reference.
    /// </summary>
    [IsoId("_Jec5YGVIEeacpJ-gG9kyUQ")]
    [DisplayName("Creditor Reference")]
    [IsoXmlTag("CdtrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditorReference { get; init; }

    /// <summary>
    /// Date associated with the referred document.
    /// </summary>
    [IsoId("_qDMMZ2VHEeacpJ-gG9kyUQ")]
    [DisplayName("Related Date")]
    [IsoXmlTag("RltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RelatedDate { get; init; }
}
