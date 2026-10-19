// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging Room2.
/// </summary>
[IsoId("_ZOHLwXTrEe6h-4AZRg9sVg")]
[DisplayName("Lodging Room2")]
public partial record LodgingRoom2
{
    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public Max35Text? Type { get; init; }

    /// <summary>
    /// Location.
    /// </summary>
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public Max35Text? Location { get; init; }

    /// <summary>
    /// Bed Type.
    /// </summary>
    [DisplayName("Bed Type")]
    [IsoXmlTag("BedTp")]
    public Max70Text? BedType { get; init; }

    /// <summary>
    /// Guests.
    /// </summary>
    [DisplayName("Guests")]
    [IsoXmlTag("Gsts")]
    public Max3NumericText? Guests { get; init; }

    /// <summary>
    /// Adults.
    /// </summary>
    [DisplayName("Adults")]
    [IsoXmlTag("Adlts")]
    public Max3NumericText? Adults { get; init; }

    /// <summary>
    /// Children.
    /// </summary>
    [DisplayName("Children")]
    [IsoXmlTag("Chldrn")]
    public Max3NumericText? Children { get; init; }

    /// <summary>
    /// Daily Rate.
    /// </summary>
    [DisplayName("Daily Rate")]
    [IsoXmlTag("DalyRate")]
    public ImpliedCurrencyAndAmount? DailyRate { get; init; }
}
