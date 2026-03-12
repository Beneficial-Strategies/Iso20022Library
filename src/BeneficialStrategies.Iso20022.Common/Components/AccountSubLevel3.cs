// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 3).
/// </summary>
[IsoId("_WpqXp4j2EeONZKAAW4pOaQ")]
[DisplayName("Account Sub Level")]
public partial record AccountSubLevel3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_WpqXrYj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_WpqXqYj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the sub-level account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_WpqXqIj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; } 
    
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_r7WGETyvEeSBD_ZW60GwCQ")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account, for a certain date.
    /// </summary>
    [IsoId("_WpqXqoj2EeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateHoldingBalance1? BalanceForAccount { get; init; } 
    
    /// <summary>
    /// Holdings of level 4.
    /// </summary>
    [IsoId("_WpqXrIj2EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl4")]
    public AccountSubLevel4? AccountSubLevel4 { get; init; } 
    
    /// <summary>
    /// Difference in holdings betweensub-account at level 3 and the sub-accounts of level 4.
    /// </summary>
    [IsoId("_WpqXq4j2EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level 4 Difference")]
    [IsoXmlTag("AcctSubLvl4Diff")]
    public AggregateHoldingBalance2? AccountSubLevel4Difference { get; init; } 
    
    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    [IsoId("_JmgCMb3OEeO2FLWuu_JIqg")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public Intermediary29? Agent { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_J-7D0W5HEeSFHPWGV34yZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
