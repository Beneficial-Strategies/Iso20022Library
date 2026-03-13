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
[IsoId("_5IxrwGqFEeS8RZDTbvnB_A")]
[DisplayName("Maintenance Delegation Response")]
public partial record MaintenanceDelegationResponse1
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_SszfoGqGEeS8RZDTbvnB_A")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification72 TMIdentification { get; init; } 
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_bn054GqGEeS8RZDTbvnB_A")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_0C2eUGqGEeS8RZDTbvnB_A")]
    [DisplayName("Delegation Response")]
    [IsoXmlTag("DlgtnRspn")]
    public ValueList<MaintenanceDelegation2> DelegationResponse { get; init; } = [];
    // ID for the above is _0C2eUGqGEeS8RZDTbvnB_A
    
    
    #nullable disable
    
}
