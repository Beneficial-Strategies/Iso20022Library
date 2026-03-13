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
[IsoId("_tJYcASFoEeW9XJWqfgXIIA")]
[DisplayName("Modification Scope")]
public partial record ModificationScope30
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_tkwwcSFoEeW9XJWqfgXIIA")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Additional information concerning limitations and restrictions on the account.
    /// </summary>
    [IsoId("_xKBm8SFoEeW9XJWqfgXIIA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AccountRestrictions1> AdditionalInformation { get; init; } = [];
    // ID for the above is _xKBm8SFoEeW9XJWqfgXIIA
    
    
    #nullable disable
    
}
