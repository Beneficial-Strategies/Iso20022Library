// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_wKGeYRytEey6gI8SKlv7rg")]
[DisplayName("Fleet Summary")]
public record FleetSummary2
{
    /// <summary>
    /// Contains driver-related information.
    /// </summary>
    [IsoId("_wQXecRytEey6gI8SKlv7rg")]
    [DisplayName("Driver")]
    [IsoXmlTag("Drvr")]
    public Driver2? Driver { get; init; }

    /// <summary>
    /// Vehicle belonging to the fleet.
    /// </summary>
    [IsoId("_wQXecxytEey6gI8SKlv7rg")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle5? Vehicle { get; init; }

    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_wQXedRytEey6gI8SKlv7rg")]
    [DisplayName("Driver Or Vehicle Card")]
    [IsoXmlTag("DrvrOrVhclCard")]
    public PlainCardData21? DriverOrVehicleCard { get; init; }

    /// <summary>
    /// Indicates whether or not fuel or fleet data prompting should occur.
    /// </summary>
    [IsoId("_wQXedxytEey6gI8SKlv7rg")]
    [DisplayName("Card Fuel Prompt Code")]
    [IsoXmlTag("CardFuelPrmptCd")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public IsoMax1Number? CardFuelPromptCode { get; init; }

    /// <summary>
    /// Currently known as &quot;TransactionNumber&quot;. An identification code assigned by an agent.  This code can be used after applying for and awaiting the appropriate prompt value to be defined.
    /// </summary>
    [IsoId("_wQXeeRytEey6gI8SKlv7rg")]
    [DisplayName("Agent Fuel Prompt Code")]
    [IsoXmlTag("AgtFuelPrmptCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AgentFuelPromptCode { get; init; }

    /// <summary>
    /// Contains the details related to an individual trip.
    /// </summary>
    [IsoId("_wQXeexytEey6gI8SKlv7rg")]
    [DisplayName("Trip Information")]
    [IsoXmlTag("TripInf")]
    public TripInformation1? TripInformation { get; init; }

    /// <summary>
    /// Indicates the amenities available at the location where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_wQXefRytEey6gI8SKlv7rg")]
    [DisplayName("Local Amenity")]
    [IsoXmlTag("LclAmnty")]
    public ValueList<LocalAmenity1> LocalAmenity { get; init; } = [];

    /// <summary>
    /// Contains information related specifically to the transaction.
    /// </summary>
    [IsoId("_wQXefxytEey6gI8SKlv7rg")]
    [DisplayName("Transaction Related Data")]
    [IsoXmlTag("TxRltdData")]
    public ValueList<PaymentTransaction141> TransactionRelatedData { get; init; } = [];

    /// <summary>
    /// Contains additional fleet summary data.
    /// </summary>
    [IsoId("_wQXegRytEey6gI8SKlv7rg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalInformation19? AdditionalData { get; init; }
}
