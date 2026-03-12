// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Legal counterpart to trades cleared through a central counterparty.
/// </summary>
[IsoId("_l_0jkJXZEeaEh9L5Y0ZaKQ")]
[DisplayName("Clearing Member")]
public partial record ClearingMember1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the clearing member.
    /// </summary>
    [IsoId("_iY7AcJX8EeaEh9L5Y0ZaKQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification118Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Credit quality for the clearing member.
    /// </summary>
    [IsoId("_2Q8osJXZEeaEh9L5Y0ZaKQ")]
    [DisplayName("Credit Quality")]
    [IsoXmlTag("CdtQlty")]
    public required CreditQuality1Code CreditQuality { get; init; } 
    
    /// <summary>
    /// Identification of the ultimate parent of a clearing member if it is not the parent company itself.
    /// </summary>
    [IsoId("_X4el4KcmEeaGcf8_qtd8Yw")]
    [DisplayName("Ultimate Parent Identification")]
    [IsoXmlTag("UltmtPrntId")]
    public PartyIdentification118Choice_? UltimateParentIdentification { get; init; } 
    
    /// <summary>
    /// Identifies whether the clearing member is registered under the Commodity Exchange Act.
    /// </summary>
    [IsoId("_YuOVMJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Futures Commission Merchant Indicator")]
    [IsoXmlTag("FutrsComssnMrchntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator FuturesCommissionMerchantIndicator { get; init; } 
    
    /// <summary>
    /// Date on which the entity becomes a clearing member contractually subject to the CCP’s Rulebook.
    /// </summary>
    [IsoId("_CMTncJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Membership Valid From")]
    [IsoXmlTag("MmbshVldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate MembershipValidFrom { get; init; } 
    
    /// <summary>
    /// Date on which the clearing member is no longer a member in any clearing services protected by the default waterfall as defined by the CCP’s rules. Typically this will be the day the clearing member’s default fund contribution is repaid or they are no longer contractually subject to rights of assessment.
    /// </summary>
    [IsoId("_F264AJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Membership Valid To")]
    [IsoXmlTag("MmbshVldTo")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MembershipValidTo { get; init; } 
    
    /// <summary>
    /// Identification of another clearing member or institution that acts as sponsor to the clearing member, undertaking certain of its obligations at the central counterparty on its behalf. These obligations typically include, but are not limited to, making default fund contributions and participating in default auctions.
    /// </summary>
    [IsoId("_lc6OUJXaEeaEh9L5Y0ZaKQ")]
    [DisplayName("Sponsoring Clearing Member Identification")]
    [IsoXmlTag("SpnsrgClrMmbId")]
    public PartyIdentification118Choice_? SponsoringClearingMemberIdentification { get; init; } 
    
    /// <summary>
    /// Operational construct of a central counterparty that defines the relationship between collateral, margin and position accounts and upon default of a clearing member defines the segregation of losses on positions and assets held in that account.
    /// </summary>
    [IsoId("__bi88KclEeaGcf8_qtd8Yw")]
    [DisplayName("Clearing Account Owner")]
    [IsoXmlTag("ClrAcctOwnr")]
    public ValueList<ClearingAccount1> ClearingAccountOwner { get; init; } = new ValueList<ClearingAccount1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is __bi88KclEeaGcf8_qtd8Yw
    
    
    #nullable disable
    
}
