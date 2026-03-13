// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
[IsoId("_Q75pYdqEEeearpaEPXv9UA")]
[DisplayName("Maintenance Delegation Response")]
public partial record MaintenanceDelegationResponse3
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_REqj0dqEEeearpaEPXv9UA")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification72 TMIdentification { get; init; } 
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_REqj09qEEeearpaEPXv9UA")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_REqj1dqEEeearpaEPXv9UA")]
    [DisplayName("Delegation Response")]
    [IsoXmlTag("DlgtnRspn")]
    public ValueList<MaintenanceDelegation6> DelegationResponse { get; init; } = [];
    // ID for the above is _REqj1dqEEeearpaEPXv9UA
    
    
    #nullable disable
    
}
