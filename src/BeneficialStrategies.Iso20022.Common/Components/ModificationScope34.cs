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
[IsoId("_ZI_1kUKTEeWuG5hmkcJWSQ")]
[DisplayName("Modification Scope")]
public partial record ModificationScope34
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_ZlQ60UKTEeWuG5hmkcJWSQ")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Address of the organisation.
    /// </summary>
    [IsoId("_ZlQ600KTEeWuG5hmkcJWSQ")]
    [DisplayName("Postal Address")]
    [IsoXmlTag("PstlAdr")]
    public required PostalAddress21 PostalAddress { get; init; } 
    
    
    #nullable disable
    
}
