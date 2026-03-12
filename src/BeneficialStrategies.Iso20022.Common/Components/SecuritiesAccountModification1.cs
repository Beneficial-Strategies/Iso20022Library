// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the kind of modification request for securities account reference data.
/// </summary>
[IsoId("_hjLnZ2liEeGaMcKyqKNRfQ_-1195334286")]
[DisplayName("Securities Account Modification")]
public partial record SecuritiesAccountModification1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of requested modification.
    /// </summary>
    [IsoId("_hjLnaGliEeGaMcKyqKNRfQ_-329966777")]
    [DisplayName("Scope Indication")]
    [IsoXmlTag("ScpIndctn")]
    public required DataModification1Code ScopeIndication { get; init; } 
    
    /// <summary>
    /// Specifies the elements to be modified for the securities account reference data.
    /// </summary>
    [IsoId("_hjLnaWliEeGaMcKyqKNRfQ_-1816678899")]
    [DisplayName("Requested Modification")]
    [IsoXmlTag("ReqdMod")]
    public required SecuritiesAccountModification1Choice_ RequestedModification { get; init; } 
    
    
    #nullable disable
    
}
