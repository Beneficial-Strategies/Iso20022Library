// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on the payment.
/// </summary>
[IsoId("_RKiehdp-Ed-ak6NoX_4Aeg_-1663577418")]
[DisplayName("Payment Return Criteria")]
public partial record PaymentReturnCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction reference is requested.
    /// </summary>
    [IsoId("_RKiehtp-Ed-ak6NoX_4Aeg_-1662656188")]
    [DisplayName("Transaction Reference Indicator")]
    [IsoXmlTag("TxRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TransactionReferenceIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer value date is requested.
    /// </summary>
    [IsoId("_RKieh9p-Ed-ak6NoX_4Aeg_-1662656651")]
    [DisplayName("Transfer Value Date Indicator")]
    [IsoXmlTag("TrfValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TransferValueDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction is requested.
    /// </summary>
    [IsoId("_RKieiNp-Ed-ak6NoX_4Aeg_-1662657196")]
    [DisplayName("Instruction Indicator")]
    [IsoXmlTag("InstrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructionIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction status is requested.
    /// </summary>
    [IsoId("_RKsPgNp-Ed-ak6NoX_4Aeg_-1662657076")]
    [DisplayName("Instruction Status Return Criteria")]
    [IsoXmlTag("InstrStsRtrCrit")]
    public InstructionStatusReturnCriteria? InstructionStatusReturnCriteria { get; init; } 
    
    /// <summary>
    /// Indicates whether the instructed amount is requested.
    /// </summary>
    [IsoId("_RKsPgdp-Ed-ak6NoX_4Aeg_-1662657136")]
    [DisplayName("Instructed Amount Indicator")]
    [IsoXmlTag("InstdAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructedAmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Payment Instruction Reference is requested.
    /// </summary>
    [IsoId("_RKsPgtp-Ed-ak6NoX_4Aeg_351278396")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the interbank settlement amount is requested.
    /// </summary>
    [IsoId("_RKsPg9p-Ed-ak6NoX_4Aeg_-1662656807")]
    [DisplayName("Interbank Settlement Amount Indicator")]
    [IsoXmlTag("IntrBkSttlmAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InterbankSettlementAmountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment priority is requested.
    /// </summary>
    [IsoId("_RKsPhNp-Ed-ak6NoX_4Aeg_-1662657291")]
    [DisplayName("Priority Indicator")]
    [IsoXmlTag("PrtyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PriorityIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the processing validity time is requested.
    /// </summary>
    [IsoId("_RKsPhdp-Ed-ak6NoX_4Aeg_-1662657231")]
    [DisplayName("Processing Validity Time Indicator")]
    [IsoXmlTag("PrcgVldtyTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ProcessingValidityTimeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the transfer reason is requested.
    /// </summary>
    [IsoId("_RKsPhtp-Ed-ak6NoX_4Aeg_-1662656360")]
    [DisplayName("Purpose Indicator")]
    [IsoXmlTag("PurpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PurposeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the instruction copy is requested.
    /// </summary>
    [IsoId("_RKsPh9p-Ed-ak6NoX_4Aeg_-1662656248")]
    [DisplayName("Instruction Copy Indicator")]
    [IsoXmlTag("InstrCpyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructionCopyIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment message type is requested.
    /// </summary>
    [IsoId("_RKsPiNp-Ed-ak6NoX_4Aeg_-1662656300")]
    [DisplayName("Payment Message Type Indicator")]
    [IsoXmlTag("PmtMsgTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentMessageTypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the payment type is requested.
    /// </summary>
    [IsoId("_RK1ZcNp-Ed-ak6NoX_4Aeg_-1663577399")]
    [DisplayName("Payment Type Indicator")]
    [IsoXmlTag("PmtTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentTypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Payment Instruction Reference is requested.
    /// </summary>
    [IsoId("_RK1Zcdp-Ed-ak6NoX_4Aeg_-1175959206")]
    [DisplayName("Payment Instruction Reference Indicator")]
    [IsoXmlTag("PmtInstrRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentInstructionReferenceIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Interbank Value Date is requested.
    /// </summary>
    [IsoId("_RK1Zctp-Ed-ak6NoX_4Aeg_313679236")]
    [DisplayName("Interbank Value Date Indicator")]
    [IsoXmlTag("IntrBkValDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InterbankValueDateIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Related Reference is requested.
    /// </summary>
    [IsoId("_RK1Zc9p-Ed-ak6NoX_4Aeg_211167351")]
    [DisplayName("Related Reference Indicator")]
    [IsoXmlTag("RltdRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RelatedReferenceIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Payment Method is requested.
    /// </summary>
    [IsoId("_RK1ZdNp-Ed-ak6NoX_4Aeg_1203028604")]
    [DisplayName("Payment Method Indicator")]
    [IsoXmlTag("PmtMtdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PaymentMethodIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Debtor is requested.
    /// </summary>
    [IsoId("_RK_KcNp-Ed-ak6NoX_4Aeg_-754618295")]
    [DisplayName("Debtor Indicator")]
    [IsoXmlTag("DbtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? DebtorIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the First Agent is requested.
    /// </summary>
    [IsoId("_RK_Kcdp-Ed-ak6NoX_4Aeg_-484951167")]
    [DisplayName("First Agent Indicator")]
    [IsoXmlTag("FrstAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? FirstAgentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the correspondent of the Instructing Agent is requested.
    /// </summary>
    [IsoId("_RK_Kctp-Ed-ak6NoX_4Aeg_-470172535")]
    [DisplayName("Instructing Agent Correspondent Indicator")]
    [IsoXmlTag("InstgAgtCrspdtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructingAgentCorrespondentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the correspondent of the Instructed Agent is requested.
    /// </summary>
    [IsoId("_RK_Kc9p-Ed-ak6NoX_4Aeg_-444314494")]
    [DisplayName("Instructed Agent Correspondent Indicator")]
    [IsoXmlTag("InstdAgtCrspdtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? InstructedAgentCorrespondentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Intermediary is requested.
    /// </summary>
    [IsoId("_RK_KdNp-Ed-ak6NoX_4Aeg_-424921485")]
    [DisplayName("Intermediary Indicator")]
    [IsoXmlTag("IntrmyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? IntermediaryIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Final Agent is requested.
    /// </summary>
    [IsoId("_RK_Kddp-Ed-ak6NoX_4Aeg_-411070416")]
    [DisplayName("Final Agent Indicator")]
    [IsoXmlTag("FnlAgtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? FinalAgentIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the Creditor is requested.
    /// </summary>
    [IsoId("_RK_Kdtp-Ed-ak6NoX_4Aeg_-398141338")]
    [DisplayName("Creditor Indicator")]
    [IsoXmlTag("CdtrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CreditorIndicator { get; init; } 
    
    
    #nullable disable
    
}
