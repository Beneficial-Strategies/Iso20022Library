// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 7).
/// </summary>
[IsoId("_Wt8dUVjCEea1XpTdyimpLA")]
[DisplayName("Account Sub Level")]
public partial record AccountSubLevel17
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_XHF9IVjCEea1XpTdyimpLA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_XHF9I1jCEea1XpTdyimpLA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_XHF9JVjCEea1XpTdyimpLA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; } 
    
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_XHF9J1jCEea1XpTdyimpLA")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 7), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_ZyB5YVjCEea1XpTdyimpLA")]
    [DisplayName("Balance Details")]
    [IsoXmlTag("BalDtls")]
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    
    /// <summary>
    /// Holdings of level 8.
    /// </summary>
    [IsoId("_XHF9K1jCEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl8")]
    public AccountSubLevel18? AccountSubLevel8 { get; init; } 
    
    /// <summary>
    /// Difference in holdings between the sub-account at level 7 and the sub-accounts of level 8.
    /// </summary>
    [IsoId("_XHF9LVjCEea1XpTdyimpLA")]
    [DisplayName("Account Sub Level 8 Difference")]
    [IsoXmlTag("AcctSubLvl8Diff")]
    public AggregateHoldingBalance2? AccountSubLevel8Difference { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XHF9MVjCEea1XpTdyimpLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
