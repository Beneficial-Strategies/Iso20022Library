// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
[IsoId("_wj-jH-aqEemtTOaHuc_63w")]
[DisplayName("Instructed Corporate Action Option")]
public partial record InstructedCorporateActionOption12
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_w0x_MeaqEemtTOaHuc_63w")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_w0x_OeaqEemtTOaHuc_63w")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption30Choice_ OptionType { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_w0x_QeaqEemtTOaHuc_63w")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat5Choice_ InstructedBalance { get; init; } 
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_w0x_SeaqEemtTOaHuc_63w")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    
    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_w0x_UeaqEemtTOaHuc_63w")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat6? OptionAcceptedInstructedBalance { get; init; } 
    
    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_w0x_U-aqEemtTOaHuc_63w")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat6? OptionCancelledInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions. 
    /// </summary>
    [IsoId("_w0x_VeaqEemtTOaHuc_63w")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat6? OptionPendingInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_w0x_V-aqEemtTOaHuc_63w")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat6? OptionRejectedInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_w0x_WeaqEemtTOaHuc_63w")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat6? OptionProtectInstructionBalance { get; init; } 
    
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_w0x_W-aqEemtTOaHuc_63w")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    
    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_w0x_XeaqEemtTOaHuc_63w")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public OptionInstructionDetails3? OptionInstructionDetails { get; init; } 
    
    
    #nullable disable
    
}
