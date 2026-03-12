// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account and holding of the next sub-level (Level 1).
/// </summary>
[IsoId("_cc9ycVi-Eea1XpTdyimpLA")]
[DisplayName("Account Sub Level")]
public partial record AccountSubLevel11
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the sub-account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_c10XUVi-Eea1XpTdyimpLA")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that legally owns the sub-account.
    /// </summary>
    [IsoId("_c10XU1i-Eea1XpTdyimpLA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required PartyIdentification100 AccountOwner { get; init; } 
    
    /// <summary>
    /// Party that manages the sub-account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_c10XVVi-Eea1XpTdyimpLA")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public required PartyIdentification100 AccountServicer { get; init; } 
    
    /// <summary>
    /// Individual or entity that is ultimately entitled to the benefit of income and rights in a financial instrument, as opposed to a nominal or legal owner.
    /// </summary>
    [IsoId("_c10XV1i-Eea1XpTdyimpLA")]
    [DisplayName("Beneficial Owner")]
    [IsoXmlTag("BnfclOwnr")]
    public BeneficialOwner2? BeneficialOwner { get; init; } 
    
    /// <summary>
    /// Report on the net position of a financial instrument on the sub-account (sub-account level 1), for a certain date. The agent, for example, a trade intermediary, may also be specified.
    /// </summary>
    [IsoId("_hzmf8Vi-Eea1XpTdyimpLA")]
    [DisplayName("Balance Details")]
    [IsoXmlTag("BalDtls")]
    public AggregateHoldingBalance3? BalanceDetails { get; init; } 
    
    /// <summary>
    /// Holdings of level 2.
    /// </summary>
    [IsoId("_c10XW1i-Eea1XpTdyimpLA")]
    [DisplayName("Account Sub Level")]
    [IsoXmlTag("AcctSubLvl2")]
    public AccountSubLevel12? AccountSubLevel2 { get; init; } 
    
    /// <summary>
    /// Difference in holdings between the sub-account at level 1 and sub-accounts of level 2.
    /// </summary>
    [IsoId("_c10XXVi-Eea1XpTdyimpLA")]
    [DisplayName("Account Sub Level 2 Difference")]
    [IsoXmlTag("AcctSubLvl2Diff")]
    public AggregateHoldingBalance2? AccountSubLevel2Difference { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_c10XYVi-Eea1XpTdyimpLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
