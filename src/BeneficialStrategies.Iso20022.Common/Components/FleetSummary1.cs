// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_otojUPikEeiJaN6-Lf-c_w")]
[DisplayName("Fleet Summary")]
public partial record FleetSummary1
{
    #nullable enable
    
    /// <summary>
    /// Contains driver-related information.
    /// </summary>
    [IsoId("_otpKYPikEeiJaN6-Lf-c_w")]
    [DisplayName("Driver")]
    [IsoXmlTag("Drvr")]
    public Driver1? Driver { get; init; } 
    
    /// <summary>
    /// Vehicle belonging to the fleet.
    /// </summary>
    [IsoId("_otpKYfikEeiJaN6-Lf-c_w")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle5? Vehicle { get; init; } 
    
    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_8NRf8fixEeiJaN6-Lf-c_w")]
    [DisplayName("Driver Or Vehicle Card")]
    [IsoXmlTag("DrvrOrVhclCard")]
    public PlainCardData20? DriverOrVehicleCard { get; init; } 
    
    /// <summary>
    /// Indicates whether or not fuel or fleet data prompting should occur. 
    /// </summary>
    [IsoId("_rK5AMPi1EeiJaN6-Lf-c_w")]
    [DisplayName("Card Fuel Prompt Code")]
    [IsoXmlTag("CardFuelPrmptCd")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    public IsoMax1Number? CardFuelPromptCode { get; init; } 
    
    /// <summary>
    /// Currently known as &quot;TransactionNumber&quot;. An identification code assigned by an agent.  This code can be used after applying for and awaiting the appropriate prompt value to be defined.
    /// </summary>
    [IsoId("_QdgiIPi2EeiJaN6-Lf-c_w")]
    [DisplayName("Agent Fuel Prompt Code")]
    [IsoXmlTag("AgtFuelPrmptCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AgentFuelPromptCode { get; init; } 
    
    /// <summary>
    /// Contains the details related to an individual trip. 
    /// </summary>
    [IsoId("_MfuEoPi7EeiJaN6-Lf-c_w")]
    [DisplayName("Trip Information")]
    [IsoXmlTag("TripInf")]
    public TripInformation1? TripInformation { get; init; } 
    
    /// <summary>
    /// Indicates the amenities available at the location where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_lowBwPi_EeiJaN6-Lf-c_w")]
    [DisplayName("Local Amenity")]
    [IsoXmlTag("LclAmnty")]
    public LocalAmenity1? LocalAmenity { get; init; } 
    
    /// <summary>
    /// Contains information related specifically to the transaction.
    /// </summary>
    [IsoId("_GVZhUPjEEeiJaN6-Lf-c_w")]
    [DisplayName("Transaction Related Data")]
    [IsoXmlTag("TxRltdData")]
    public PaymentTransaction117? TransactionRelatedData { get; init; } 
    
    /// <summary>
    /// Contains additional fleet summary data.
    /// </summary>
    [IsoId("_2LjFsPi_EeiJaN6-Lf-c_w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalInformation19? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
