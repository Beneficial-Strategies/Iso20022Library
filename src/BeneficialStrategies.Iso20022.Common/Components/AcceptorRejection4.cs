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
[IsoId("_MZve4YPcEeSgq87JnUGd8A")]
[DisplayName("Acceptor Rejection")]
public partial record AcceptorRejection4
{
    #nullable enable
    
    /// <summary>
    /// Reject reason of the message.
    /// </summary>
    [IsoId("_Mmjy4YPcEeSgq87JnUGd8A")]
    [DisplayName("Reject Reason")]
    [IsoXmlTag("RjctRsn")]
    public required RejectReason1Code RejectReason { get; init; } 
    
    /// <summary>
    /// Detailed description of an error that caused the rejection for further analysis.
    /// </summary>
    [IsoId("_q1SJYIPeEeS-ibzJaEIoIQ")]
    [DisplayName("Error Reporting")]
    [IsoXmlTag("ErrRptg")]
    public ErrorReporting1? ErrorReporting { get; init; } 
    
    /// <summary>
    /// Original request that caused the party to reject it.
    /// </summary>
    [IsoId("_Mmjy5YPcEeSgq87JnUGd8A")]
    [DisplayName("Message In Error")]
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? MessageInError { get; init; } 
    
    
    #nullable disable
    
}
