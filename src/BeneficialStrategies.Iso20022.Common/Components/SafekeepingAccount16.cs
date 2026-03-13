// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and information about a securities account and balance.
/// </summary>
[IsoId("_yKdFpTT5Ee2j2eQlcOSMKg")]
[DisplayName("Safekeeping Account")]
public partial record SafekeepingAccount16
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the securities account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ygDiNzT5Ee2j2eQlcOSMKg")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_GNAN8TT6Ee2j2eQlcOSMKg")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ygDiOTT5Ee2j2eQlcOSMKg")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of a subaccount within the safekeeping account.
    /// </summary>
    [IsoId("_ygDiOzT5Ee2j2eQlcOSMKg")]
    [DisplayName("Sub Account Identification")]
    [IsoXmlTag("SubAcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SubAccountIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_ygDiPTT5Ee2j2eQlcOSMKg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    [MinLength(1)]
    [MaxLength(15)]
    public ValueList<HoldingBalance12> InstructedBalance { get; init; } = [];
    
    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_ygDiPzT5Ee2j2eQlcOSMKg")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    [MinLength(0)]
    [MaxLength(250)]
    public ValueList<PartyIdentification246Choice_> RightsHolder { get; init; } = [];
    
    
    #nullable disable
    
}
