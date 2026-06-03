// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of a terminal management system protocol.
/// </summary>
[IsoId("_3A1QgbZ-EfCUZfsQO4rYeA")]
[DisplayName("TMS Protocol Parameters8")]
public record TMSProtocolParameters8
{
    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-atp")]
    [DisplayName("Action Type")]
    [IsoXmlTag("ActnTp")]
    public required TerminalManagementAction3Code ActionType { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-tmid")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TrmnlMgrId")]
    public required GenericIdentification176 TerminalManagerIdentification { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-pver")]
    [DisplayName("Protocol Version")]
    [IsoXmlTag("PrtclVrsn")]
    public IsoMax8Text? ProtocolVersion { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-msvc")]
    [DisplayName("Maintenance Service")]
    [IsoXmlTag("MntncSvc")]
    [MinLength(1)]
    public SimpleValueList<DataSetCategory10Code> MaintenanceService { get; init; } = [];

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-vers")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public required IsoMax256Text Version { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-apid")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    public SimpleValueList<IsoMax35Text> ApplicationIdentification { get; init; } = [];

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-hstid")]
    [DisplayName("Host Identification")]
    [IsoXmlTag("HstId")]
    public required IsoMax35Text HostIdentification { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-poiid")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public IsoMax35Text? POIIdentification { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-inid")]
    [DisplayName("Initiating Party Identification")]
    [IsoXmlTag("InitgPtyId")]
    public IsoMax35Text? InitiatingPartyIdentification { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-rcid")]
    [DisplayName("Recipient Party Identification")]
    [IsoXmlTag("RcptPtyId")]
    public IsoMax35Text? RecipientPartyIdentification { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-fltx")]
    [DisplayName("File Transfer")]
    [IsoXmlTag("FileTrf")]
    public IsoTrueFalseIndicator? FileTransfer { get; init; }

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-msgi")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    [IsoId("_3A1QgbZ-EfCUZfsQO4rYeA-exts")]
    [DisplayName("Externally Type Supported")]
    [IsoXmlTag("ExtnllyTpSpprtd")]
    public SimpleValueList<IsoMax1025Text> ExternallyTypeSupported { get; init; } = [];
}
