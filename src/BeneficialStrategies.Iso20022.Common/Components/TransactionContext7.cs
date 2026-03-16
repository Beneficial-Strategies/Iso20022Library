// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction.
/// </summary>
[IsoId("_4Dwf0YNuEeuHqfO1LgkE9Q")]
[DisplayName("Transaction Context")]
public record TransactionContext7
{
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction in accordance with ISO 18245.
    /// </summary>
    [IsoId("_GB4jbcpDEeuuJ571wNLKkA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    public required ISO18245MerchantCategoryCode MerchantCategoryCode { get; init; }

    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_4Igc84NuEeuHqfO1LgkE9Q")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; }

    /// <summary>
    /// Notifies the express consent of the customer for a given service (used in DCC, funds transfers, money lending, etc.).
    /// True: Explicit customer consent obtained
    /// False: Implicit customer consent obtained
    /// </summary>
    [IsoId("_4Igc9YNuEeuHqfO1LgkE9Q")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; }

    /// <summary>
    /// PIN pad is inoperative.
    /// Default: False - PIN pad is operative or not applicable.
    /// True: PIN pas is inoperative.
    /// </summary>
    [IsoId("_9x-gkbXnEeusf7oR9YukCg")]
    [DisplayName("PIN Pad Inoperative")]
    [IsoXmlTag("PINPadInprtv")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PINPadInoperative { get; init; }

    /// <summary>
    /// Indicate the PIN entry bypass.
    /// </summary>
    [IsoId("_wiS60DHIEeyTT91yHXSlSQ")]
    [DisplayName("PIN Entry Bypass Indicator")]
    [IsoXmlTag("PINNtryBpssInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PINEntryBypassIndicator { get; init; }

    /// <summary>
    /// Indicates a chip data fallback.
    /// </summary>
    [IsoId("_4Igc94NuEeuHqfO1LgkE9Q")]
    [DisplayName("ICC Fallback Indicator")]
    [IsoXmlTag("ICCFllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ICCFallbackIndicator { get; init; }

    /// <summary>
    /// A code that provides the reason of ICC fallback.
    /// </summary>
    [IsoId("_GAoEoDHJEeyTT91yHXSlSQ")]
    [DisplayName("ICC Fallback Reason Code")]
    [IsoXmlTag("ICCFllbckRsnCd")]
    public ICCFallbackReason1Code? ICCFallbackReasonCode { get; init; }

    /// <summary>
    /// Other ICC fallback reason code defined at national or private level.
    /// </summary>
    [IsoId("_U5lAcDHKEeyTT91yHXSlSQ")]
    [DisplayName("Other ICC Fallback Reason Code")]
    [IsoXmlTag("OthrICCFllbckRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherICCFallbackReasonCode { get; init; }

    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    [IsoId("_4Igc-YNuEeuHqfO1LgkE9Q")]
    [DisplayName("Magnetic Stripe Fallback Indicator")]
    [IsoXmlTag("MgntcStrpFllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MagneticStripeFallbackIndicator { get; init; }

    /// <summary>
    /// Indicates a late presentment as defined by each specific implementation.
    /// True: Transaction was presented late
    /// False: Transaction was not presented late
    /// Default: False
    /// </summary>
    [IsoId("_4Igc-4NuEeuHqfO1LgkE9Q")]
    [DisplayName("Late Presentment Indicator")]
    [IsoXmlTag("LatePresntmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LatePresentmentIndicator { get; init; }

    /// <summary>
    /// Identifies final authorisation messages for the purpose of managing open-to buy or available balance.
    /// </summary>
    [IsoId("_4Igc_YNuEeuHqfO1LgkE9Q")]
    [DisplayName("Final Authorisation Indicator")]
    [IsoXmlTag("FnlAuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FinalAuthorisationIndicator { get; init; }

    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deferred.
    /// Default: False.
    /// </summary>
    [IsoId("_4Igc_4NuEeuHqfO1LgkE9Q")]
    [DisplayName("Deferred Delivery Indicator")]
    [IsoXmlTag("DfrrdDlvryInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeferredDeliveryIndicator { get; init; }

    /// <summary>
    /// Indicates the partial shipment.
    /// </summary>
    [IsoId("_kpZdYDHMEeyTT91yHXSlSQ")]
    [DisplayName("Partial Shipment Indicator")]
    [IsoXmlTag("PrtlShipmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PartialShipmentIndicator { get; init; }

    /// <summary>
    /// Indicates a delayed charge.
    /// </summary>
    [IsoId("_RbDCADKkEeyTT91yHXSlSQ")]
    [DisplayName("Delayed Charges Indicator")]
    [IsoXmlTag("DelydChrgsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DelayedChargesIndicator { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented.
    /// </summary>
    [IsoId("_aEHwoTKkEeyTT91yHXSlSQ")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; }

    /// <summary>
    /// Indicates a reauthorisation.
    /// </summary>
    [IsoId("_lvbhMDKkEeyTT91yHXSlSQ")]
    [DisplayName("Reauthorisation Indicator")]
    [IsoXmlTag("ReauthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReauthorisationIndicator { get; init; }

    /// <summary>
    /// Indicates a resubmission.
    /// </summary>
    [IsoId("_zLT3gDKkEeyTT91yHXSlSQ")]
    [DisplayName("Re Submission Indicator")]
    [IsoXmlTag("ReSubmissnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReSubmissionIndicator { get; init; }

    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_4IgdAYNuEeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; }

    /// <summary>
    /// Indicates that the consumer authentication process is temporarily unavailable in the acceptance, acquirer or agent environment for this request.  It does not indicate an outage in the issuer processing domain (including agents acting on behalf of the issuer).
    /// </summary>
    [IsoId("_zUMEQMVXEeuips4fuphvoQ")]
    [DisplayName("Authentication Outage Indicator")]
    [IsoXmlTag("AuthntcnOutgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AuthenticationOutageIndicator { get; init; }

    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_4IgdA4NuEeuHqfO1LgkE9Q")]
    [DisplayName("Card Programme")]
    [IsoXmlTag("CardPrgrmm")]
    public CardProgramme2? CardProgramme { get; init; }

    /// <summary>
    /// Contains information that identifies or is specific to a transaction jurisdiction.
    /// </summary>
    [IsoId("_oGRdgMVbEeuips4fuphvoQ")]
    [DisplayName("Jurisdiction")]
    [IsoXmlTag("Jursdctn")]
    public Jurisdiction2? Jurisdiction { get; init; }

    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_4IgdBYNuEeuHqfO1LgkE9Q")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService3? SettlementService { get; init; }

    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_4IgdB4NuEeuHqfO1LgkE9Q")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; }

    /// <summary>
    /// Further detailed information on the exchange rates that have been used in or are related to the transaction.
    /// </summary>
    [IsoId("_OieIkINvEeuHqfO1LgkE9Q")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRateInformation2? ExchangeRateInformation { get; init; }

    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    [IsoId("_4IgdCYNuEeuHqfO1LgkE9Q")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CaptureDate { get; init; }

    /// <summary>
    /// The date on which the sale or purchase is expected to occur.
    /// </summary>
    [IsoId("_XMWaYMVYEeuips4fuphvoQ")]
    [DisplayName("Date Anticipated")]
    [IsoXmlTag("DtAntcptd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? DateAnticipated { get; init; }

    /// <summary>
    /// Additional transaction context data.
    /// </summary>
    [IsoId("_dHP2EMVZEeuips4fuphvoQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
