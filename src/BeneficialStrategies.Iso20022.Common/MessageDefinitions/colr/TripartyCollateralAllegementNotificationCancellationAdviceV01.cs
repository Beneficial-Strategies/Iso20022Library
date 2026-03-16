// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.024.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// Triparty agent sends a TripartyCollateralAllegementNotificationCancellationAdvice to the collateral giver or the collateral taker to inform of the cancellation of an allegement notification message previously sent by the triparty agent.
///
/// The collateral giver and the collateral taker are participants of the triparty agents. In the frame of ECMS the collateral taker will be a central bank.
///
/// The previously sent message is a TripartyCollateralAllegementNotification
/// </summary>
[Description(
    @"Scope:|Triparty agent sends a TripartyCollateralAllegementNotificationCancellationAdvice to the collateral giver or the collateral taker to inform of the cancellation of an allegement notification message previously sent by the triparty agent. ||The collateral giver and the collateral taker are participants of the triparty agents. In the frame of ECMS the collateral taker will be a central bank.||The previously sent message is a TripartyCollateralAllegementNotification"
)]
[IsoId("_rvMtQSs7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Allegement Notification Cancellation Advice V")]
public record TripartyCollateralAllegementNotificationCancellationAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.024.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollAllgmtNtfctnCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.024.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_rvMtQys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    [IsoXmlTag("TxInstrId")]
    public required TransactionIdentifications44 TransactionInstructionIdentification { get; init; }

    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_rvMtRSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Transaction Type")]
    [IsoXmlTag("CollTxTp")]
    public required CollateralTransactionType1Choice_ CollateralTransactionType { get; init; }

    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_rvMtRys7EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    [IsoXmlTag("XpsrTp")]
    public required ExposureType23Choice_ ExposureType { get; init; }

    /// <summary>
    /// Specifies whether the alleging side is the collateral taker or giver.
    /// </summary>
    [IsoId("_rvMtSSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    [IsoXmlTag("CollSd")]
    public required CollateralRole1Code CollateralSide { get; init; }

    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_rvMtSys7EeySlt9bF77XfA")]
    [DisplayName("Eligibility Set Profile")]
    [IsoXmlTag("ElgbltySetPrfl")]
    public GenericIdentification1? EligibilitySetProfile { get; init; }

    /// <summary>
    /// Identifies the chain of collateral parties. Party A and B will be the opposite  from that provided in the unmatched instruction.
    /// </summary>
    [IsoId("_rvMtTSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties8 CollateralParties { get; init; }

    /// <summary>
    /// Amount of the principal.
    /// </summary>
    [IsoId("_rvMtTys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public AmountAndDirection49? TransactionAmount { get; init; }

    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    [IsoId("_rvMtUSs7EeySlt9bF77XfA")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rvMtUys7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since TripartyCollateralAllegementNotificationCancellationAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralAllegementNotificationCancellationAdviceV01.
