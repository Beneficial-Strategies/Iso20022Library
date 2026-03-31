// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reject of an exchange.
/// </summary>
[IsoId("_G5i8sWp1EeSMqvBfBY1c9A")]
[DisplayName("Acceptor Rejection")]
public record AcceptorRejection3
{
    /// <summary>
    /// Reject reason of the request or the advice.
    /// </summary>
    [IsoId("_HGEVwWp1EeSMqvBfBY1c9A")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public required RejectReason2Code RejectReason { get; init; }

    /// <summary>
    /// Additional information related to the reject of the exchange.
    /// </summary>
    [IsoId("_HGEVw2p1EeSMqvBfBY1c9A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500, MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Original request that caused the recipient party to reject it.
    /// </summary>
    [IsoId("_HGEVxWp1EeSMqvBfBY1c9A")]
    [DisplayName("Message In Error")]
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? MessageInError { get; init; }
}
