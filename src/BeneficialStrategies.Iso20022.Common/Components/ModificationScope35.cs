// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_Np_CgUzaEea8fovz_9xSTQ")]
[DisplayName("Modification Scope")]
public partial record ModificationScope35
{
    #nullable enable
    
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_ODRsQUzaEea8fovz_9xSTQ")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Additional information such as remarks or notes that must be conveyed about the party and or limitations and restrictions.
    /// </summary>
    [IsoId("_ODRsQ0zaEea8fovz_9xSTQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditiononalInformation12> AdditionalInformation { get; init; } = [];
    // ID for the above is _ODRsQ0zaEea8fovz_9xSTQ
    
    
    #nullable disable
    
}
