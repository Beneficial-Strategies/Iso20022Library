// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amendment details and reason related to the registered contract.
/// </summary>
[IsoId("__zlVIdL3EeSDLevdaFPXHw")]
[DisplayName("Registered Contract Amendment")]
public record RegisteredContractAmendment1
{
    /// <summary>
    /// Date of the amendment of the registered contract.
    /// </summary>
    [IsoId("_OtXz4NL4EeSDLevdaFPXHw")]
    [DisplayName("Amendment Date")]
    [IsoXmlTag("AmdmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate AmendmentDate { get; init; }

    /// <summary>
    /// Reference of the amendment document.
    /// </summary>
    [IsoId("_jCKiwNL4EeSDLevdaFPXHw")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public required DocumentIdentification28 Document { get; init; }

    /// <summary>
    /// Date from which the amendment is applicable.
    /// </summary>
    [IsoId("_y1JvktOWEeSQ_-lmj1tzfw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Reason for the amendment.
    /// </summary>
    [IsoId("_4nTUYtOWEeSQ_-lmj1tzfw")]
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AmendmentReason { get; init; }

    /// <summary>
    /// Further details on the amendment.
    /// </summary>
    [IsoId("_CikDoNOXEeSQ_-lmj1tzfw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }
}
