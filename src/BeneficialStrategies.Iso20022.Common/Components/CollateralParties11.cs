// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the chain of collateral parties of counterparty of Party A.
/// </summary>
[IsoId("_SBomESs_EeySlt9bF77XfA")]
[DisplayName("Collateral Parties")]
public record CollateralParties11
{
    /// <summary>
    /// Counterparty of party A.
    /// </summary>
    [IsoId("_SZLjYSs_EeySlt9bF77XfA")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification232 PartyB { get; init; }

    /// <summary>
    /// Party that instructs party B to settle the instruction on its behalf.
    /// </summary>
    [IsoId("_SZLjYys_EeySlt9bF77XfA")]
    [DisplayName("Client Party B")]
    [IsoXmlTag("ClntPtyB")]
    public PartyIdentification232? ClientPartyB { get; init; }

    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    [IsoId("_SZLjZSs_EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent")]
    [IsoXmlTag("TrptyAgt")]
    public PartyIdentification136? TripartyAgent { get; init; }

    /// <summary>
    /// Account where the collateral is held during the lifecycle  of the transaction.
    /// </summary>
    [IsoId("_SZLjZys_EeySlt9bF77XfA")]
    [DisplayName("Collateral Account")]
    [IsoXmlTag("CollAcct")]
    public SecuritiesAccount19? CollateralAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_L4oOMytEEeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }
}
