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
[IsoId("_uBZX7Sm6EeutWNGMV2XKIQ")]
[DisplayName("Cheque")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Cheque15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Cheque15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Cheque15( System.String reqChequeNumber,System.DateOnly reqIssueDate,ActiveCurrencyAndAmount reqAmount )
    {
        ChequeNumber = reqChequeNumber;
        IssueDate = reqIssueDate;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction. 
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_uBZX8Sm6EeutWNGMV2XKIQ")]
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
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_uBZX-Sm6EeutWNGMV2XKIQ")]
    [DisplayName("Original Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstrId")]
    #endif
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    [IsoId("_uBZX8im6EeutWNGMV2XKIQ")]
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
    [IsoId("_uBZX9ym6EeutWNGMV2XKIQ")]
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
    /// Date after which a cheque is no longer valid.
    /// Usage:
    /// The validity period of a cheque is calculated from the issue date on the face of the cheque.
    /// The period may be indicated on the face of the cheque itself such as &quot;Valid for 90 days” or may be determined in accordance with domestic banking practice. 
    /// Not all countries will have a validity period. 
    /// </summary>
    [IsoId("_uBZX7im6EeutWNGMV2XKIQ")]
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
    [IsoId("_uBZX8ym6EeutWNGMV2XKIQ")]
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
    [IsoId("_uBZX-Cm6EeutWNGMV2XKIQ")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EffectiveDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the agent servicing the account of the cheque payer.
    /// </summary>
    [IsoId("_uBZX9im6EeutWNGMV2XKIQ")]
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
    [IsoId("_uBZX9Sm6EeutWNGMV2XKIQ")]
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
    [IsoId("_uBZX8Cm6EeutWNGMV2XKIQ")]
    [DisplayName("Payee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pyee")]
    #endif
    [IsoXmlTag("Pyee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Payee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Payee { get; init; } 
    #else
    public PartyIdentification135? Payee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the cash account of the payee.
    /// </summary>
    [IsoId("_uBZX9Cm6EeutWNGMV2XKIQ")]
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
    /// Specifies the reason for stopping the payment of the cheque or a request for reimbursement authorisation.
    /// </summary>
    [IsoId("_w8xj4Sm6EeutWNGMV2XKIQ")]
    [DisplayName("Cheque Cancellation Or Stop Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChqCxlOrStopRsn")]
    #endif
    [IsoXmlTag("ChqCxlOrStopRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChequeCancellationReason1? ChequeCancellationOrStopReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChequeCancellationReason1? ChequeCancellationOrStopReason { get; init; } 
    #else
    public ChequeCancellationReason1? ChequeCancellationOrStopReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
