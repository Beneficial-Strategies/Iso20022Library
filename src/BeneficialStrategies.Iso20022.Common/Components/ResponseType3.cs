// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[IsoId("_15bm0YqCEeS3NqNpgnMh2w")]
[DisplayName("Response Type")]
public partial record ResponseType3
{
    #nullable enable
    
    /// <summary>
    /// Result of the requested transaction.
    /// </summary>
    [IsoId("_2FgT8YqCEeS3NqNpgnMh2w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response4Code Response { get; init; } 
    
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_2FgT84qCEeS3NqNpgnMh2w")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public ResultDetail2Code? ResponseReason { get; init; } 
    
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_2FgT9YqCEeS3NqNpgnMh2w")]
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 
    
    
    #nullable disable
    
}
