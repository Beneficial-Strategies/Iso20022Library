// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a securities position and rights holders.
/// </summary>
[IsoId("_SSRLHDUEEe2tRf29bleifQ")]
[DisplayName("Eligible Position")]
public partial record EligiblePosition17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the securities account.
    /// </summary>
    [IsoId("_SSRLJDUEEe2tRf29bleifQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_SSRLIDUEEe2tRf29bleifQ")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_SSRLJzUEEe2tRf29bleifQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification231Choice_? AccountOwner { get; init; } 
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, for example, sub-balance per status.
    /// </summary>
    [IsoId("_SSRLIjUEEe2tRf29bleifQ")]
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    [MinLength(1)]
    [MaxLength(3)]
    public ValueList<HoldingBalance13> HoldingBalance { get; init; } = [];
    
    
    #nullable disable
    
}
