// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reject of a message from an ATM or an ATM manager.
/// </summary>
[IsoId("_RdZ94a42EeWpsoxRhdX-8A")]
[DisplayName("ATM Reject")]
public record ATMReject2
{
    /// <summary>
    /// Identification of the entity sending the reject message.
    /// </summary>
    [IsoId("_RoSYMa42EeWpsoxRhdX-8A")]
    [DisplayName("Reject Initiator Identification")]
    [IsoXmlTag("RjctInitrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RejectInitiatorIdentification { get; init; }

    /// <summary>
    /// High level information allowing the sender of a request or an advice to know the types of error, and handle them accordingly.
    /// </summary>
    [IsoId("_RoSYM642EeWpsoxRhdX-8A")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public required RejectReason1Code RejectReason { get; init; }

    /// <summary>
    /// Additional information related to the sending of a reject message in response to a request or an advice.
    /// For logging purpose, in order to allow further analysis, statistics and deferred processing on the success or the failure of the request processing.
    /// </summary>
    [IsoId("_RoSYNa42EeWpsoxRhdX-8A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_RoSYN642EeWpsoxRhdX-8A")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];

    /// <summary>
    /// Received message that has been rejected.
    /// </summary>
    [IsoId("_RoSYOa42EeWpsoxRhdX-8A")]
    [DisplayName("Message In Error")]
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? MessageInError { get; init; }
}
