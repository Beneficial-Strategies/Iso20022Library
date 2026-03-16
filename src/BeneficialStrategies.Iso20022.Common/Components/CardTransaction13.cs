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
[IsoId("_UCtJgXvHEeSCJdwgzb6SFw")]
[DisplayName("Card Transaction")]
public record CardTransaction13
{
    /// <summary>
    /// Type of key exchange.
    /// </summary>
    [IsoId("_lk9QkHvNEeSCJdwgzb6SFw")]
    [DisplayName("Key Exchange Type")]
    [IsoXmlTag("KeyXchgTp")]
    public required CardServiceType3Code KeyExchangeType { get; init; }

    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [IsoId("_3_FpkHvNEeSCJdwgzb6SFw")]
    [DisplayName("Initiator Date Time")]
    [IsoXmlTag("InitrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime InitiatorDateTime { get; init; }

    /// <summary>
    /// Key that must be created and sent in the response, or that must be verified.
    /// </summary>
    [IsoId("_WvATgHvOEeSCJdwgzb6SFw")]
    [DisplayName("Requested Key")]
    [IsoXmlTag("ReqdKey")]
    public ValueList<KEKIdentifier3> RequestedKey { get; init; } = [];

    /// <summary>
    /// Created key to be stored.
    /// </summary>
    [IsoId("_4_COMHvOEeSCJdwgzb6SFw")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey6> Key { get; init; } = [];

    /// <summary>
    /// Response to the key exchange request.
    /// </summary>
    [IsoId("_saSU8IO1EeSWSLYdc10LRg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public ResponseType2? TransactionResponse { get; init; }
}
