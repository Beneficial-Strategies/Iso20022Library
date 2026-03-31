// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related for the transportation of goods by sea.
/// </summary>
[IsoId("_IIXFodQxEeK0PPbKncCqzA")]
[DisplayName("Transport By Sea")]
public record TransportBySea5
{
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_IjneQdQxEeK0PPbKncCqzA")]
    [DisplayName("Port Of Loading")]
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PortOfLoading { get; init; }

    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_IjneQ9QxEeK0PPbKncCqzA")]
    [DisplayName("Port Of Discharge")]
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PortOfDischarge { get; init; }

    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_IjneRdQxEeK0PPbKncCqzA")]
    [DisplayName("Vessel Name")]
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? VesselName { get; init; }

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_IjneR9QxEeK0PPbKncCqzA")]
    [DisplayName("Sea Carrier Name")]
    [IsoXmlTag("SeaCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SeaCarrierName { get; init; }

    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_AU6FgNQzEeK0PPbKncCqzA")]
    [DisplayName("Sea Carrier Country")]
    [IsoXmlTag("SeaCrrierCtry")]
    public CountryCode? SeaCarrierCountry { get; init; }

    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_RYdtINQzEeK0PPbKncCqzA")]
    [DisplayName("Carrier Agent Name")]
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CarrierAgentName { get; init; }

    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_VRJ18NQzEeK0PPbKncCqzA")]
    [DisplayName("Carrier Agent Country")]
    [IsoXmlTag("CrrierAgtCtry")]
    public CountryCode? CarrierAgentCountry { get; init; }

    /// <summary>
    /// Name of the master or captain of a vessel that signs the document for example, bill of lading, charter party bill of lading, non-negotiable sea waybill or multimodal transport document that evidences shipment of the goods from a port of loading to a port of discharge.
    /// </summary>
    [IsoId("_6GgNENQzEeK0PPbKncCqzA")]
    [DisplayName("Master Name")]
    [IsoXmlTag("MstrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? MasterName { get; init; }

    /// <summary>
    /// Name of the company or individual that signs a charter party bill of lading that evidences shipment of the goods from a port of loading to a port of discharge and acts in the capacity of charterer.
    /// </summary>
    [IsoId("_AwsNINQ0EeK0PPbKncCqzA")]
    [DisplayName("Charterer Name")]
    [IsoXmlTag("ChrtrrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ChartererName { get; init; }

    /// <summary>
    /// Name of the company or individual that signs a charter party bill of lading that evidences shipment of the goods from a port of loading to a port of discharge and acts in the capacity of owner;.
    /// </summary>
    [IsoId("_GBZRwNQ0EeK0PPbKncCqzA")]
    [DisplayName("Owner Name")]
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? OwnerName { get; init; }

    /// <summary>
    /// International Maritime Organisation identification of a ship. The IMO identification number scheme was introduced in 1987 as a measure aimed at enhancing maritime safety and pollution prevention and to facilitate the prevention of maritime fraud. It assigns a permanent number to each vessel for identification purposes. This number remains unchanged upon transfer of the vessel to other flag(s) and is inserted in all vessel certificates. The IMO identification number is made up of the three letters &quot;IMO&quot; followed by a seven-digit number assigned to all vessels by IHS FairPlay (formerly known as Lloyd&apos;s Register-Fairplay). This is a unique seven digit number that is assigned to vessels and aids banks in determining whether a vessel is subject to an order that would not permit a bank to handle a certain transaction under local or international laws.
    /// </summary>
    [IsoId("_Xiw2wNQ0EeK0PPbKncCqzA")]
    [DisplayName("IMO Number")]
    [IsoXmlTag("IMONb")]
    [IsoSimpleType(IsoSimpleType.Exact7NumericText)]
    public IsoExact7NumericText? IMONumber { get; init; }

    /// <summary>
    /// Identifies the voyage by sea.
    /// </summary>
    [IsoId("_zjc3ABUyEeOCqpkCrPgk4g")]
    [DisplayName("Voyage Number")]
    [IsoXmlTag("VygNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? VoyageNumber { get; init; }
}
