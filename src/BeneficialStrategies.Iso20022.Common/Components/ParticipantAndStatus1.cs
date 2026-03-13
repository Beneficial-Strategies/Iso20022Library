// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the participant and their operational status.
/// </summary>
[IsoId("_Odl2BdNSEeWCqoSJYcWUsg")]
[DisplayName("Participant And Status")]
public partial record ParticipantAndStatus1
{
    #nullable enable
    
    /// <summary>
    /// Identification of participant.
    /// </summary>
    [IsoId("_Odl2B9NSEeWCqoSJYcWUsg")]
    [DisplayName("Participant Identification")]
    [IsoXmlTag("PtcptId")]
    public required FinancialInstitutionIdentification13 ParticipantIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements used to indicate how to contact the participant.
    /// </summary>
    [IsoId("_Odl2BtNSEeWCqoSJYcWUsg")]
    [DisplayName("Participant Contact Details")]
    [IsoXmlTag("PtcptCtctDtls")]
    public ContactDetails2? ParticipantContactDetails { get; init; } 
    
    /// <summary>
    /// Provides details on operational availability of the participant business service.
    /// </summary>
    [IsoId("_Odl2CdNSEeWCqoSJYcWUsg")]
    [DisplayName("Service Availability")]
    [IsoXmlTag("SvcAvlbty")]
    public ValueList<ServiceAvailability1> ServiceAvailability { get; init; } = [];
    // ID for the above is _Odl2CdNSEeWCqoSJYcWUsg
    
    
    #nullable disable
    
}
