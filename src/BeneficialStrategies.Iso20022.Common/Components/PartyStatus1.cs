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
[IsoId("_knY98-5NEeCisYr99QEiWA_336843792")]
[DisplayName("Party Status")]
public partial record PartyStatus1
{
    #nullable enable
    
    /// <summary>
    /// Status of the party maintenance instruction.
    /// </summary>
    [IsoId("_kniH4O5NEeCisYr99QEiWA_2146103806")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status6Code Status { get; init; } 
    
    /// <summary>
    /// Specifies the underlying reason for the status of an object.
    /// </summary>
    [IsoId("_kniH4e5NEeCisYr99QEiWA_-1456967057")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation10? StatusReason { get; init; } 
    
    /// <summary>
    /// Specifications of a party defined within a system.
    /// </summary>
    [IsoId("_kniH4u5NEeCisYr99QEiWA_-124739370")]
    [DisplayName("System Party Identification")]
    [IsoXmlTag("SysPtyId")]
    public SystemPartyIdentification3? SystemPartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
