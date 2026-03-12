// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement option details.
/// </summary>
[IsoId("_cb3Su5FHEeanIpS4qvJ1tw")]
[DisplayName("Option Transaction Details SD")]
public partial record OptionTransactionDetailsSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_cb3SxJFHEeanIpS4qvJ1tw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Unique number assigned by the Depository. Transaction identification will be either the DTC Instruction Reference Number for reorganisation instructions (VOI) or the DAM Reference Number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_cb3Sw5FHEeanIpS4qvJ1tw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Number which further identifies DTC intsruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_cb3SwJFHEeanIpS4qvJ1tw")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_cb3Sv5FHEeanIpS4qvJ1tw")]
    [DisplayName("Transaction Identification Date")]
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_cb3SvJFHEeanIpS4qvJ1tw")]
    [DisplayName("Transaction Identification Quantity")]
    [IsoXmlTag("TxIdQty")]
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    
    /// <summary>
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    [IsoId("_uhizwJFJEeanIpS4qvJ1tw")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_F1LSUJFKEeanIpS4qvJ1tw")]
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    
    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_TFM98JFKEeanIpS4qvJ1tw")]
    [DisplayName("Unaccepted Quantity")]
    [IsoXmlTag("UaccptdQty")]
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_cb3SxZFHEeanIpS4qvJ1tw")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_cb3SwpFHEeanIpS4qvJ1tw")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    
    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    [IsoId("_CauvQJFLEeanIpS4qvJ1tw")]
    [DisplayName("Entitled Oversubscription Quantity")]
    [IsoXmlTag("EntitldOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Amount to be refunded for oversubscribed shares not accepted by the issuer / agent.
    /// </summary>
    [IsoId("_cuR7kJFLEeanIpS4qvJ1tw")]
    [DisplayName("Refunded Oversubscription Amount")]
    [IsoXmlTag("RfnddOvrsbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RefundedOversubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    [IsoId("_mACa0JFLEeanIpS4qvJ1tw")]
    [DisplayName("Subscription Amount")]
    [IsoXmlTag("SbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    [IsoId("_41RbcJFLEeanIpS4qvJ1tw")]
    [DisplayName("Oversubscription Amount")]
    [IsoXmlTag("OvrsbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Adjustment related to the difference between the estimated and final price for the subscription cost.
    /// </summary>
    [IsoId("_ITh5MJFMEeanIpS4qvJ1tw")]
    [DisplayName("Final Subscription Adjustment Amount")]
    [IsoXmlTag("FnlSbcptAdjstmntAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FinalSubscriptionAdjustmentAmount { get; init; } 
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_V6bzxJFMEeanIpS4qvJ1tw")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_cb3SwZFHEeanIpS4qvJ1tw")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? CustomerReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Quantity entered by the Agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_cb3SvpFHEeanIpS4qvJ1tw")]
    [DisplayName("Agent Entered Quantity")]
    [IsoXmlTag("AgtNtrdQty")]
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    
    
    #nullable disable
    
}
