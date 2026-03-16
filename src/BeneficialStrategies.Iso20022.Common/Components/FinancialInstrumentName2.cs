// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Name of the security.
/// </summary>
[IsoId("_Olzf4WqUEemHy6n1hjosWw")]
[DisplayName("Financial Instrument Name")]
public record FinancialInstrumentName2
{
    /// <summary>
    /// Short name of the security expressed as ISO 18773/18774.
    /// </summary>
    [IsoId("_OzhLwWqUEemHy6n1hjosWw")]
    [DisplayName("ISO Short Name")]
    [IsoXmlTag("ISOShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ISOShortName { get; init; }

    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_OzhLw2qUEemHy6n1hjosWw")]
    [DisplayName("ISO Long Name")]
    [IsoXmlTag("ISOLngNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ISOLongName { get; init; }

    /// <summary>
    /// Defines the date since when the name of the security is valid.
    /// </summary>
    [IsoId("_OzhLxWqUEemHy6n1hjosWw")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public DateAndDateTime2Choice_? ValidFrom { get; init; }
}
