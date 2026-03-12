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
[IsoId("_DkdrpwVSEeqjd8n6wD9JVw")]
[DisplayName("Instructed Corporate Action Option")]
public partial record InstructedCorporateActionOption13
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_DkdrqQVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; } 
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_DkdrsQVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption36Choice_ OptionType { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_DkdruQVSEeqjd8n6wD9JVw")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat7Choice_ InstructedBalance { get; init; } 
    
    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_DkdrwQVSEeqjd8n6wD9JVw")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; } 
    
    /// <summary>
    /// Daily total of accepted instructions received for a given option.
    /// </summary>
    [IsoId("_DkeR1wVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Accepted Instructed Balance")]
    [IsoXmlTag("OptnAccptdInstdBal")]
    public SignedQuantityFormat9? OptionAcceptedInstructedBalance { get; init; } 
    
    /// <summary>
    /// Daily total of cancelled instructions for a given option.
    /// </summary>
    [IsoId("_DkeR2QVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Cancelled Instruction Balance")]
    [IsoXmlTag("OptnCancInstrBal")]
    public SignedQuantityFormat9? OptionCancelledInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of pending instructions in pending status for a given option.  It includes cancel pending instructions. 
    /// </summary>
    [IsoId("_DkeR2wVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Pending Instruction Balance")]
    [IsoXmlTag("OptnPdgInstrBal")]
    public SignedQuantityFormat9? OptionPendingInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of rejected instructions for a given option.
    /// </summary>
    [IsoId("_DkeR3QVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Rejected Instruction Balance")]
    [IsoXmlTag("OptnRjctdInstrBal")]
    public SignedQuantityFormat9? OptionRejectedInstructionBalance { get; init; } 
    
    /// <summary>
    /// Daily total of all protect instructions for a given option.
    /// </summary>
    [IsoId("_DkeR3wVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Protect Instruction Balance")]
    [IsoXmlTag("OptnPrtctInstrBal")]
    public SignedQuantityFormat9? OptionProtectInstructionBalance { get; init; } 
    
    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_DkeR4QVSEeqjd8n6wD9JVw")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines4 EventDeadlines { get; init; } 
    
    /// <summary>
    /// Instructions details received for the given option.
    /// </summary>
    [IsoId("_DkeR4wVSEeqjd8n6wD9JVw")]
    [DisplayName("Option Instruction Details")]
    [IsoXmlTag("OptnInstrDtls")]
    public OptionInstructionDetails4? OptionInstructionDetails { get; init; } 
    
    
    #nullable disable
    
}
