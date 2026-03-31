// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original transaction.
/// </summary>
[IsoId("_i8u0IR0jEeK5OKMB21JFBg")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction17
{
    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_jIoiIR0jEeK5OKMB21JFBg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_jIoiJR0jEeK5OKMB21JFBg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the initiating party for the recipient party.
    /// </summary>
    [IsoId("_jIoiKR0jEeK5OKMB21JFBg")]
    [DisplayName("Initiator Transaction Identification")]
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the recipient party for the initiating party.
    /// </summary>
    [IsoId("_jIoiLR0jEeK5OKMB21JFBg")]
    [DisplayName("Recipient Transaction Identification")]
    [IsoXmlTag("RcptTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientTransactionIdentification { get; init; }

    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_jIoiMR0jEeK5OKMB21JFBg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required CardPaymentServiceType4Code TransactionType { get; init; }

    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_jIoiNR0jEeK5OKMB21JFBg")]
    [DisplayName("Additional Service")]
    [IsoXmlTag("AddtlSvc")]
    public SimpleValueList<CardPaymentServiceType2Code> AdditionalService { get; init; } = [];

    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_jIoiOR0jEeK5OKMB21JFBg")]
    [DisplayName("Service Attribute")]
    [IsoXmlTag("SvcAttr")]
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; }

    /// <summary>
    /// Result of the original transaction.
    /// </summary>
    [IsoId("_jIoiPR0jEeK5OKMB21JFBg")]
    [DisplayName("Transaction Result")]
    [IsoXmlTag("TxRslt")]
    public CardPaymentTransactionResult1? TransactionResult { get; init; }
}
