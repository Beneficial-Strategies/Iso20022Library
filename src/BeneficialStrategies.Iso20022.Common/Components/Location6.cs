// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Location6.
/// </summary>
[IsoId("_ZYoPIXTqEe6h-4AZRg9sVg")]
[DisplayName("Location6")]
public record Location6
{
    /// <summary>
    /// Code.
    /// </summary>
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public Max35Text? Code { get; init; }

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public Max35Text? Name { get; init; }

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public Max256Text? Description { get; init; }

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Local Time Zone.
    /// </summary>
    [DisplayName("Local Time Zone")]
    [IsoXmlTag("LclTmZone")]
    public Max70Text? LocalTimeZone { get; init; }

    /// <summary>
    /// Local Currency.
    /// </summary>
    [DisplayName("Local Currency")]
    [IsoXmlTag("LclCcy")]
    public ISO3NumericCurrencyCode? LocalCurrency { get; init; }
}
