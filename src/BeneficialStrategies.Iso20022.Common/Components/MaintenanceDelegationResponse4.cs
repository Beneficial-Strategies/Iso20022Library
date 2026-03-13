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
[IsoId("_B96hQQ01EeqUVL7sB4m7NA")]
[DisplayName("Maintenance Delegation Response")]
public partial record MaintenanceDelegationResponse4
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_CJrFUQ01EeqUVL7sB4m7NA")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public required GenericIdentification176 TMIdentification { get; init; } 
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_CJrFUw01EeqUVL7sB4m7NA")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    public GenericIdentification176? MasterTMIdentification { get; init; } 
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_CJrFVQ01EeqUVL7sB4m7NA")]
    [DisplayName("Delegation Response")]
    [IsoXmlTag("DlgtnRspn")]
    public ValueList<MaintenanceDelegation9> DelegationResponse { get; init; } = [];
    // ID for the above is _CJrFVQ01EeqUVL7sB4m7NA
    
    
    #nullable disable
    
}
