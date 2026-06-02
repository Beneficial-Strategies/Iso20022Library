// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a fleet vehicle.
/// </summary>
[IsoId("_MNbyIUYmEfCJpvfyM9roFQ")]
[DisplayName("Fleet Vehicle Data1")]
public record FleetVehicleData1
{
    /// <summary>
    /// Identification number assigned to the vehicle by the fleet operator. This may not be a legal registration.
    /// </summary>
    [IsoId("_MPx7gUYmEfCJpvfyM9roFQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax35NumericText? Number { get; init; }

    /// <summary>
    /// Number that uniquely identifies the vehicle as assigned by the vehicle manufacturer.
    /// </summary>
    [IsoId("_MPx7g0YmEfCJpvfyM9roFQ")]
    [DisplayName("Identification Number")]
    [IsoXmlTag("IdNb")]
    public IsoMax35NumericText? IdentificationNumber { get; init; }

    /// <summary>
    /// Fleet number.
    /// </summary>
    [IsoId("_MPx7hUYmEfCJpvfyM9roFQ")]
    [DisplayName("Fleet Number")]
    [IsoXmlTag("FleetNb")]
    public IsoMax10Text? FleetNumber { get; init; }

    /// <summary>
    /// Sub fleet number.
    /// </summary>
    [IsoId("_MPx7h0YmEfCJpvfyM9roFQ")]
    [DisplayName("Sub Fleet Number")]
    [IsoXmlTag("SubFleetNb")]
    public IsoMax35Text? SubFleetNumber { get; init; }

    /// <summary>
    /// Identification of the unit number of the vehicle in the fleet.
    /// </summary>
    [IsoId("_MPx7iUYmEfCJpvfyM9roFQ")]
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    public IsoMax35NumericText? UnitNumber { get; init; }

    /// <summary>
    /// Identification number assigned to the trailer.
    /// </summary>
    [IsoId("_MPx7i0YmEfCJpvfyM9roFQ")]
    [DisplayName("Trailer Number")]
    [IsoXmlTag("TrlrNb")]
    public IsoMax35NumericText? TrailerNumber { get; init; }

    /// <summary>
    /// Registration tag of the vehicle.
    /// </summary>
    [IsoId("_MPx7jUYmEfCJpvfyM9roFQ")]
    [DisplayName("Tag")]
    [IsoXmlTag("Tag")]
    public IsoMax35Text? Tag { get; init; }

    /// <summary>
    /// Entry mode of the registration tag.
    /// </summary>
    [IsoId("_MPx7j0YmEfCJpvfyM9roFQ")]
    [DisplayName("Tag Entry Mode")]
    [IsoXmlTag("TagNtryMd")]
    public CardDataReading5Code? TagEntryMode { get; init; }

    /// <summary>
    /// True indicates a replacement vehicle.
    /// </summary>
    [IsoId("_MPx7kUYmEfCJpvfyM9roFQ")]
    [DisplayName("Replacement")]
    [IsoXmlTag("Rplcmnt")]
    public IsoTrueFalseIndicator? Replacement { get; init; }

    /// <summary>
    /// Odometer reading value indicating the distance travelled by the vehicle.
    /// </summary>
    [IsoId("_MPx7k0YmEfCJpvfyM9roFQ")]
    [DisplayName("Odometer")]
    [IsoXmlTag("Odmtr")]
    public IsoDecimalNumber? Odometer { get; init; }

    /// <summary>
    /// Hubometer reading value indicating the distance travelled by the trailer.
    /// </summary>
    [IsoId("_MPx7lUYmEfCJpvfyM9roFQ")]
    [DisplayName("Hubometer")]
    [IsoXmlTag("Hbmtr")]
    public IsoDecimalNumber? Hubometer { get; init; }

    /// <summary>
    /// Identification assigned to the vehicle related to maintenance.
    /// </summary>
    [IsoId("_MPx7l0YmEfCJpvfyM9roFQ")]
    [DisplayName("Maintenance Identification")]
    [IsoXmlTag("MntncId")]
    public IsoMax35Text? MaintenanceIdentification { get; init; }

    /// <summary>
    /// Data captured from on board diagnostic systems.
    /// </summary>
    [IsoId("_MPx7mUYmEfCJpvfyM9roFQ")]
    [DisplayName("On Board Diagnostics")]
    [IsoXmlTag("OnBrdDgnstcs")]
    public OnBoardDiagnostics1? OnBoardDiagnostics { get; init; }

    /// <summary>
    /// Additional information related to the vehicle.
    /// </summary>
    [IsoId("_MPx7m0YmEfCJpvfyM9roFQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<Vehicle2> AdditionalData { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("__sCHEkYlEfCJpvfyM9roFQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("__sCHE0YlEfCJpvfyM9roFQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
