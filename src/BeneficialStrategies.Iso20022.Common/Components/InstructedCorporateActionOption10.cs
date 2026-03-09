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
/// Provides corporate action option details about total instructed balance.
/// </summary>
[IsoId("_cydggbtIEeilsanBGAzy4A")]
[DisplayName("Instructed Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructedCorporateActionOption10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InstructedCorporateActionOption10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InstructedCorporateActionOption10( CorporateActionOption18Choice_ reqOptionType,BalanceFormat5Choice_ reqInstructedBalance,CorporateActionEventDeadlines3 reqEventDeadlines )
    {
        OptionType = reqOptionType;
        InstructedBalance = reqInstructedBalance;
        EventDeadlines = reqEventDeadlines;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_dEwxcbtIEeilsanBGAzy4A")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OptionNumber { get; init; } 
    #else
    public System.String? OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_dEwxebtIEeilsanBGAzy4A")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption18Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption18Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption18Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption18Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_dEwxgbtIEeilsanBGAzy4A")]
    [DisplayName("Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdBal")]
    #endif
    [IsoXmlTag("InstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceFormat5Choice_ InstructedBalance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceFormat5Choice_ InstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceFormat5Choice_ InstructedBalance { get; init; } 
    #else
    public BalanceFormat5Choice_ InstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_dEwxibtIEeilsanBGAzy4A")]
    [DisplayName("Default Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltActn")]
    #endif
    [IsoXmlTag("DfltActn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    #else
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_vdtesLtIEeilsanBGAzy4A")]
    [DisplayName("Option Accepted Instructed Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnAccptdInstdBal")]
    #endif
    [IsoXmlTag("OptnAccptdInstdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? OptionAcceptedInstructedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? OptionAcceptedInstructedBalance { get; init; } 
    #else
    public SignedQuantityFormat6? OptionAcceptedInstructedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_4tFYULtIEeilsanBGAzy4A")]
    [DisplayName("Option Cancelled Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnCancInstrBal")]
    #endif
    [IsoXmlTag("OptnCancInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? OptionCancelledInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? OptionCancelledInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? OptionCancelledInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions. 
    /// </summary>
    [IsoId("_ByCxsLtJEeilsanBGAzy4A")]
    [DisplayName("Option Pending Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPdgInstrBal")]
    #endif
    [IsoXmlTag("OptnPdgInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? OptionPendingInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? OptionPendingInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? OptionPendingInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_LFlZoLtJEeilsanBGAzy4A")]
    [DisplayName("Option Rejected Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnRjctdInstrBal")]
    #endif
    [IsoXmlTag("OptnRjctdInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? OptionRejectedInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? OptionRejectedInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? OptionRejectedInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_UmqHQLtJEeilsanBGAzy4A")]
    [DisplayName("Option Protect Instruction Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPrtctInstrBal")]
    #endif
    [IsoXmlTag("OptnPrtctInstrBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignedQuantityFormat6? OptionProtectInstructionBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat6? OptionProtectInstructionBalance { get; init; } 
    #else
    public SignedQuantityFormat6? OptionProtectInstructionBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_dEwxkbtIEeilsanBGAzy4A")]
    [DisplayName("Event Deadlines")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDdlns")]
    #endif
    [IsoXmlTag("EvtDdlns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    #else
    public CorporateActionEventDeadlines3 EventDeadlines { get; set; } 
    #endif
    
    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_2HZdkLtKEeilsanBGAzy4A")]
    [DisplayName("Option Instruction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnInstrDtls")]
    #endif
    [IsoXmlTag("OptnInstrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionInstructionDetails1? OptionInstructionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionInstructionDetails1? OptionInstructionDetails { get; init; } 
    #else
    public OptionInstructionDetails1? OptionInstructionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
