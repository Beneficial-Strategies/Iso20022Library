// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action to perform on a terminal management system.
/// </summary>
[IsoId("_AOesQbYFEfCUZfsQO4rYeA")]
[DisplayName("TMS Action14")]
public record TMSAction14
{
    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction5Code Type { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-rmt")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmtAcs")]
    public NetworkParameters7? RemoteAccess { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-key")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey19> Key { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tmid")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TrmnlMgrId")]
    public GenericIdentification176? TerminalManagerIdentification { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tpro")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcl")]
    public IsoMax35Text? TMSProtocol { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tpvr")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtclVrsn")]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dsid")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification11? DataSetIdentification { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-cmpt")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmptTp")]
    public SimpleValueList<DataSetCategory20Code> ComponentType { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dlsc")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScopeId")]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dlsd")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScopeDfntn")]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dlsp")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnPrf")]
    public IsoMax5000Binary? DelegationProof { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-prdp")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnPrf")]
    public ContentInformationType39? ProtectedDelegationProof { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-trgr")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trgr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-adpr")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrcs")]
    public SimpleValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-rtry")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tmcd")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming5? TimeCondition { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-tmch")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    public IsoMax140Binary? TMChallenge { get; init; }

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-kecr")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcrptnCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-erac")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ValueList<ErrorAction5> ErrorAction { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-adif")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-msgi")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition2> MessageItem { get; init; } = [];

    [IsoId("_AOesQbYFEfCUZfsQO4rYeA-dvrq")]
    [DisplayName("Device Request")]
    [IsoXmlTag("DvcRq")]
    public DeviceRequest9? DeviceRequest { get; init; }
}
