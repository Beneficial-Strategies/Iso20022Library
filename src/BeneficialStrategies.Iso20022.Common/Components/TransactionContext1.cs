// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction.
/// </summary>
[IsoId("_N2aVEEbJEeeIjf8aP9KbJA")]
[DisplayName("Transaction Context")]
public partial record TransactionContext1
{
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction.
    /// ISO 8583:87 bit 18, ISO 8583:93 bit 18 &amp; 26, ISO 8583:2003 bit 26
    /// ISO 18245
    /// </summary>
    [IsoId("_0UDfsEbJEeeIjf8aP9KbJA")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public required IsoExact4NumericText MerchantCategoryCode { get; init; } 
    
    /// <summary>
    /// Further details about the merchant that is used in with the merchant category code (MCC) for the particular purchase.
    /// </summary>
    [IsoId("_t_9bABqbEeqH1IQNpbVpEw")]
    [DisplayName("Merchant Category Specific Data")]
    [IsoXmlTag("MrchntCtgySpcfcData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MerchantCategorySpecificData { get; init; } 
    
    /// <summary>
    /// Notifies the express consent of the customer for a given service (used in DCC, funds transfers, money lending, etc.).
    /// True: Explicit customer consent obtained
    /// False: Implicit customer consent obtained
    /// </summary>
    [IsoId("_vvfW4BYjEeiXa46FI4OtcQ")]
    [DisplayName("Customer Consent")]
    [IsoXmlTag("CstmrCnsnt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    
    /// <summary>
    /// Indicates a chip data fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    [IsoId("_BUOY8BYkEeiXa46FI4OtcQ")]
    [DisplayName("ICC Fallback Indicator")]
    [IsoXmlTag("ICCFllbckInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ICCFallbackIndicator { get; init; } 
    
    /// <summary>
    /// Indicates a magnetic stripe fallback.
    /// True: Fallback
    /// False: No fallback
    /// Default: False
    /// </summary>
    [IsoId("_8YagYZQqEemrTL7utsGcSA")]
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
    [IsoId("_8sLIYdIjEeirx-13kKhDlQ")]
    [DisplayName("Late Presentment Indicator")]
    [IsoXmlTag("LatePresntmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? LatePresentmentIndicator { get; init; } 
    
    /// <summary>
    /// Identifies final authorisation messages for the purpose of managing open-to buy or available balance. 
    /// </summary>
    [IsoId("_s_a0UP_FEeiAhqX-7sOgTw")]
    [DisplayName("Final Authorisation Indicator")]
    [IsoXmlTag("FnlAuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FinalAuthorisationIndicator { get; init; } 
    
    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deffered.
    /// Default: False.
    /// </summary>
    [IsoId("_CroeoGzeEemD24gVaMSpeA")]
    [DisplayName("Deferred Delivery Indicator")]
    [IsoXmlTag("DfrrdDlvryInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeferredDeliveryIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_pESJoWzgEemD24gVaMSpeA")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_r1W_oEbKEeeIjf8aP9KbJA")]
    [DisplayName("Card Programme")]
    [IsoXmlTag("CardPrgrmm")]
    public CardProgramme1? CardProgramme { get; init; } 
    
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_60-ZkEbKEeeIjf8aP9KbJA")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService1? SettlementService { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_EvvZkEbLEeeIjf8aP9KbJA")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; } 
    
    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    [IsoId("_3fCtoEbMEeeIjf8aP9KbJA")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CaptureDate { get; init; } 
    
    
    #nullable disable
    
}
