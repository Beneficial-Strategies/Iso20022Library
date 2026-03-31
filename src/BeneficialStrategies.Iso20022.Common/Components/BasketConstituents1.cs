// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
/// </summary>
[IsoId("_-aZI0QFPEeqUa4noT3P56A")]
[DisplayName("Basket Constituents")]
public record BasketConstituents1
{
    /// <summary>
    /// Proprietary identification of a security assigned by an institution or organisation.
    /// </summary>
    [IsoId("_-kmNtQFPEeqUa4noT3P56A")]
    [DisplayName("Instrument Identification")]
    [IsoXmlTag("InstrmId")]
    public required InstrumentIdentification1Choice_ InstrumentIdentification { get; init; }

    /// <summary>
    /// Indicates the number of units of a particular constituent in a custom basket.
    /// </summary>
    [IsoId("_675osgFPEeqUa4noT3P56A")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.LongFraction19DecimalNumber)]
    public IsoLongFraction19DecimalNumber? Quantity { get; init; }

    /// <summary>
    /// Specifies the unit of measure in which the number of units of a particular custom basket constituent is expressed.
    /// </summary>
    [IsoId("_675oswFPEeqUa4noT3P56A")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure12Code? UnitOfMeasure { get; init; }
}
