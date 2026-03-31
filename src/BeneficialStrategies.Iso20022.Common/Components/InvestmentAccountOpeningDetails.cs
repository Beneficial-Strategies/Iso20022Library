// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information about the type of opening instruction and identification of the application request.
/// </summary>
[IsoId("_REb2hNp-Ed-ak6NoX_4Aeg_443591120")]
[DisplayName("Investment Account Opening Details")]
public record InvestmentAccountOpeningDetails
{
    /// <summary>
    /// Specifies if the account opening instruction is about a newly created account or a supplementary account.
    /// </summary>
    [IsoId("_REb2hdp-Ed-ak6NoX_4Aeg_-389691273")]
    [DisplayName("Opening Type")]
    [IsoXmlTag("OpngTp")]
    public required AccountOpeningType1Code OpeningType { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of the account opening request at application level.
    /// </summary>
    [IsoId("_REb2htp-Ed-ak6NoX_4Aeg_-389690342")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; }
}
