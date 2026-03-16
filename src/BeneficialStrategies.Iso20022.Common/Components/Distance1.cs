// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Distance between a start and a return car rental period.
/// </summary>
[IsoId("_M0xaMF_pEee-csPAW1txwQ")]
[DisplayName("Distance")]
public record Distance1
{
    /// <summary>
    /// Unit of measure used to compute the distance.
    /// </summary>
    [IsoId("_cqOP8F_pEee-csPAW1txwQ")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure10Code? UnitOfMeasure { get; init; }

    /// <summary>
    /// Odometer reading at start of rental (at the time of vehicle check-out).
    /// </summary>
    [IsoId("_B81x4F_qEee-csPAW1txwQ")]
    [DisplayName("Odometer Start")]
    [IsoXmlTag("OdmtrStart")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? OdometerStart { get; init; }

    /// <summary>
    /// Odometer reading at return of rental (at the time of vehicle check-in).
    /// </summary>
    [IsoId("_KHAW8F_qEee-csPAW1txwQ")]
    [DisplayName("Odometer Return")]
    [IsoXmlTag("OdmtrRtr")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? OdometerReturn { get; init; }

    /// <summary>
    /// Total distance expressed in unit of measure.
    /// </summary>
    [IsoId("_PvfCYF_qEee-csPAW1txwQ")]
    [DisplayName("Total Distance")]
    [IsoXmlTag("TtlDstnc")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? TotalDistance { get; init; }

    /// <summary>
    /// Maximum free miles or kilometres for the car rental period.
    /// </summary>
    [IsoId("_XtVCsF_qEee-csPAW1txwQ")]
    [DisplayName("Free Distance")]
    [IsoXmlTag("FreeDstnc")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? FreeDistance { get; init; }

    /// <summary>
    /// Defines the rate in relation to a specific distance.
    /// </summary>
    [IsoId("_WT2uwPS2Eeife6veM7daYw")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; }
}
