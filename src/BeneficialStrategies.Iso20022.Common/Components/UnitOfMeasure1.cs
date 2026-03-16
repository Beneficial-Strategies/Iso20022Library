// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[IsoId("_m5ZdU_cqEeiW-auGnDPZIw")]
[DisplayName("Unit Of Measure")]
public record UnitOfMeasure1
{
    /// <summary>
    /// Unit of measure of the item being shipped.
    /// </summary>
    [IsoId("_Hmqkw_crEeiW-auGnDPZIw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_HmqkxPcrEeiW-auGnDPZIw")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Number of units.
    /// </summary>
    [IsoId("_HmqkxfcrEeiW-auGnDPZIw")]
    [DisplayName("Number Of Units")]
    [IsoXmlTag("NbOfUnits")]
    public ImpliedCurrencyAndAmount? NumberOfUnits { get; init; }
}
