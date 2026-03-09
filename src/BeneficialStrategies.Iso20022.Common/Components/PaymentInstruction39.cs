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
/// Characteristics that apply to the credit side of the payment transactions included in the direct debit initiation.
/// </summary>
[IsoId("_eCraUdcZEeqRFcf2R4bPBw")]
[DisplayName("Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstruction39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstruction39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstruction39( System.String reqPaymentInformationIdentification,PaymentMethod2Code reqPaymentMethod,System.DateOnly reqRequestedCollectionDate,PartyIdentification135 reqCreditor,CashAccount40 reqCreditorAccount,BranchAndFinancialInstitutionIdentification6 reqCreditorAgent )
    {
        PaymentInformationIdentification = reqPaymentInformationIdentification;
        PaymentMethod = reqPaymentMethod;
        RequestedCollectionDate = reqRequestedCollectionDate;
        Creditor = reqCreditor;
        CreditorAccount = reqCreditorAccount;
        CreditorAgent = reqCreditorAgent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("_eD_o_9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Information Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInfId")]
    #endif
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PaymentInformationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PaymentInformationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PaymentInformationIdentification { get; init; } 
    #else
    public System.String PaymentInformationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_eD_pAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentMethod2Code PaymentMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentMethod2Code PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentMethod2Code PaymentMethod { get; init; } 
    #else
    public PaymentMethod2Code PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    [IsoId("_eD_pA9cZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Advice Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdAdvcTp")]
    #endif
    [IsoXmlTag("ReqdAdvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdviceType1? RequestedAdviceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdviceType1? RequestedAdviceType { get; init; } 
    #else
    public AdviceType1? RequestedAdviceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_eD_pBdcZEeqRFcf2R4bPBw")]
    [DisplayName("Batch Booking")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BtchBookg")]
    #endif
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BatchBooking { get; init; } 
    #else
    public System.String? BatchBooking { get; set; } 
    #endif
    
    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [IsoId("_eD_pB9cZEeqRFcf2R4bPBw")]
    [DisplayName("Number Of Transactions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfTxs")]
    #endif
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NumberOfTransactions { get; init; } 
    #else
    public System.String? NumberOfTransactions { get; set; } 
    #endif
    
    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [IsoId("_eD_pCdcZEeqRFcf2R4bPBw")]
    [DisplayName("Control Sum")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrlSum")]
    #endif
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ControlSum { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ControlSum { get; init; } 
    #else
    public System.UInt64? ControlSum { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_eD_pC9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTpInf")]
    #endif
    [IsoXmlTag("PmtTpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; } 
    #else
    public PaymentTypeInformation29? PaymentTypeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_eD_pDdcZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdColltnDt")]
    #endif
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate RequestedCollectionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly RequestedCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly RequestedCollectionDate { get; init; } 
    #else
    public System.DateOnly RequestedCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_eD_pD9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 Creditor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 Creditor { get; init; } 
    #else
    public PartyIdentification135 Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_eD_pEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount40 CreditorAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount40 CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40 CreditorAccount { get; init; } 
    #else
    public CashAccount40 CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_eD_pE9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_eD_pFdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgtAcct")]
    #endif
    [IsoXmlTag("CdtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? CreditorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? CreditorAgentAccount { get; init; } 
    #else
    public CashAccount40? CreditorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_eD_pF9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification135? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_eD_pGdcZEeqRFcf2R4bPBw")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor&apos;s account.
    /// </summary>
    [IsoId("_eD_pG9cZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcct")]
    #endif
    [IsoXmlTag("ChrgsAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? ChargesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? ChargesAccount { get; init; } 
    #else
    public CashAccount40? ChargesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the creditor agent.
    /// </summary>
    [IsoId("_eD_pHdcZEeqRFcf2R4bPBw")]
    [DisplayName("Charges Account Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcctAgt")]
    #endif
    [IsoXmlTag("ChrgsAcctAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_eD_pH9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrSchmeId")]
    #endif
    [IsoXmlTag("CdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification135? CreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("_eD_pIdcZEeqRFcf2R4bPBw")]
    [DisplayName("Direct Debit Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtTxInf")]
    #endif
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation28> DirectDebitTransactionInformation { get; init; } = new ValueList<DirectDebitTransactionInformation28>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _eD_pIdcZEeqRFcf2R4bPBw
    
    
    #nullable disable
    
}
