// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement option details.
/// </summary>
[IsoId("_rV3zQQCEEeqouY-yI_q3qQ")]
[DisplayName("Option Transaction SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionTransactionSD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionTransactionSD6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionTransactionSD6( System.String reqTransactionIdentification,System.DateTime reqTransactionIdentificationDate,FinancialInstrumentQuantity15Choice_ reqTransactionIdentificationQuantity )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionIdentificationDate = reqTransactionIdentificationDate;
        TransactionIdentificationQuantity = reqTransactionIdentificationQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_rpXXAQCEEeqouY-yI_q3qQ")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC Instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_rphIAQCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_rphIAwCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeqNb")]
    #endif
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSequenceNumber { get; init; } 
    #else
    public System.String? TransactionSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction date and time for reorganisation instructions or the deposit date for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_rphIBQCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdDt")]
    #endif
    [IsoXmlTag("TxIdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TransactionIdentificationDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TransactionIdentificationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TransactionIdentificationDate { get; init; } 
    #else
    public System.DateTime TransactionIdentificationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed quantity for reorganisation instructions or the deposit quantity for reorganisation / custody deposits.
    /// </summary>
    [IsoId("_rphIBwCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdQty")]
    #endif
    [IsoXmlTag("TxIdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ TransactionIdentificationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Oversubscribed quantity of the instruction.
    /// </summary>
    [IsoId("_rphICQCEEeqouY-yI_q3qQ")]
    [DisplayName("Transaction Identification Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxIdOvrsbcptQty")]
    #endif
    [IsoXmlTag("TxIdOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? TransactionIdentificationOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// For prorated events, portion of the instructed units that was accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_rphICwCEEeqouY-yI_q3qQ")]
    [DisplayName("Accepted Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptdQty")]
    #endif
    [IsoXmlTag("AccptdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AcceptedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// For prorated events, the portion of the instructed quantity that was not accepted by the Issuer / Agent.
    /// </summary>
    [IsoId("_rphIDQCEEeqouY-yI_q3qQ")]
    [DisplayName("Unaccepted Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UaccptdQty")]
    #endif
    [IsoXmlTag("UaccptdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? UnacceptedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount based upon the DTC cash rate per instruction.
    /// </summary>
    [IsoId("_rphIDwCEEeqouY-yI_q3qQ")]
    [DisplayName("Entitled Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldAmt")]
    #endif
    [IsoXmlTag("EntitldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? EntitledAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity based upon the DTC security rate per instruction.
    /// </summary>
    [IsoId("_rphIEQCEEeqouY-yI_q3qQ")]
    [DisplayName("Entitled Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldQty")]
    #endif
    [IsoXmlTag("EntitldQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? EntitledQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Entitled units for the oversubscription.
    /// </summary>
    [IsoId("_rphIEwCEEeqouY-yI_q3qQ")]
    [DisplayName("Entitled Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitldOvrsbcptQty")]
    #endif
    [IsoXmlTag("EntitldOvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? EntitledOversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount paid to the issuer / agent for subscription cost.
    /// </summary>
    [IsoId("_rphIFQCEEeqouY-yI_q3qQ")]
    [DisplayName("Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptAmt")]
    #endif
    [IsoXmlTag("SbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? SubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount paid to the issuer / agent for the oversubscription cost.
    /// </summary>
    [IsoId("_rphIFwCEEeqouY-yI_q3qQ")]
    [DisplayName("Oversubscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptAmt")]
    #endif
    [IsoXmlTag("OvrsbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? OversubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Cash disbursement in lieu of a fractional quantity of, for example, equity.
    /// </summary>
    [IsoId("_rphIGQCEEeqouY-yI_q3qQ")]
    [DisplayName("Cash In Lieu Of Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShr")]
    #endif
    [IsoXmlTag("CshInLieuOfShr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? CashInLieuOfShare { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_rphIIQCEEeqouY-yI_q3qQ")]
    [DisplayName("Customer Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRefId")]
    #endif
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReferenceIdentification { get; init; } 
    #else
    public System.String? CustomerReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity entered by the agent on PUT (Mortgage Backed) instructions to be paid. This quantity can be for the full or partial instructed quantity.
    /// </summary>
    [IsoId("_rphIIwCEEeqouY-yI_q3qQ")]
    [DisplayName("Agent Entered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtNtrdQty")]
    #endif
    [IsoXmlTag("AgtNtrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? AgentEnteredQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Client free format instruction narrative information. Will be 80 characters for tender instructions, 150 characters for rights instructions and 20 characters for put instructions.
    /// </summary>
    [IsoId("_rphIJQCEEeqouY-yI_q3qQ")]
    [DisplayName("Instruction Comments")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCmnts")]
    #endif
    [IsoXmlTag("InstrCmnts")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? InstructionComments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionComments { get; init; } 
    #else
    public System.String? InstructionComments { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money debited or credited to adjust for the difference between the estimated and the final subscription rate for Rights Exercise events.
    /// </summary>
    [IsoId("_nkt10gCEEeqouY-yI_q3qQ")]
    [DisplayName("Adjusted Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdSbcptAmt")]
    #endif
    [IsoXmlTag("AdjstdSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? AdjustedSubscriptionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money refunded from the original subscription cost for a Rights Exercise event.  This occurs when the event is prorated and the subscription cost relating to the unaffected (unaccepted) balance is returned to the holder.
    /// </summary>
    [IsoId("_nkt10wCEEeqouY-yI_q3qQ")]
    [DisplayName("Refunded Subscription Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfnddSbcptAmt")]
    #endif
    [IsoXmlTag("RfnddSbcptAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount? RefundedSubscriptionAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
