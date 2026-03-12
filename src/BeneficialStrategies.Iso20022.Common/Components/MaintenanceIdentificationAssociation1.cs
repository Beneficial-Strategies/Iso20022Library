// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Association of the TM identifier and the MTM identifier of an entity.
/// </summary>
[IsoId("_mG754GqCEeSojYXQbRlLzA")]
[DisplayName("Maintenance Identification Association")]
public partial record MaintenanceIdentificationAssociation1
{
    #nullable enable
    
    /// <summary>
    /// Identifier for the master terminal manager.
    /// </summary>
    [IsoId("_0cY8gGqCEeSojYXQbRlLzA")]
    [DisplayName("Master TM Identification")]
    [IsoXmlTag("MstrTMId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MasterTMIdentification { get; init; } 
    
    /// <summary>
    /// Identifier for the terminal manager requesting the delegation.
    /// </summary>
    [IsoId("_8ftSsGqCEeSojYXQbRlLzA")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TMIdentification { get; init; } 
    
    
    #nullable disable
    
}
