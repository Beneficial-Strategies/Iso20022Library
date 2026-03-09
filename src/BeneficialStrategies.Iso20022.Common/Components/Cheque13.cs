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
/// Characteristics of a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_2YR7EQF9EeuDW9bNZAE8VA")]
[DisplayName("Cheque")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cheque13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Cheque13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Cheque13( System.String reqChequeNumber,System.DateOnly reqIssueDate,ActiveCurrencyAndAmount reqAmount,PartyIdentification135 reqPayee )
    {
        ChequeNumber = reqChequeNumber;
        IssueDate = reqIssueDate;
        Amount = reqAmount;
        Payee = reqPayee;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction. 
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_2mTI8AF9EeuDW9bNZAE8VA")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionIdentification { get; init; } 
    #else
    public System.String? InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_2Z2oYQF9EeuDW9bNZAE8VA")]
    [DisplayName("Cheque Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqNb")]
    #endif
    [IsoXmlTag("ChqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ChequeNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ChequeNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ChequeNumber { get; init; } 
    #else
    public System.String ChequeNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the cheque has been issued by the payer.
    /// </summary>
    [IsoId("_2Z2oYwF9EeuDW9bNZAE8VA")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssueDate { get; init; } 
    #else
    public System.DateOnly IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date after which a cheque is no longer valid. The validity period of a cheque is calculated from the issue date on the face of the cheque.  The period may be indicated on the face of the cheque itself such as &quot;Valid for 90 days” or may be determined in accordance with domestic banking practice. 
    /// Not all countries will have a validity period. 
    /// </summary>
    [IsoId("_AAEUsAF-EeuDW9bNZAE8VA")]
    [DisplayName("Stale Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StlDt")]
    #endif
    [IsoXmlTag("StlDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StaleDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StaleDate { get; init; } 
    #else
    public System.DateOnly? StaleDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of the cheque to be paid to the payee.
    /// </summary>
    [IsoId("_2Z2oZQF9EeuDW9bNZAE8VA")]
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
    /// Date and time at which the cheque amount becomes available on the payee account.
    /// </summary>
    [IsoId("_2Z2oZwF9EeuDW9bNZAE8VA")]
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
    /// Party that issues a cheque ordering the drawee agent to pay a specific amount, upon demand, to the payee.
    /// </summary>
    [IsoId("_2Z2oaQF9EeuDW9bNZAE8VA")]
    [DisplayName("Payer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyer")]
    #endif
    [IsoXmlTag("Pyer")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Payer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Payer { get; init; } 
    #else
    public PartyIdentification135? Payer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the cash account of the payer.
    /// </summary>
    [IsoId("_2Z2oawF9EeuDW9bNZAE8VA")]
    [DisplayName("Payer Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyerAcct")]
    #endif
    [IsoXmlTag("PyerAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? PayerAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? PayerAccount { get; init; } 
    #else
    public CashAccount40? PayerAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    [IsoId("_2Z2obQF9EeuDW9bNZAE8VA")]
    [DisplayName("Drawer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwrAgt")]
    #endif
    [IsoXmlTag("DrwrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? DrawerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the cash account of the drawer agent.
    /// </summary>
    [IsoId("_2Z2obwF9EeuDW9bNZAE8VA")]
    [DisplayName("Drawer Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwrAgtAcct")]
    #endif
    [IsoXmlTag("DrwrAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? DrawerAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? DrawerAgentAccount { get; init; } 
    #else
    public CashAccount40? DrawerAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Party that receives an amount of money as specified in the cheque.
    /// </summary>
    [IsoId("_2Z2ocQF9EeuDW9bNZAE8VA")]
    [DisplayName("Payee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyee")]
    #endif
    [IsoXmlTag("Pyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification135 Payee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification135 Payee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135 Payee { get; init; } 
    #else
    public PartyIdentification135 Payee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the cash account of the payee.
    /// </summary>
    [IsoId("_-6PAsSkfEeuBrrgCSpsocg")]
    [DisplayName("Payee Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyeeAcct")]
    #endif
    [IsoXmlTag("PyeeAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? PayeeAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? PayeeAccount { get; init; } 
    #else
    public CashAccount40? PayeeAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Further information related to the processing of the cheque instruction that may need to be acted upon by the agent processing the cheque.
    /// </summary>
    [IsoId("_i4gX4Sm6EeutWNGMV2XKIQ")]
    [DisplayName("Instruction For Cheque Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrForChqAgt")]
    #endif
    [IsoXmlTag("InstrForChqAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionForChequeAgent1? InstructionForChequeAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionForChequeAgent1? InstructionForChequeAgent { get; init; } 
    #else
    public InstructionForChequeAgent1? InstructionForChequeAgent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
