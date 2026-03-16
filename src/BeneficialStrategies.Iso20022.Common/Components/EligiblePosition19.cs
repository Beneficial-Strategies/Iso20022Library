// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligible Position19.
/// </summary>
[IsoId("_47UQ5Y-9Ee-COKgew96POA")]
[DisplayName("Eligible Position19")]
public partial record EligiblePosition19
{
    #nullable enable

    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public IsoMax35Text? AccountIdentification { get; init; } 

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification241? AccountOwner { get; init; } 

    /// <summary>
    /// Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; } 

    /// <summary>
    /// Holding Balance.
    /// </summary>
    [DisplayName("Holding Balance")]
    [IsoXmlTag("HldgBal")]
    public HoldingBalance14? HoldingBalance { get; init; } 

    /// <summary>
    /// Rights Holder.
    /// </summary>
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public PartyIdentification270? RightsHolder { get; init; } 

    
    #nullable disable
    
}
