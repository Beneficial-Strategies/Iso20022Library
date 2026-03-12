// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a blocked status.
/// </summary>
[IsoId("__e0zUV1LEeagR5I1rq5oaw")]
[DisplayName("Blocked Status Reason")]
public partial record BlockedStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction for which the account has a blocked status.
    /// </summary>
    [IsoId("__4jh8V1LEeagR5I1rq5oaw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required TransactionType5Choice_ TransactionType { get; init; } 
    
    /// <summary>
    /// Indicates whether the account is blocked.
    /// </summary>
    [IsoId("_E6gY4V1MEeagR5I1rq5oaw")]
    [DisplayName("Blocked")]
    [IsoXmlTag("Blckd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Blocked { get; init; } 
    
    /// <summary>
    /// Reason for the blocked status.
    /// </summary>
    [IsoId("__4jh811LEeagR5I1rq5oaw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public BlockedReason2Choice_? Reason { get; init; } 
    
    /// <summary>
    /// Additional information about the blocked account status.
    /// </summary>
    [IsoId("__4jh9V1LEeagR5I1rq5oaw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
