// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
[IsoId("_CJG0EadFEeqY6dwgI6s5vg")]
[DisplayName("Charges Record")]
public partial record ChargesRecord4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the charges record for reconciliation purpose.
    /// Usage: this identification shall be used as the end-to-end identification in the resulting message for the payment of the charges, to allow for automated reconciliation. 
    /// </summary>
    [IsoId("_Ym56kSkdEeuBrrgCSpsocg")]
    [DisplayName("Charges Record Identification")]
    [IsoXmlTag("ChrgsRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ChargesRecordIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the underlying transaction(s) to which the charges apply.
    /// </summary>
    [IsoId("_IQFdISkdEeuBrrgCSpsocg")]
    [DisplayName("Underlying Transaction")]
    [IsoXmlTag("UndrlygTx")]
    public ValueList<TransactionReferences7> UnderlyingTransaction { get; init; } = new ValueList<TransactionReferences7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _IQFdISkdEeuBrrgCSpsocg
    
    /// <summary>
    /// Amount of transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_CKTG4adFEeqY6dwgI6s5vg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_CKTG46dFEeqY6dwgI6s5vg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Date and time at which the charges are or will be available.
    /// </summary>
    [IsoId("_ze7A4bt3Eeq_cfXrH83Rcw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    
    /// <summary>
    /// Specifies the debtor agent of the initial transaction, if different from the charges account owner.
    /// </summary>
    [IsoId("_CKTG7adFEeqY6dwgI6s5vg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    
    /// <summary>
    /// Specifies the account of the debtor agent of the initial transaction, when instructing agent is different from the charges account owner.
    /// </summary>
    [IsoId("_T-Zxsbt9Eeq_cfXrH83Rcw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; } 
    
    /// <summary>
    /// Identifies the account that has been debited or credited for the charges, interest or other
    /// adjustment(s).
    /// </summary>
    [IsoId("_8OM74qdEEeqY6dwgI6s5vg")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public required CashAccount40 ChargesAccount { get; init; } 
    
    /// <summary>
    /// Agent that owns the charges account.
    /// </summary>
    [IsoId("_LOmFwbt5Eeq_cfXrH83Rcw")]
    [DisplayName("Charges Account Owner")]
    [IsoXmlTag("ChrgsAcctOwnr")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountOwner { get; init; } 
    
    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_CKTG56dFEeqY6dwgI6s5vg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType3Choice_? Type { get; init; } 
    
    /// <summary>
    /// Further information related to the processing of the payment adjustment instruction that may need to be acted upon by the next agent. 
    /// </summary>
    [IsoId("_3Ry3ISm4EeutWNGMV2XKIQ")]
    [DisplayName("Instruction For Instructed Agent")]
    [IsoXmlTag("InstrForInstdAgt")]
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; init; } 
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_P-LPwbt4Eeq_cfXrH83Rcw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
