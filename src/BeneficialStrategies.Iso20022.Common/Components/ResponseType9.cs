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
[IsoId("_mqZT0dxWEeioifFt1dhnJA")]
[DisplayName("Response Type")]
public partial record ResponseType9
{
    #nullable enable
    
    /// <summary>
    /// Result of the requested transaction.
    /// </summary>
    [IsoId("_mz3_8dxWEeioifFt1dhnJA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response5Code Response { get; init; } 
    
    /// <summary>
    /// Detail of the response.
    /// </summary>
    [IsoId("_mz4nAdxWEeioifFt1dhnJA")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    public RetailerResultDetail1Code? ResponseReason { get; init; } 
    
    /// <summary>
    /// Additional information to be logged for further examination.
    /// </summary>
    [IsoId("_mz4nA9xWEeioifFt1dhnJA")]
    [DisplayName("Additional Response Information")]
    [IsoXmlTag("AddtlRspnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalResponseInformation { get; init; } 
    
    
    #nullable disable
    
}
