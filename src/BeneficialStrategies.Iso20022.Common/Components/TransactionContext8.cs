// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction
/// </summary>
[IsoId("_2gRB4cVbEeuips4fuphvoQ")]
[DisplayName("Transaction Context")]
public record TransactionContext8
{
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_qWKqTcpCEeuuJ571wNLKkA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_2mGx4cpCEeuuJ571wNLKkA")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Specifies the initiator of the fee collection message.
    /// </summary>
    [IsoId("_61v18CxJEeyg-aG5nXcnfg")]
    [DisplayName("Fee Collection Initiator")]
    [IsoXmlTag("FeeColltnInitr")]
    public FeeCollectionInitiator1Code? FeeCollectionInitiator { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_2k-iw8VbEeuips4fuphvoQ")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_1KSc0THMEeyTT91yHXSlSQ")]
    [DisplayName("Partial Shipment Indicator")]
    [IsoXmlTag("PrtlShipmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialShipmentIndicator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_9f9-MTKkEeyTT91yHXSlSQ")]
    [DisplayName("Delayed Charges Indicator")]
    [IsoXmlTag("DelydChrgsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DelayedChargesIndicator { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented.
    /// </summary>
    [IsoId("_-1bVQTKkEeyTT91yHXSlSQ")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("__yT0QTKkEeyTT91yHXSlSQ")]
    [DisplayName("Reauthorisation Indicator")]
    [IsoXmlTag("ReauthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReauthorisationIndicator { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_B6QYMTKlEeyTT91yHXSlSQ")]
    [DisplayName("Re Submission Indicator")]
    [IsoXmlTag("ReSubmissnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReSubmissionIndicator { get; init; }

    /// <summary>
    /// Card programme or brand related to the transaction.
    /// ISO 8583:87 bit 24
    /// </summary>
    [IsoId("_2k-ixcVbEeuips4fuphvoQ")]
    [DisplayName("Card Programme Applied")]
    [IsoXmlTag("CardPrgrmmApld")]
    public CardProgrammeMode3? CardProgrammeApplied { get; init; }

    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_-xyMIMVbEeuips4fuphvoQ")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_2k-ix8VbEeuips4fuphvoQ")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService4? SettlementService { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_2k-iycVbEeuips4fuphvoQ")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; }

    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    [IsoId("_rLiF0cV9Eeua2vd9tJAtHg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
