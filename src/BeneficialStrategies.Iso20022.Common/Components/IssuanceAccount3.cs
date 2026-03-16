// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Issuance Account3.
/// </summary>
[IsoId("_FBrNIeFTEe6zNorB_Q2tDg")]
[DisplayName("Issuance Account3")]
public partial record IssuanceAccount3
{
    #nullable enable

    /// <summary>
    /// Issuance Account.
    /// </summary>
    [DisplayName("Issuance Account")]
    [IsoXmlTag("IssncAcct")]
    public SecuritiesAccount19? IssuanceAccount { get; init; } 

    /// <summary>
    /// Issuance Block Chain Address Or Wallet.
    /// </summary>
    [DisplayName("Issuance Block Chain Address Or Wallet")]
    [IsoXmlTag("IssncBlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? IssuanceBlockChainAddressOrWallet { get; init; } 

    /// <summary>
    /// Primary Account Indicator.
    /// </summary>
    [DisplayName("Primary Account Indicator")]
    [IsoXmlTag("PmryAcctInd")]
    public required IsoYesNoIndicator PrimaryAccountIndicator { get; init; } 

    
    #nullable disable
    
}
