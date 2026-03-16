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
[IsoId("_27QfUcVcEeuips4fuphvoQ")]
[DisplayName("Transaction Context")]
public record TransactionContext9
{
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_3AMCocVcEeuips4fuphvoQ")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public ISO18245MerchantCategoryCode? MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_7m2H4cpCEeuuJ571wNLKkA")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deffered.
    /// Default: False.
    /// </summary>
    [IsoId("_3AMCo8VcEeuips4fuphvoQ")]
    [DisplayName("Deferred Delivery Indicator")]
    [IsoXmlTag("DfrrdDlvryInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeferredDeliveryIndicator { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_7Lw3ETHMEeyTT91yHXSlSQ")]
    [DisplayName("Partial Shipment Indicator")]
    [IsoXmlTag("PrtlShipmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialShipmentIndicator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_E1k50TKlEeyTT91yHXSlSQ")]
    [DisplayName("Delayed Charges Indicator")]
    [IsoXmlTag("DelydChrgsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DelayedChargesIndicator { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented.
    /// </summary>
    [IsoId("_F3UqsTKlEeyTT91yHXSlSQ")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_APPA0TKlEeyTT91yHXSlSQ")]
    [DisplayName("Reauthorisation Indicator")]
    [IsoXmlTag("ReauthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReauthorisationIndicator { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_CQ6ksTKlEeyTT91yHXSlSQ")]
    [DisplayName("Re Submission Indicator")]
    [IsoXmlTag("ReSubmissnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReSubmissionIndicator { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_3AMCpcVcEeuips4fuphvoQ")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.  It does not indicate an outage in the issuer processing domain (including agents acting on behalf of the issuer).
    /// </summary>
    [IsoId("_CtpsWsV-Eeua2vd9tJAtHg")]
    [DisplayName("Authentication Outage Indicator")]
    [IsoXmlTag("AuthntcnOutgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AuthenticationOutageIndicator { get; init; }

    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_3AMCp8VcEeuips4fuphvoQ")]
    [DisplayName("Card Programme")]
    [IsoXmlTag("CardPrgrmm")]
    public CardProgramme2? CardProgramme { get; init; }

    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_BMrEwMVdEeuips4fuphvoQ")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_3AMCqcVcEeuips4fuphvoQ")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService3? SettlementService { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_3AMCq8VcEeuips4fuphvoQ")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; }

    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    [IsoId("_3AMCrcVcEeuips4fuphvoQ")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CaptureDate { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_EHJ15MV-Eeua2vd9tJAtHg")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateAnticipated { get; init; }

    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    [IsoId("_FjiUUcV-Eeua2vd9tJAtHg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
