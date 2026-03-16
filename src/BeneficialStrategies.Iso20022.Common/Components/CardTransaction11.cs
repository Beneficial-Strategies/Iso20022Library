// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Network management transaction.
/// </summary>
[IsoId("_wiFRAXvDEeSKFIcWw3l4Yw")]
[DisplayName("Card Transaction")]
public record CardTransaction11
{
    /// <summary>
    /// Type of network management service (correspond to the ISO 8583 field 24).
    /// </summary>
    [IsoId("_erLrcHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Network Management Type")]
    [IsoXmlTag("NtwkMgmtTp")]
    public required CardServiceType2Code NetworkManagementType { get; init; }

    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_o2N8EHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Number Of Messages")]
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMessages { get; init; }

    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_sZqNoHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Maximum Number Of Messages")]
    [IsoXmlTag("MaxNbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumberOfMessages { get; init; }

    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [IsoId("_yBYEEHvEEeSKFIcWw3l4Yw")]
    [DisplayName("Initiator Date Time")]
    [IsoXmlTag("InitrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InitiatorDateTime { get; init; }

    /// <summary>
    /// Response to the network management request.
    /// </summary>
    [IsoId("_m3xkEIO0EeSWSLYdc10LRg")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public ResponseType2? TransactionResponse { get; init; }
}
