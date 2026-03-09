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
/// Indicates the type of proposal and if the proposal is for the variation margin and the segregated independent amount, or the segregated independent amount only.
/// </summary>
[IsoId("_rL_T8YpIEeaNTaanBSMWmg")]
[DisplayName("Proposal")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proposal5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Proposal5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Proposal5( ProposalType1Code reqCollateralProposalType,CollateralProposal5Choice_ reqCollateralProposal )
    {
        CollateralProposalType = reqCollateralProposalType;
        CollateralProposal = reqCollateralProposal;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether this is an initial or counter proposal.
    /// </summary>
    [IsoId("_ratscYpIEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrpslTp")]
    #endif
    [IsoXmlTag("CollPrpslTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProposalType1Code CollateralProposalType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProposalType1Code CollateralProposalType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProposalType1Code CollateralProposalType { get; init; } 
    #else
    public ProposalType1Code CollateralProposalType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the proposal for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [IsoId("_ratsc4pIEeaNTaanBSMWmg")]
    [DisplayName("Collateral Proposal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrpsl")]
    #endif
    [IsoXmlTag("CollPrpsl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralProposal5Choice_ CollateralProposal { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralProposal5Choice_ CollateralProposal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralProposal5Choice_ CollateralProposal { get; init; } 
    #else
    public CollateralProposal5Choice_ CollateralProposal { get; set; } 
    #endif
    
    
    #nullable disable
    
}
