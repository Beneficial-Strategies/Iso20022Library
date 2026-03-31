// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties involved in the triparty collateral transaction.
/// </summary>
[IsoId("_hgTI8Ss-EeySlt9bF77XfA")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount203
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_h4ltISs-EeySlt9bF77XfA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification120Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_h4ltIys-EeySlt9bF77XfA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_h4ltJSs-EeySlt9bF77XfA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Account of the party.
    /// </summary>
    [IsoId("_h4ltJys-EeySlt9bF77XfA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_by3sEys-EeySlt9bF77XfA")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Specifies the role of the party in the transaction.
    /// </summary>
    [IsoId("_h4ltKSs-EeySlt9bF77XfA")]
    [DisplayName("Party Capacity")]
    [IsoXmlTag("PtyCpcty")]
    public TradingPartyCapacity5Choice_? PartyCapacity { get; init; }
}
