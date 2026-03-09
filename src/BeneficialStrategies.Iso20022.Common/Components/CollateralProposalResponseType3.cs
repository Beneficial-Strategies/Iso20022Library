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
/// Provides details on the response for a collateral proposal.
/// </summary>
[IsoId("_ssRNNYpDEeaNTaanBSMWmg")]
[DisplayName("Collateral Proposal Response Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralProposalResponseType3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralProposalResponseType3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralProposalResponseType3( System.String reqCollateralProposalIdentification,CollateralProposalResponse1Code reqType,CollateralResponse2 reqResponse )
    {
        CollateralProposalIdentification = reqCollateralProposalIdentification;
        Type = reqType;
        Response = reqResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a collateral proposal.
    /// </summary>
    [IsoId("_s62bwYpDEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrpslId")]
    #endif
    [IsoXmlTag("CollPrpslId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CollateralProposalIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CollateralProposalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CollateralProposalIdentification { get; init; } 
    #else
    public System.String CollateralProposalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the collateral proposal is an initial or a counter proposal.
    /// </summary>
    [IsoId("_s62bw4pDEeaNTaanBSMWmg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposalResponse1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralProposalResponse1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposalResponse1Code Type { get; init; } 
    #else
    public CollateralProposalResponse1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Provides response details for each of the proposed collateral pieces.
    /// </summary>
    [IsoId("_s62bxYpDEeaNTaanBSMWmg")]
    [DisplayName("Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rspn")]
    #endif
    [IsoXmlTag("Rspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralResponse2 Response { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralResponse2 Response { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralResponse2 Response { get; init; } 
    #else
    public CollateralResponse2 Response { get; set; } 
    #endif
    
    
    #nullable disable
    
}
