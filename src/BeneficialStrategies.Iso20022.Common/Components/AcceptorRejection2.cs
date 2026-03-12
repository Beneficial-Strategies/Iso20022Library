// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reject of an exchange.
/// </summary>
[IsoId("_8TjN8TTfEeO5e9wx3yvd8g")]
[DisplayName("Acceptor Rejection")]
public partial record AcceptorRejection2
{
    #nullable enable
    
    /// <summary>
    /// Reject reason of the request or the advice.
    /// </summary>
    [IsoId("_8i3cUTTfEeO5e9wx3yvd8g")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public required RejectReason1Code RejectReason { get; init; } 
    
    /// <summary>
    /// Additional information related to the reject of the exchange.
    /// </summary>
    [IsoId("_8i3cUzTfEeO5e9wx3yvd8g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Original request that caused the recipient party to reject it.
    /// </summary>
    [IsoId("_8i3cVTTfEeO5e9wx3yvd8g")]
    [DisplayName("Message In Error")]
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? MessageInError { get; init; } 
    
    
    #nullable disable
    
}
