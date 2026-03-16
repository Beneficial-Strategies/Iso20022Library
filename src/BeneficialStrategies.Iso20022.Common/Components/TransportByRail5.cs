// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the transportation of goods by rail.
/// </summary>
[IsoId("_hVLs4Yj7EeO0H4aqD2Yw9Q")]
[DisplayName("Transport By Rail")]
public record TransportByRail5
{
    /// <summary>
    /// Identifies the location where the goods are received for transportation.
    /// </summary>
    [IsoId("_hl1_EYj7EeO0H4aqD2Yw9Q")]
    [DisplayName("Place Of Receipt")]
    [IsoXmlTag("PlcOfRct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PlaceOfReceipt { get; init; }

    /// <summary>
    /// Identifies the location of delivery of the goods.
    /// </summary>
    [IsoId("_hl1_E4j7EeO0H4aqD2Yw9Q")]
    [DisplayName("Place Of Delivery")]
    [IsoXmlTag("PlcOfDlvry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> PlaceOfDelivery { get; init; } = [];

    // ID for the above is _hl1_E4j7EeO0H4aqD2Yw9Q

    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_hl1_FYj7EeO0H4aqD2Yw9Q")]
    [DisplayName("Rail Carrier Name")]
    [IsoXmlTag("RailCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? RailCarrierName { get; init; }

    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_hl1_F4j7EeO0H4aqD2Yw9Q")]
    [DisplayName("Rail Carrier Country")]
    [IsoXmlTag("RailCrrierCtry")]
    public CountryCode? RailCarrierCountry { get; init; }

    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_hl1_GYj7EeO0H4aqD2Yw9Q")]
    [DisplayName("Carrier Agent Name")]
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CarrierAgentName { get; init; }

    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_hl1_G4j7EeO0H4aqD2Yw9Q")]
    [DisplayName("Carrier Agent Country")]
    [IsoXmlTag("CrrierAgtCtry")]
    public CountryCode? CarrierAgentCountry { get; init; }
}
