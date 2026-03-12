// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
[IsoId("_5SG1s5NLEeWGlc8L7oPDIg")]
[DisplayName("Securities Account")]
public partial record SecuritiesAccount30
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_5SG1tZNLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Specifies the type of securities account.
    /// </summary>
    [IsoId("_5SG1yZNLEeWGlc8L7oPDIg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public GenericIdentification47? Type { get; init; } 
    
    /// <summary>
    /// Description of the account.
    /// </summary>
    [IsoId("_5SG13ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    
    #nullable disable
    
}
