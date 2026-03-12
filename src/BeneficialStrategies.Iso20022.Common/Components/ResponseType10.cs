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
[IsoId("_Z5cxkQxqEeqdx6buGpCCQw")]
[DisplayName("Response Type")]
public partial record ResponseType10
{
    #nullable enable
    
    /// <summary>
    /// Result of the transaction.
    /// </summary>
    [IsoId("_aEZdUQxqEeqdx6buGpCCQw")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response9Code Response { get; init; } 
    
    /// <summary>
    /// Detailed result of the transaction.
    /// </summary>
    [IsoId("_aEZdUwxqEeqdx6buGpCCQw")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; } 
    
    /// <summary>
    /// Additional information on the response for further examination.
    /// </summary>
    [IsoId("_aEZdVQxqEeqdx6buGpCCQw")]
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 
    
    
    #nullable disable
    
}
