// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics that apply to the credit side of the payment transactions included in the direct debit transaction initiation.
/// </summary>
[IsoId("_PzX3QNp-Ed-ak6NoX_4Aeg_-727808881")]
[DisplayName("Payment Instruction Information")]
public partial record PaymentInstructionInformation2
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned by a sending party to unambiguously identify the payment information block within the message.
    /// </summary>
    [IsoId("_PzX3Qdp-Ed-ak6NoX_4Aeg_-727807890")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PaymentInformationIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_PzX3Qtp-Ed-ak6NoX_4Aeg_-727807992")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; } 
    
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_PzX3Q9p-Ed-ak6NoX_4Aeg_-725962274")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation2? PaymentTypeInformation { get; init; } 
    
    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    [IsoId("_PzX3RNp-Ed-ak6NoX_4Aeg_-727808447")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; } 
    
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_PzX3Rdp-Ed-ak6NoX_4Aeg_-695484284")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification8 Creditor { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_PzX3Rtp-Ed-ak6NoX_4Aeg_-695483785")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount7 CreditorAccount { get; init; } 
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_PzX3R9p-Ed-ak6NoX_4Aeg_-695484810")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification3 CreditorAgent { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("_PzX3SNp-Ed-ak6NoX_4Aeg_-695485533")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; } 
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_PzX3Sdp-Ed-ak6NoX_4Aeg_-696408256")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; } 
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_PzhBMNp-Ed-ak6NoX_4Aeg_-698253886")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: charges account should be used when charges have to be booked to an account different from the account identified in debtor&apos;s account.
    /// </summary>
    [IsoId("_PzhBMdp-Ed-ak6NoX_4Aeg_-726884926")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount7? ChargesAccount { get; init; } 
    
    /// <summary>
    /// Agent that services a charges account. ||Usage: charges account agent should only be used when the charges account agent is different from the creditor agent.
    /// </summary>
    [IsoId("_PzhBMtp-Ed-ak6NoX_4Aeg_-726886443")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification3? ChargesAccountAgent { get; init; } 
    
    /// <summary>
    /// Set of elements providing information specific to the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("_PzhBM9p-Ed-ak6NoX_4Aeg_-726886228")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation1> DirectDebitTransactionInformation { get; init; } = new ValueList<DirectDebitTransactionInformation1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _PzhBM9p-Ed-ak6NoX_4Aeg_-726886228
    
    
    #nullable disable
    
}
