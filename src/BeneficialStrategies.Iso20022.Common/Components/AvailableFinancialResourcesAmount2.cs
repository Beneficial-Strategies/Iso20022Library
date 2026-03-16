// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Available Financial Resources Amount2.
/// </summary>
[IsoId("_YBEVoU2LEe-TXNruDFfwPA")]
[DisplayName("Available Financial Resources Amount2")]
public partial record AvailableFinancialResourcesAmount2
{
    #nullable enable

    /// <summary>
    /// CCP Skin In The Game.
    /// </summary>
    [DisplayName("CCP Skin In The Game")]
    [IsoXmlTag("CCPSkinInTheGame")]
    public ValueList<ReportingAssetBreakdown2> CCPSkinInTheGame { get; init; } = [];

    /// <summary>
    /// Other Default Fund Contribution.
    /// </summary>
    [DisplayName("Other Default Fund Contribution")]
    [IsoXmlTag("OthrDfltFndCntrbtn")]
    public required ActiveCurrencyAndAmount OtherDefaultFundContribution { get; init; } 

    /// <summary>
    /// Total Initial Margin.
    /// </summary>
    [DisplayName("Total Initial Margin")]
    [IsoXmlTag("TtlInitlMrgn")]
    public required ActiveCurrencyAndAmount TotalInitialMargin { get; init; } 

    /// <summary>
    /// Total Prefunded Default Fund.
    /// </summary>
    [DisplayName("Total Prefunded Default Fund")]
    [IsoXmlTag("TtlPrfnddDfltFnd")]
    public required ActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; init; } 

    /// <summary>
    /// Unfunded Member Commitment.
    /// </summary>
    [DisplayName("Unfunded Member Commitment")]
    [IsoXmlTag("UfnddMmbCmmtmnt")]
    public required ActiveCurrencyAndAmount UnfundedMemberCommitment { get; init; } 

    /// <summary>
    /// Unfunded Third Party Commitment.
    /// </summary>
    [DisplayName("Unfunded Third Party Commitment")]
    [IsoXmlTag("UfnddThrdPtyCmmtmnt")]
    public required ActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; init; } 

    
    #nullable disable
    
}
