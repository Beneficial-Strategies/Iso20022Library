// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location6.
/// </summary>
[IsoId("_ZYoPIXTqEe6h-4AZRg9sVg")]
[DisplayName("Location6")]
public partial record Location6
{
    #nullable enable

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 

    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public IsoMax35Text? Code { get; init; } 

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax256Text? Description { get; init; } 

    /// <summary>
    /// Local Currency.
    /// </summary>
    [DisplayName("Local Currency")]
    [IsoXmlTag("LclCcy")]
    public ISO3NumericCurrencyCode? LocalCurrency { get; init; } 

    /// <summary>
    /// Local Time Zone.
    /// </summary>
    [DisplayName("Local Time Zone")]
    [IsoXmlTag("LclTmZone")]
    public IsoMax70Text? LocalTimeZone { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax35Text? Name { get; init; } 

    
    #nullable disable
    
}
