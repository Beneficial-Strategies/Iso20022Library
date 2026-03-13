// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of the TMS protocol between a POI and a terminal manager.
/// </summary>
[IsoId("_XdvNQY34EeWRwov1g9WL_A")]
[DisplayName("TMS Protocol Parameters")]
public partial record TMSProtocolParameters2
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_041ZUI34EeWRwov1g9WL_A")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; } 
    
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    [IsoId("_Xp9rYY34EeWRwov1g9WL_A")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    
    /// <summary>
    /// Maintenance services provided by the terminal manager.
    /// </summary>
    [IsoId("_Xp9rY434EeWRwov1g9WL_A")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory10Code> MaintenanceService { get; init; } = [];
    // ID for the above is _Xp9rY434EeWRwov1g9WL_A
    
    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    [IsoId("_Xp9rZY34EeWRwov1g9WL_A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Identification of applications which may be managed by the TM, partially or globally.
    /// </summary>
    [IsoId("_Xp9rZ434EeWRwov1g9WL_A")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the terminal manager host.
    /// </summary>
    [IsoId("_rbv-YI35EeWRwov1g9WL_A")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; } 
    
    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    [IsoId("_Xp9rbY34EeWRwov1g9WL_A")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIIdentification { get; init; } 
    
    /// <summary>
    /// New identification of the initiating party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_Xp9rb434EeWRwov1g9WL_A")]
    [DisplayName("Initiating Party Identification")]
    [IsoXmlTag("InitgPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InitiatingPartyIdentification { get; init; } 
    
    /// <summary>
    /// New identification of the recipient party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_Xp9rcY34EeWRwov1g9WL_A")]
    [DisplayName("Recipient Party Identification")]
    [IsoXmlTag("RcptPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RecipientPartyIdentification { get; init; } 
    
    /// <summary>
    /// Configuration parameters are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_22s-wI35EeWRwov1g9WL_A")]
    [DisplayName("File Transfer")]
    [IsoXmlTag("FileTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FileTransfer { get; init; } 
    
    
    #nullable disable
    
}
