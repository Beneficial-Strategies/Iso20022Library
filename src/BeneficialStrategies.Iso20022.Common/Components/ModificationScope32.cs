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
[IsoId("_ZauXsSF2EeW9XJWqfgXIIA")]
[DisplayName("Modification Scope")]
public partial record ModificationScope32
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_Z2r68SF2EeW9XJWqfgXIIA")]
    [DisplayName("Modification Scope Indication")]
    [IsoXmlTag("ModScpIndctn")]
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    
    /// <summary>
    /// Information used to determine fees and types of operations that can be carried out on the account.
    /// </summary>
    [IsoId("_GfSBoSDXEeWCLu74WLgP4w")]
    [DisplayName("Investor Profile")]
    [IsoXmlTag("InvstrPrfl")]
    public required InvestorProfile1 InvestorProfile { get; init; } 
    
    
    #nullable disable
    
}
