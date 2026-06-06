// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides all sub-account details.
/// </summary>
[IsoId("045d5f53-2aaa-4c47-b7fc-037f56b3c0f1")]
[DisplayName("Sub Account Identification74")]
public record SubAccountIdentification74
{
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("a623c305-7e84-45c7-a72d-c88e815c43db")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("6e72d02e-b988-4d3b-bf50-0e5e363e67a5")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount25? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("c992d35c-9a4d-4ef3-94bd-b55bef767b36")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet2? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("74af9940-58cf-4bb6-a806-b6711e94fa83")]
    [DisplayName("Activity Indicator")]
    [IsoXmlTag("ActvtyInd")]
    public required IsoYesNoIndicator ActivityIndicator { get; init; }

    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("355c1457-0fb5-4408-aaaf-28b97229eb2e")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public ValueList<FinancialInstrumentDetails49> FinancialInstrumentDetails { get; init; } = [];
}
