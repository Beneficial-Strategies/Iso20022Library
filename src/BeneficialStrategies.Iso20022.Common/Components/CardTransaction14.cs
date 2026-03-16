// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key exchange transaction.
/// </summary>
[IsoId("_lhtygXvREeS2PZh7wUMQog")]
[DisplayName("Card Transaction")]
public record CardTransaction14
{
    /// <summary>
    /// Type of key exchange.
    /// </summary>
    [IsoId("_Y34voISiEeScnfYByhaIWA")]
    [DisplayName("Key Exchange Type")]
    [IsoXmlTag("KeyXchgTp")]
    public required CardServiceType3Code KeyExchangeType { get; init; }

    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [IsoId("_eXsAMISiEeScnfYByhaIWA")]
    [DisplayName("Initiator Date Time")]
    [IsoXmlTag("InitrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime InitiatorDateTime { get; init; }

    /// <summary>
    /// Key that has been verified.
    /// </summary>
    [IsoId("__taDUHvREeS2PZh7wUMQog")]
    [DisplayName("Key Verification")]
    [IsoXmlTag("KeyVrfctn")]
    public KEKIdentifier3? KeyVerification { get; init; }

    /// <summary>
    /// Created key to be stored.
    /// </summary>
    [IsoId("_lurQd3vREeS2PZh7wUMQog")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey6? Key { get; init; }

    /// <summary>
    /// Response to the key exchange request.
    /// </summary>
    [IsoId("_mCKVQIO1EeSWSLYdc10LRg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType2 TransactionResponse { get; init; }
}
