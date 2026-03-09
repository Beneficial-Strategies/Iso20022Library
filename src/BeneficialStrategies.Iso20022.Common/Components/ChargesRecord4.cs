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
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
[IsoId("_CJG0EadFEeqY6dwgI6s5vg")]
[DisplayName("Charges Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ChargesRecord4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ChargesRecord4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ChargesRecord4( ActiveCurrencyAndAmount reqAmount,CashAccount40 reqChargesAccount )
    {
        Amount = reqAmount;
        ChargesAccount = reqChargesAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the charges record for reconciliation purpose.
    /// Usage: this identification shall be used as the end-to-end identification in the resulting message for the payment of the charges, to allow for automated reconciliation. 
    /// </summary>
    [IsoId("_Ym56kSkdEeuBrrgCSpsocg")]
    [DisplayName("Charges Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsRcrdId")]
    #endif
    [IsoXmlTag("ChrgsRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ChargesRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChargesRecordIdentification { get; init; } 
    #else
    public System.String? ChargesRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the underlying transaction(s) to which the charges apply.
    /// </summary>
    [IsoId("_IQFdISkdEeuBrrgCSpsocg")]
    [DisplayName("Underlying Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygTx")]
    #endif
    [IsoXmlTag("UndrlygTx")]
    public ValueList<TransactionReferences7> UnderlyingTransaction { get; init; } = new ValueList<TransactionReferences7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _IQFdISkdEeuBrrgCSpsocg
    
    /// <summary>
    /// Amount of transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_CKTG4adFEeqY6dwgI6s5vg")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_CKTG46dFEeqY6dwgI6s5vg")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the charges are or will be available.
    /// </summary>
    [IsoId("_ze7A4bt3Eeq_cfXrH83Rcw")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? ValueDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the debtor agent of the initial transaction, if different from the charges account owner.
    /// </summary>
    [IsoId("_CKTG7adFEeqY6dwgI6s5vg")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the account of the debtor agent of the initial transaction, when instructing agent is different from the charges account owner.
    /// </summary>
    [IsoId("_T-Zxsbt9Eeq_cfXrH83Rcw")]
    [DisplayName("Debtor Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgtAcct")]
    #endif
    [IsoXmlTag("DbtrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? DebtorAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? DebtorAgentAccount { get; init; } 
    #else
    public CashAccount40? DebtorAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the account that has been debited or credited for the charges, interest or other
    /// adjustment(s).
    /// </summary>
    [IsoId("_8OM74qdEEeqY6dwgI6s5vg")]
    [DisplayName("Charges Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcct")]
    #endif
    [IsoXmlTag("ChrgsAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAccount40 ChargesAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAccount40 ChargesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40 ChargesAccount { get; init; } 
    #else
    public CashAccount40 ChargesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent that owns the charges account.
    /// </summary>
    [IsoId("_LOmFwbt5Eeq_cfXrH83Rcw")]
    [DisplayName("Charges Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcctOwnr")]
    #endif
    [IsoXmlTag("ChrgsAcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountOwner { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_CKTG56dFEeqY6dwgI6s5vg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeType3Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType3Choice_? Type { get; init; } 
    #else
    public ChargeType3Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the payment adjustment instruction that may need to be acted upon by the next agent. 
    /// </summary>
    [IsoId("_3Ry3ISm4EeutWNGMV2XKIQ")]
    [DisplayName("Instruction For Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForInstdAgt")]
    #endif
    [IsoXmlTag("InstrForInstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; init; } 
    #else
    public InstructionForInstructedAgent1? InstructionForInstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_P-LPwbt4Eeq_cfXrH83Rcw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
