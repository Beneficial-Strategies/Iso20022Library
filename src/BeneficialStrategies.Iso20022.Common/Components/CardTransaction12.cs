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
[IsoId("_xhplsXvFEeSKFIcWw3l4Yw")]
[DisplayName("Card Transaction")]
public record CardTransaction12
{
    /// <summary>
    /// Type of network management service (correspond to the ISO 8583 field 24).
    /// </summary>
    [IsoId("_xzrw4XvFEeSKFIcWw3l4Yw")]
    [DisplayName("Network Management Type")]
    [IsoXmlTag("NtwkMgmtTp")]
    public required CardServiceType2Code NetworkManagementType { get; init; }

    /// <summary>
    /// Date and time of the transaction.
    /// </summary>
    [IsoId("_FRBTMIShEeScnfYByhaIWA")]
    [DisplayName("Initiator Date Time")]
    [IsoXmlTag("InitrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InitiatorDateTime { get; init; }

    /// <summary>
    /// Number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_xzrw43vFEeSKFIcWw3l4Yw")]
    [DisplayName("Number Of Messages")]
    [IsoXmlTag("NbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMessages { get; init; }

    /// <summary>
    /// Maximum number of messages in the store and forward queue.
    /// </summary>
    [IsoId("_xzrw5XvFEeSKFIcWw3l4Yw")]
    [DisplayName("Maximum Number Of Messages")]
    [IsoXmlTag("MaxNbOfMsgs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumberOfMessages { get; init; }

    /// <summary>
    /// Response to the network management request.
    /// </summary>
    [IsoId("_GQXQcHvGEeSKFIcWw3l4Yw")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType2 TransactionResponse { get; init; }
}
