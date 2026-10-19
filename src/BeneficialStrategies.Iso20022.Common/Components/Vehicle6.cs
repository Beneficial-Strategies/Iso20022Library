// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle6.
/// </summary>
[IsoId("_mc1NwXNUEe6Y1uOeeiF_Eg")]
[DisplayName("Vehicle6")]
public partial record Vehicle6
{
    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public Max35NumericText? Number { get; init; }

    /// <summary>
    /// Identification Number.
    /// </summary>
    [DisplayName("Identification Number")]
    [IsoXmlTag("IdNb")]
    public Max35NumericText? IdentificationNumber { get; init; }

    /// <summary>
    /// Fleet Number.
    /// </summary>
    [DisplayName("Fleet Number")]
    [IsoXmlTag("FleetNb")]
    public Max10Text? FleetNumber { get; init; }

    /// <summary>
    /// Sub Fleet Number.
    /// </summary>
    [DisplayName("Sub Fleet Number")]
    [IsoXmlTag("SubFleetNb")]
    public Max35Text? SubFleetNumber { get; init; }

    /// <summary>
    /// Unit Number.
    /// </summary>
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    public Max35NumericText? UnitNumber { get; init; }

    /// <summary>
    /// Trailer Number.
    /// </summary>
    [DisplayName("Trailer Number")]
    [IsoXmlTag("TrlrNb")]
    public Max35NumericText? TrailerNumber { get; init; }

    /// <summary>
    /// Tag.
    /// </summary>
    [DisplayName("Tag")]
    [IsoXmlTag("Tag")]
    public Max35Text? Tag { get; init; }

    /// <summary>
    /// Tag Entry Mode.
    /// </summary>
    [DisplayName("Tag Entry Mode")]
    [IsoXmlTag("TagNtryMd")]
    public CardDataReading5Code? TagEntryMode { get; init; }

    /// <summary>
    /// Replacement.
    /// </summary>
    [DisplayName("Replacement")]
    [IsoXmlTag("Rplcmnt")]
    public TrueFalseIndicator? Replacement { get; init; }

    /// <summary>
    /// Odometer.
    /// </summary>
    [DisplayName("Odometer")]
    [IsoXmlTag("Odmtr")]
    public DecimalNumber? Odometer { get; init; }

    /// <summary>
    /// Hubometer.
    /// </summary>
    [DisplayName("Hubometer")]
    [IsoXmlTag("Hbmtr")]
    public DecimalNumber? Hubometer { get; init; }

    /// <summary>
    /// Maintenance Identification.
    /// </summary>
    [DisplayName("Maintenance Identification")]
    [IsoXmlTag("MntncId")]
    public Max35Text? MaintenanceIdentification { get; init; }

    /// <summary>
    /// On Board Diagnostics.
    /// </summary>
    [DisplayName("On Board Diagnostics")]
    [IsoXmlTag("OnBrdDgnstcs")]
    public OnBoardDiagnostics1? OnBoardDiagnostics { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<Vehicle2> AdditionalData { get; init; } = [];
}
