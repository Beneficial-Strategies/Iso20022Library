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
[IsoId("_pV0D4SJREeWOwvWbbXyDPw")]
[DisplayName("Modification Scope")]
public partial record ModificationScope33
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_pyh1ESJREeWOwvWbbXyDPw")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Referral information.
    /// </summary>
    [IsoId("_ypOI8CJREeWOwvWbbXyDPw")]
    [DisplayName("Placement")]
    [IsoXmlTag("Plcmnt")]
    public required ReferredAgent2 Placement { get; init; } 
    
    
    #nullable disable
    
}
