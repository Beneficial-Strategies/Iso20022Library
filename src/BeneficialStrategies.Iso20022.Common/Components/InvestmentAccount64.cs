// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities account and its characteristics.
/// </summary>
[IsoId("_HfN7YU_lEeaB8-OWTiMVrQ")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount64
{
    #nullable enable
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_H3w-Q0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    [IsoId("_H3w-RU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Designation { get; init; } 
    
    /// <summary>
    /// Legal form of the fund, for example, UCITS, SICAV, OEIC, Unit Trust, and FCP.
    /// </summary>
    [IsoId("_H3w-R0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Fund Type")]
    [IsoXmlTag("FndTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FundType { get; init; } 
    
    /// <summary>
    /// Name of the investment fund family.
    /// </summary>
    [IsoId("_H3w-SU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Fund Family Name")]
    [IsoXmlTag("FndFmlyNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? FundFamilyName { get; init; } 
    
    /// <summary>
    /// Detailed information about the investment fund associated to the account.
    /// </summary>
    [IsoId("_H3w-S0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    public FinancialInstrument55? SecurityDetails { get; init; } 
    
    /// <summary>
    /// Owner of the account.
    /// </summary>
    [IsoId("_H3w-TU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public AccountOwner2Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_H3w-T0_lEeaB8-OWTiMVrQ")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary33> Intermediary { get; init; } = new ValueList<Intermediary33>(){};
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_H3w-UU_lEeaB8-OWTiMVrQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification70Choice_? AccountServicer { get; init; } 
    
    
    #nullable disable
    
}
