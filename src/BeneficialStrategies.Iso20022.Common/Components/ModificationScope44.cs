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
[IsoId("_47VDUZTLEemqYPWMBuVawg")]
[DisplayName("Modification Scope")]
public partial record ModificationScope44
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_5QKD0ZTLEemqYPWMBuVawg")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Identification of information which is part of a service level agreement.
    /// </summary>
    [IsoId("_5QKD05TLEemqYPWMBuVawg")]
    [DisplayName("Service Level Agreement")]
    [IsoXmlTag("SvcLvlAgrmt")]
    public required DocumentToSend4 ServiceLevelAgreement { get; init; } 
    
    
    #nullable disable
    
}
