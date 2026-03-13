// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the the request of maintenance delegations.
/// </summary>
[IsoId("_oM_zAGp4EeSojYXQbRlLzA")]
[DisplayName("Maintenance Delegation Request")]
public partial record MaintenanceDelegationRequest1
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_5sg94Gp4EeSojYXQbRlLzA")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification72 TMIdentification { get; init; } 
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_-2RtAGp4EeSojYXQbRlLzA")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_Hj6ykGp5EeSojYXQbRlLzA")]
    [DisplayName("Requested Delegation")]
    [IsoXmlTag("ReqdDlgtn")]
    public ValueList<MaintenanceDelegation1> RequestedDelegation { get; init; } = [];
    // ID for the above is _Hj6ykGp5EeSojYXQbRlLzA
    
    
    #nullable disable
    
}
