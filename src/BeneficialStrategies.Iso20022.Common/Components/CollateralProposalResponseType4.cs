// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the response for a collateral proposal.
/// </summary>
[IsoId("_wFtHlStIEeyOa655cLd-DQ")]
[DisplayName("Collateral Proposal Response Type")]
public record CollateralProposalResponseType4
{
    /// <summary>
    /// Unique identifier for a collateral proposal.
    /// </summary>
    [IsoId("_wfCNkStIEeyOa655cLd-DQ")]
    [DisplayName("Collateral Proposal Identification")]
    [IsoXmlTag("CollPrpslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CollateralProposalIdentification { get; init; }

    /// <summary>
    /// Indicates whether the collateral proposal is an initial or a counter proposal.
    /// </summary>
    [IsoId("_wfCNkytIEeyOa655cLd-DQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CollateralProposalResponse1Code Type { get; init; }

    /// <summary>
    /// Provides response details for each of the proposed collateral pieces.
    /// </summary>
    [IsoId("_wfCNlStIEeyOa655cLd-DQ")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required CollateralResponse3 Response { get; init; }
}
