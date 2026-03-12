// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 5).
/// </summary>
[IsoId("_KnXN94j3EeONZKAAW4pOaQ")]
[DisplayName("Account Sub Level")]
public partial record AccountSubLevel5
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_KnXN_Ij3EeONZKAAW4pOaQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_KnXN-4j3EeONZKAAW4pOaQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the sub-level account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_KnXN_Yj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; } 
    
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_xZr-ETyvEeSBD_ZW60GwCQ")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    
    /// <summary>
    /// Report on the net position of a single financial instrument on the sub-level account, for a certain date.
    /// </summary>
    [IsoId("_KnXN-oj3EeONZKAAW4pOaQ")]
    [DisplayName("Balance For Account")]
    [IsoXmlTag("BalForAcct")]
    public AggregateHoldingBalance1? BalanceForAccount { get; init; } 
    
    /// <summary>
    /// Holdings of level 5.
    /// </summary>
    [IsoId("_KnXN-Yj3EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl6")]
    public AccountSubLevel6? AccountSubLevel6 { get; init; } 
    
    /// <summary>
    /// Difference in holdings between the safekeeping account and the sub-accounts of level 6.
    /// </summary>
    [IsoId("_KnXN-Ij3EeONZKAAW4pOaQ")]
    [DisplayName("Account Sub Level 6 Difference")]
    [IsoXmlTag("AcctSubLvl6Diff")]
    public AggregateHoldingBalance2? AccountSubLevel6Difference { get; init; } 
    
    /// <summary>
    /// Identification of a related party acting as an intermediary.
    /// </summary>
    [IsoId("_K4_k0b3OEeO2FLWuu_JIqg")]
    [DisplayName("Agent Code")]
    [IsoXmlTag("AgtCd")]
    public Intermediary29? AgentCode { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ms1bkW5HEeSFHPWGV34yZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
