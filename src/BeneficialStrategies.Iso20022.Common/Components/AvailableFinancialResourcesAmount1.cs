// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Construct used by a central counterparty to define the size of the aggregate quantum of resources available from a clearing member.
/// </summary>
[IsoId("_cu3rILV3EeeKi_hRJkOpmQ")]
[DisplayName("Available Financial Resources Amount")]
public partial record AvailableFinancialResourcesAmount1
{
    #nullable enable
    
    /// <summary>
    /// Total value of the initial margin (IM) requirement for all members at the last business day of the month.
    /// </summary>
    [IsoId("_HETOAK_tEeaE9YROwd69hA")]
    [DisplayName("Total Initial Margin")]
    [IsoXmlTag("TtlInitlMrgn")]
    public required ActiveCurrencyAndAmount TotalInitialMargin { get; init; } 
    
    /// <summary>
    /// Total value of the clearing member pre-funded default fund, excluding pre-funded contributions to the default fund from the CCP.
    /// </summary>
    [IsoId("_x3XgwK_tEeaE9YROwd69hA")]
    [DisplayName("Total Prefunded Default Fund")]
    [IsoXmlTag("TtlPrfnddDfltFnd")]
    public required ActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; init; } 
    
    /// <summary>
    /// Value of the CCP’s own contribution to the default waterfall junior to the pre-funded default fund contributions of the non-defaulting clearing members.
    /// </summary>
    [IsoId("_WGvdAK_uEeaE9YROwd69hA")]
    [DisplayName("CCP Skin In The Game")]
    [IsoXmlTag("CCPSkinInTheGame")]
    public ValueList<ReportingAssetBreakdown1> CCPSkinInTheGame { get; init; } = new ValueList<ReportingAssetBreakdown1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _WGvdAK_uEeaE9YROwd69hA
    
    /// <summary>
    /// Total value of other contributions to the pre-funded default fund, not received from clearing members, including any contribution from the CCP that is pari-passu with the default fund contributions of the non-defaulting clearing members.
    /// </summary>
    [IsoId("_bGc4QK_uEeaE9YROwd69hA")]
    [DisplayName("Other Default Fund Contribution")]
    [IsoXmlTag("OthrDfltFndCntrbtn")]
    public required ActiveCurrencyAndAmount OtherDefaultFundContribution { get; init; } 
    
    /// <summary>
    /// Total value of all legally‐bound commitments for members to provide additional resources to available to mutualise losses on exhaustion of the default fund.
    /// </summary>
    [IsoId("_s02MoK_uEeaE9YROwd69hA")]
    [DisplayName("Unfunded Member Commitment")]
    [IsoXmlTag("UfnddMmbCmmtmnt")]
    public required ActiveCurrencyAndAmount UnfundedMemberCommitment { get; init; } 
    
    /// <summary>
    /// Total value of any third‐party commitments to provide additional resources to absorb losses, for example, from insurers.
    /// </summary>
    [IsoId("_yvLdEK_uEeaE9YROwd69hA")]
    [DisplayName("Unfunded Third Party Commitment")]
    [IsoXmlTag("UfnddThrdPtyCmmtmnt")]
    public required ActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; init; } 
    
    
    #nullable disable
    
}
