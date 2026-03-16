// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Single terminal management action to be performed by the point of interaction.
/// </summary>
[IsoId("_A5VLYdqJEeearpaEPXv9UA")]
[DisplayName("TMS Action")]
public record TMSAction7
{
    /// <summary>
    /// Types of action to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_BCJJIdqJEeearpaEPXv9UA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TerminalManagementAction4Code Type { get; init; }

    /// <summary>
    /// Host access information.
    /// </summary>
    [IsoId("_BCJJI9qJEeearpaEPXv9UA")]
    [DisplayName("Remote Access")]
    [IsoXmlTag("RmotAccs")]
    public NetworkParameters5? RemoteAccess { get; init; }

    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    [IsoId("_4sYLYNwlEeeKpa-yxjuKzQ")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<KEKIdentifier5> Key { get; init; } = [];

    /// <summary>
    /// Identification of the master terminal manager or the terminal manager with which the POI has to perform the action.
    /// </summary>
    [IsoId("_BCJJJdqJEeearpaEPXv9UA")]
    [DisplayName("Terminal Manager Identification")]
    [IsoXmlTag("TermnlMgrId")]
    public GenericIdentification71? TerminalManagerIdentification { get; init; }

    /// <summary>
    /// TMS protocol to use for performing the maintenance action.
    /// </summary>
    [IsoId("_BCJJJ9qJEeearpaEPXv9UA")]
    [DisplayName("TMS Protocol")]
    [IsoXmlTag("TMSPrtcol")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocol { get; init; }

    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    [IsoId("_BCJJKdqJEeearpaEPXv9UA")]
    [DisplayName("TMS Protocol Version")]
    [IsoXmlTag("TMSPrtcolVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TMSProtocolVersion { get; init; }

    /// <summary>
    /// Data set on which the action has to be performed.
    /// </summary>
    [IsoId("_BCJJK9qJEeearpaEPXv9UA")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public DataSetIdentification7? DataSetIdentification { get; init; }

    /// <summary>
    /// Type of POI components to send in a status report.
    /// </summary>
    [IsoId("_BCJJLdqJEeearpaEPXv9UA")]
    [DisplayName("Component Type")]
    [IsoXmlTag("CmpntTp")]
    public SimpleValueList<DataSetCategory12Code> ComponentType { get; init; } = [];

    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    [IsoId("_BCJJL9qJEeearpaEPXv9UA")]
    [DisplayName("Delegation Scope Identification")]
    [IsoXmlTag("DlgtnScpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DelegationScopeIdentification { get; init; }

    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_BCJJMdqJEeearpaEPXv9UA")]
    [DisplayName("Delegation Scope Definition")]
    [IsoXmlTag("DlgtnScpDef")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; }

    /// <summary>
    /// This element contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    [IsoId("_BCJJM9qJEeearpaEPXv9UA")]
    [DisplayName("Delegation Proof")]
    [IsoXmlTag("DlgtnProof")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? DelegationProof { get; init; }

    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    [IsoId("_BCJJNdqJEeearpaEPXv9UA")]
    [DisplayName("Protected Delegation Proof")]
    [IsoXmlTag("PrtctdDlgtnProof")]
    public ContentInformationType19? ProtectedDelegationProof { get; init; }

    /// <summary>
    /// Event on which the action has to be activated by the point of interaction (POI).
    /// </summary>
    [IsoId("_BCJJN9qJEeearpaEPXv9UA")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public required TerminalManagementActionTrigger1Code Trigger { get; init; }

    /// <summary>
    /// Additional process to perform before starting or after completing the action by the point of interaction (POI).
    /// </summary>
    [IsoId("_BCJJOdqJEeearpaEPXv9UA")]
    [DisplayName("Additional Process")]
    [IsoXmlTag("AddtlPrc")]
    public SimpleValueList<TerminalManagementAdditionalProcess1Code> AdditionalProcess { get; init; } =
        [];

    /// <summary>
    /// Definition of retry process if activation of the action fails.
    /// </summary>
    [IsoId("_BCJJO9qJEeearpaEPXv9UA")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry2? ReTry { get; init; }

    /// <summary>
    /// Date and time the action has to be performed.
    /// </summary>
    [IsoId("_BCJJPdqJEeearpaEPXv9UA")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming3? TimeCondition { get; init; }

    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    [IsoId("_BCJJP9qJEeearpaEPXv9UA")]
    [DisplayName("TM Challenge")]
    [IsoXmlTag("TMChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? TMChallenge { get; init; }

    /// <summary>
    /// Certificate chain for the encryption of temporary transport key of the key to inject.
    /// </summary>
    [IsoId("_BCJJQdqJEeearpaEPXv9UA")]
    [DisplayName("Key Encipherment Certificate")]
    [IsoXmlTag("KeyNcphrmntCert")]
    public SimpleValueList<IsoMax10KBinary> KeyEnciphermentCertificate { get; init; } = [];

    /// <summary>
    /// Action to perform in case of error on the related action in progress.
    /// </summary>
    [IsoId("_BCJJQ9qJEeearpaEPXv9UA")]
    [DisplayName("Error Action")]
    [IsoXmlTag("ErrActn")]
    public ValueList<ErrorAction4> ErrorAction { get; init; } = [];

    /// <summary>
    /// Additional information about the maintenance action.
    /// </summary>
    [IsoId("_BCJJRdqJEeearpaEPXv9UA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax3000Binary> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Configuration of a message item.
    /// </summary>
    [IsoId("_HOzfsNqJEeearpaEPXv9UA")]
    [DisplayName("Message Item")]
    [IsoXmlTag("MsgItm")]
    public ValueList<MessageItemCondition1> MessageItem { get; init; } = [];
}
