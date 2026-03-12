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
[IsoId("_Svfw9wEcEeCQm6a_G2yO_w_1794621080")]
[DisplayName("Acceptor Rejection")]
public partial record AcceptorRejection1
{
    #nullable enable
    
    /// <summary>
    /// Reject reason of the request or the advice.
    /// </summary>
    [IsoId("_Svfw-AEcEeCQm6a_G2yO_w_-144097158")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public required RejectReason1Code RejectReason { get; init; } 
    
    /// <summary>
    /// Additional information related to the reject of the exchange.
    /// </summary>
    [IsoId("_Svfw-QEcEeCQm6a_G2yO_w_-155195935")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Original request that caused the recipient party to reject it.
    /// </summary>
    [IsoId("_Svfw-gEcEeCQm6a_G2yO_w_-622814345")]
    [DisplayName("Message In Error")]
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public IsoMax5000Binary? MessageInError { get; init; } 
    
    
    #nullable disable
    
}
