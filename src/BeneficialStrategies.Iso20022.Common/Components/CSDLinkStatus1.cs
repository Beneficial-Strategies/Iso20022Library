// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business status of the party for processing in the system.
/// </summary>
[IsoId("_hiJFnWliEeGaMcKyqKNRfQ_-127584604")]
[DisplayName("CSD Link Status")]
public partial record CSDLinkStatus1
{
    #nullable enable
    
    /// <summary>
    /// Status of the party maintenance instruction.
    /// </summary>
    [IsoId("_hiJFnmliEeGaMcKyqKNRfQ_-241423670")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status6Code Status { get; init; } 
    
    /// <summary>
    /// Underlying reason related to the creation of a transaction.
    /// </summary>
    [IsoId("_hiJFn2liEeGaMcKyqKNRfQ_-1124656957")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation10? StatusReason { get; init; } 
    
    
    #nullable disable
    
}
