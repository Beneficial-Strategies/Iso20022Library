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
[IsoId("_xO9Vgb-zEeeb2ZBoAlSG1Q")]
[DisplayName("Option Transaction Details SD")]
public partial record OptionTransactionDetailsSD4
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_xebU4b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC Instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_xebU47-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public required IsoMax15Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_xebU5b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_xebU57-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Date")]
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_xebU6b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Quantity")]
    [IsoXmlTag("TxIdQty")]
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    
    /// <summary>
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    [IsoId("_xebU67-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    [IsoXmlTag("TxIdOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_xebU7b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Accepted Quantity")]
    [IsoXmlTag("AccptdQty")]
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    
    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_xebU77-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Unaccepted Quantity")]
    [IsoXmlTag("UaccptdQty")]
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_xebU8b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Entitled Amount")]
    [IsoXmlTag("EntitldAmt")]
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_xebU87-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Entitled Quantity")]
    [IsoXmlTag("EntitldQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    
    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    [IsoId("_xebU9b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Entitled Oversubscription Quantity")]
    [IsoXmlTag("EntitldOvrsbcptQty")]
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    [IsoId("_xebU-b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Subscription Amount")]
    [IsoXmlTag("SbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Amount due to proration of the basic subscription or from protect instruction which was not covered.
    /// </summary>
    [IsoId("_0J0-0L_tEeeb2ZBoAlSG1Q")]
    [DisplayName("Refunded Subscription Amount")]
    [IsoXmlTag("RfnddSbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    [IsoId("_xebU-7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Oversubscription Amount")]
    [IsoXmlTag("OvrsbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Amount to be refunded for oversubscribed shares not accepted by the issuer / agent.
    /// </summary>
    [IsoId("_xebU97-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Refunded Oversubscription Amount")]
    [IsoXmlTag("RfnddOvrsbcptAmt")]
    public RestrictedFINActiveCurrencyAndAmount? RefundedOversubscriptionAmount { get; init; } 
    
    /// <summary>
    /// Adjustment related to the difference between the estimated and final price for the subscription cost.
    /// </summary>
    [IsoId("_xebU_b-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Final Subscription Adjustment Amount")]
    [IsoXmlTag("FnlSbcptAdjstmntAmt")]
    public RestrictedFINActiveCurrencyAndAmount? FinalSubscriptionAdjustmentAmount { get; init; } 
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_xebU_7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Cash In Lieu Of Share")]
    [IsoXmlTag("CshInLieuOfShr")]
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_xebVB7-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    
    /// <summary>
    /// Quantity entered by the agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_xebVCb-zEeeb2ZBoAlSG1Q")]
    [DisplayName("Agent Entered Quantity")]
    [IsoXmlTag("AgtNtrdQty")]
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    
    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    [IsoId("_xXngcL_uEeeb2ZBoAlSG1Q")]
    [DisplayName("Instruction Comments")]
    [IsoXmlTag("InstrCmnts")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? InstructionComments { get; init; } 
    
    
    #nullable disable
    
}
