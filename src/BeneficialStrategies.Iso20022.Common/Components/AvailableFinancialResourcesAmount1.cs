// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Construct used by a central counterparty to define the size of the aggregate quantum of resources available from a clearing member.
/// </summary>
[IsoId("_cu3rILV3EeeKi_hRJkOpmQ")]
[DisplayName("Available Financial Resources Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AvailableFinancialResourcesAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AvailableFinancialResourcesAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AvailableFinancialResourcesAmount1( ActiveCurrencyAndAmount reqTotalInitialMargin,ActiveCurrencyAndAmount reqTotalPrefundedDefaultFund,ActiveCurrencyAndAmount reqOtherDefaultFundContribution,ActiveCurrencyAndAmount reqUnfundedMemberCommitment,ActiveCurrencyAndAmount reqUnfundedThirdPartyCommitment )
    {
        TotalInitialMargin = reqTotalInitialMargin;
        TotalPrefundedDefaultFund = reqTotalPrefundedDefaultFund;
        OtherDefaultFundContribution = reqOtherDefaultFundContribution;
        UnfundedMemberCommitment = reqUnfundedMemberCommitment;
        UnfundedThirdPartyCommitment = reqUnfundedThirdPartyCommitment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total value of the initial margin (IM) requirement for all members at the last business day of the month.
    /// </summary>
    [IsoId("_HETOAK_tEeaE9YROwd69hA")]
    [DisplayName("Total Initial Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlInitlMrgn")]
    #endif
    [IsoXmlTag("TtlInitlMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalInitialMargin { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalInitialMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalInitialMargin { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalInitialMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of the clearing member pre-funded default fund, excluding pre-funded contributions to the default fund from the CCP.
    /// </summary>
    [IsoId("_x3XgwK_tEeaE9YROwd69hA")]
    [DisplayName("Total Prefunded Default Fund")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlPrfnddDfltFnd")]
    #endif
    [IsoXmlTag("TtlPrfnddDfltFnd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; init; } 
    #else
    public ActiveCurrencyAndAmount TotalPrefundedDefaultFund { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the CCP’s own contribution to the default waterfall junior to the pre-funded default fund contributions of the non-defaulting clearing members.
    /// </summary>
    [IsoId("_WGvdAK_uEeaE9YROwd69hA")]
    [DisplayName("CCP Skin In The Game")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCPSkinInTheGame")]
    #endif
    [IsoXmlTag("CCPSkinInTheGame")]
    public ValueList<ReportingAssetBreakdown1> CCPSkinInTheGame { get; init; } = new ValueList<ReportingAssetBreakdown1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _WGvdAK_uEeaE9YROwd69hA
    
    /// <summary>
    /// Total value of other contributions to the pre-funded default fund, not received from clearing members, including any contribution from the CCP that is pari-passu with the default fund contributions of the non-defaulting clearing members.
    /// </summary>
    [IsoId("_bGc4QK_uEeaE9YROwd69hA")]
    [DisplayName("Other Default Fund Contribution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDfltFndCntrbtn")]
    #endif
    [IsoXmlTag("OthrDfltFndCntrbtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount OtherDefaultFundContribution { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount OtherDefaultFundContribution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount OtherDefaultFundContribution { get; init; } 
    #else
    public ActiveCurrencyAndAmount OtherDefaultFundContribution { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of all legally‐bound commitments for members to provide additional resources to available to mutualise losses on exhaustion of the default fund.
    /// </summary>
    [IsoId("_s02MoK_uEeaE9YROwd69hA")]
    [DisplayName("Unfunded Member Commitment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfnddMmbCmmtmnt")]
    #endif
    [IsoXmlTag("UfnddMmbCmmtmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount UnfundedMemberCommitment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount UnfundedMemberCommitment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount UnfundedMemberCommitment { get; init; } 
    #else
    public ActiveCurrencyAndAmount UnfundedMemberCommitment { get; set; } 
    #endif
    
    /// <summary>
    /// Total value of any third‐party commitments to provide additional resources to absorb losses, for example, from insurers.
    /// </summary>
    [IsoId("_yvLdEK_uEeaE9YROwd69hA")]
    [DisplayName("Unfunded Third Party Commitment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UfnddThrdPtyCmmtmnt")]
    #endif
    [IsoXmlTag("UfnddThrdPtyCmmtmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; init; } 
    #else
    public ActiveCurrencyAndAmount UnfundedThirdPartyCommitment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
