// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the card payment transaction
/// </summary>
[IsoId("_XjPhoUP_EeiFlYmBVFSxUw")]
[DisplayName("Transaction Context")]
public partial record TransactionContext4
{
    #nullable enable
    
    /// <summary>
    /// Category code related to the type of services or goods the merchant provides for the transaction.
    /// ISO 8583:87 bit 18, ISO 8583:93 bit 18 &amp; 26, ISO 8583:2003 bit 26
    /// ISO 18245
    /// </summary>
    [IsoId("_XvcKkUP_EeiFlYmBVFSxUw")]
    [DisplayName("Merchant Category Code")]
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Exact4NumericText)]
    public IsoExact4NumericText? MerchantCategoryCode { get; init; } 
    
    /// <summary>
    /// Indicates a deferred delivery as defined by each specific implementation.
    /// True: deferred delivery.
    /// False: Delivery is not identified as deffered.
    /// Default: False.
    /// </summary>
    [IsoId("_jXFoMWzeEemD24gVaMSpeA")]
    [DisplayName("Deferred Delivery Indicator")]
    [IsoXmlTag("DfrrdDlvryInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DeferredDeliveryIndicator { get; init; } 
    
    /// <summary>
    /// Identifies the transaction initiator.
    /// </summary>
    [IsoId("_qGIoMWzgEemD24gVaMSpeA")]
    [DisplayName("Transaction Initiator")]
    [IsoXmlTag("TxInitr")]
    public TransactionInitiator1Code? TransactionInitiator { get; init; } 
    
    /// <summary>
    /// Card programme or brand related to the transaction.
    /// </summary>
    [IsoId("_XvcKl0P_EeiFlYmBVFSxUw")]
    [DisplayName("Card Programme")]
    [IsoXmlTag("CardPrgrmm")]
    public CardProgramme1? CardProgramme { get; init; } 
    
    /// <summary>
    /// Type of settlement service for specific services requiring settlement.
    /// </summary>
    [IsoId("_XvcKmUP_EeiFlYmBVFSxUw")]
    [DisplayName("Settlement Service")]
    [IsoXmlTag("SttlmSvc")]
    public SettlementService1? SettlementService { get; init; } 
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_XvcKm0P_EeiFlYmBVFSxUw")]
    [DisplayName("Reconciliation")]
    [IsoXmlTag("Rcncltn")]
    public Reconciliation3? Reconciliation { get; init; } 
    
    /// <summary>
    /// Date the transaction was completed and captured.
    /// ISO 8583 bit 17
    /// </summary>
    [IsoId("_XvcKnUP_EeiFlYmBVFSxUw")]
    [DisplayName("Capture Date")]
    [IsoXmlTag("CaptrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CaptureDate { get; init; } 
    
    
    #nullable disable
    
}
