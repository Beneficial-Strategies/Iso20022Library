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
[IsoId("_2yfWL-6KEeqc-LCjwLsUVg")]
[DisplayName("Instructed Corporate Action Option")]
public partial record InstructedCorporateActionOption15
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_3cJXIe6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_3cJXKe6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption30Choice_ OptionType { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_3cJXMe6KEeqc-LCjwLsUVg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat5Choice_ InstructedBalance { get; init; } 
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_3cJXOe6KEeqc-LCjwLsUVg")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    
    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_3cJXQe6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat6? OptionAcceptedInstructedBalance { get; init; } 
    
    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_3cJXQ-6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat6? OptionCancelledInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions. 
    /// </summary>
    [IsoId("_3cJXRe6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat6? OptionPendingInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_3cJXR-6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat6? OptionRejectedInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_3cJXSe6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat6? OptionProtectInstructionBalance { get; init; } 
    
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_3cJXS-6KEeqc-LCjwLsUVg")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines3 EventDeadlines { get; init; } 
    
    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_3cJXTe6KEeqc-LCjwLsUVg")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public OptionInstructionDetails5? OptionInstructionDetails { get; init; } 
    
    
    #nullable disable
    
}
