// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a cash entry is made.
/// </summary>
[IsoId("_vO6vwdASEeuSBa1PsnseFg")]
[DisplayName("Cash Account")]
public partial record CashAccount206
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_vkhMU9ASEeuSBa1PsnseFg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentificationAndName7 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_vkhMVdASEeuSBa1PsnseFg")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? Servicer { get; init; } 
    
    /// <summary>
    /// Additional means of identification of the account, as designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_vkhMV9ASEeuSBa1PsnseFg")]
    [DisplayName("Account Type Description")]
    [IsoXmlTag("AcctTpDesc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountTypeDescription { get; init; } 
    
    
    #nullable disable
    
}
