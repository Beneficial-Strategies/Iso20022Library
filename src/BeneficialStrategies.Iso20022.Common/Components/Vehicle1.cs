// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a vehicle used during a transaction.
/// </summary>
[IsoId("_KI-4wJXyEeWMQt4mOczoDw")]
[DisplayName("Vehicle")]
public record Vehicle1
{
    /// <summary>
    /// Number assigned to the vehicle for identification.
    /// </summary>
    [IsoId("_YNf8YJXyEeWMQt4mOczoDw")]
    [DisplayName("Vehicle Number")]
    [IsoXmlTag("VhclNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? VehicleNumber { get; init; }

    /// <summary>
    /// Number assigned to the vehicle trailer for identification.
    /// </summary>
    [IsoId("_b6qKoJXyEeWMQt4mOczoDw")]
    [DisplayName("Trailer Number")]
    [IsoXmlTag("TrlrNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? TrailerNumber { get; init; }

    /// <summary>
    /// Registration tag of the vehicle.
    /// </summary>
    [IsoId("_h6RjsJXyEeWMQt4mOczoDw")]
    [DisplayName("Vehicle Tag")]
    [IsoXmlTag("VhclTag")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? VehicleTag { get; init; }

    /// <summary>
    /// Entry mode of the registration tag.
    /// </summary>
    [IsoId("_mp2RMJXyEeWMQt4mOczoDw")]
    [DisplayName("Vehicle Tag Entry Mode")]
    [IsoXmlTag("VhclTagNtryMd")]
    public CardDataReading5Code? VehicleTagEntryMode { get; init; }

    /// <summary>
    /// Identification of the vehicle in the fleet.
    /// </summary>
    [IsoId("_pxuoIJXyEeWMQt4mOczoDw")]
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? UnitNumber { get; init; }

    /// <summary>
    /// True if the car is a replacement car.
    /// </summary>
    [IsoId("_vPMWYJXyEeWMQt4mOczoDw")]
    [DisplayName("Replacement Car")]
    [IsoXmlTag("RplcmntCar")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReplacementCar { get; init; }

    /// <summary>
    /// Odometer reading value indicating the distance travelled by the vehicle.
    /// </summary>
    [IsoId("_yYGBAJXyEeWMQt4mOczoDw")]
    [DisplayName("Odometer")]
    [IsoXmlTag("Odmtr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Odometer { get; init; }

    /// <summary>
    /// Hubometer reading value indicating the distance travelled by the trailer.
    /// </summary>
    [IsoId("_4WJT0JXyEeWMQt4mOczoDw")]
    [DisplayName("Hubometer")]
    [IsoXmlTag("Hbmtr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Hubometer { get; init; }

    /// <summary>
    /// Number of hours the trailer has been in operation.
    /// </summary>
    [IsoId("_9SEbQJXyEeWMQt4mOczoDw")]
    [DisplayName("Trailer Hours")]
    [IsoXmlTag("TrlrHrs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TrailerHours { get; init; }

    /// <summary>
    /// Number of hours the refer unit has been in operation.
    /// </summary>
    [IsoId("_DUOyAJXzEeWMQt4mOczoDw")]
    [DisplayName("Refer Hours")]
    [IsoXmlTag("RefrHrs")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReferHours { get; init; }

    /// <summary>
    /// Identification assigned to the vehicle related to maintenance.
    /// </summary>
    [IsoId("_GenqYJXzEeWMQt4mOczoDw")]
    [DisplayName("Maintenance Identification")]
    [IsoXmlTag("MntncId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MaintenanceIdentification { get; init; }

    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_sO5mkJbhEeW6aPG6p-lhQQ")]
    [DisplayName("Driver Or Vehicle Card")]
    [IsoXmlTag("DrvrOrVhclCard")]
    public PlainCardData17? DriverOrVehicleCard { get; init; }

    /// <summary>
    /// Additional information related to the vehicle.
    /// </summary>
    [IsoId("_ww05oJbhEeW6aPG6p-lhQQ")]
    [DisplayName("Additional Vehicle Data")]
    [IsoXmlTag("AddtlVhclData")]
    public ValueList<Vehicle2> AdditionalVehicleData { get; init; } = [];
}
