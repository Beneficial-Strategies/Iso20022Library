// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of the TMS protocol between a POI and a terminal manager.
/// </summary>
[IsoId("_oSdigVFMEeyApZmLzm74zA")]
[DisplayName("TMS Protocol Parameters")]
public record TMSProtocolParameters6
{
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    [IsoId("_oYyM8VFMEeyApZmLzm74zA")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    [IsoId("_oYyM81FMEeyApZmLzm74zA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    /// <summary>
    /// Protocol version to use when using these parameters.
    /// </summary>
    [IsoId("_oYyM9VFMEeyApZmLzm74zA")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? ProtocolVersion { get; init; }

    /// <summary>
    /// Maintenance services provided by the terminal manager.
    /// </summary>
    [IsoId("_oYyM91FMEeyApZmLzm74zA")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    public SimpleValueList<DataSetCategory10Code> MaintenanceService { get; init; } = [];

    // ID for the above is _oYyM91FMEeyApZmLzm74zA

    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    [IsoId("_oYyM-VFMEeyApZmLzm74zA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; }

    /// <summary>
    /// Identification of applications which may be managed by the TM, partially or globally.
    /// </summary>
    [IsoId("_oYyM-1FMEeyApZmLzm74zA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ApplicationIdentification { get; init; }

    /// <summary>
    /// Identification of the terminal manager host.
    /// </summary>
    [IsoId("_oYyM_VFMEeyApZmLzm74zA")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text HostIdentification { get; init; }

    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    [IsoId("_oYyM_1FMEeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIIdentification { get; init; }

    /// <summary>
    /// New identification of the initiating party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_oYyNAVFMEeyApZmLzm74zA")]
    [DisplayName("Initiating Party Identification")]
    [IsoXmlTag("InitgPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? InitiatingPartyIdentification { get; init; }

    /// <summary>
    /// New identification of the recipient party to set in TMS messages with this terminal manager.
    /// </summary>
    [IsoId("_oYyNA1FMEeyApZmLzm74zA")]
    [DisplayName("Recipient Party Identification")]
    [IsoXmlTag("RcptPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RecipientPartyIdentification { get; init; }

    /// <summary>
    /// Configuration parameters are exchanged per file transfer protocol rather than per message.
    /// </summary>
    [IsoId("_oYyNBVFMEeyApZmLzm74zA")]
    [DisplayName("File Transfer")]
    [IsoXmlTag("FileTrf")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? FileTransfer { get; init; }

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_oYyNB1FMEeyApZmLzm74zA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public MessageItemCondition1? MessageItem { get; init; }

    /// <summary>
    /// List of types that the receiver supports and that the sender could use as type of an ExternallyDefinedData message component.
    /// </summary>
    [IsoId("_ljVCwFFMEeyApZmLzm74zA")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("XtrnlyTpSpprtd")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? ExternallyTypeSupported { get; init; }
}
