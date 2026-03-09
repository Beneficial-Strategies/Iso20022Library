// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_wKGeYRytEey6gI8SKlv7rg")]
[DisplayName("Fleet Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FleetSummary2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains driver-related information.
    /// </summary>
    [IsoId("_wQXecRytEey6gI8SKlv7rg")]
    [DisplayName("Driver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drvr")]
    #endif
    [IsoXmlTag("Drvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Driver2? Driver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Driver2? Driver { get; init; } 
    #else
    public Driver2? Driver { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle belonging to the fleet.
    /// </summary>
    [IsoId("_wQXecxytEey6gI8SKlv7rg")]
    [DisplayName("Vehicle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vhcl")]
    #endif
    [IsoXmlTag("Vhcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Vehicle5? Vehicle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Vehicle5? Vehicle { get; init; } 
    #else
    public Vehicle5? Vehicle { get; set; } 
    #endif
    
    /// <summary>
    /// Second card presented for the payment transaction.
    /// </summary>
    [IsoId("_wQXedRytEey6gI8SKlv7rg")]
    [DisplayName("Driver Or Vehicle Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrvrOrVhclCard")]
    #endif
    [IsoXmlTag("DrvrOrVhclCard")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlainCardData21? DriverOrVehicleCard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlainCardData21? DriverOrVehicleCard { get; init; } 
    #else
    public PlainCardData21? DriverOrVehicleCard { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not fuel or fleet data prompting should occur. 
    /// </summary>
    [IsoId("_wQXedxytEey6gI8SKlv7rg")]
    [DisplayName("Card Fuel Prompt Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardFuelPrmptCd")]
    #endif
    [IsoXmlTag("CardFuelPrmptCd")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1Number? CardFuelPromptCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? CardFuelPromptCode { get; init; } 
    #else
    public System.UInt64? CardFuelPromptCode { get; set; } 
    #endif
    
    /// <summary>
    /// Currently known as &quot;TransactionNumber&quot;. An identification code assigned by an agent.  This code can be used after applying for and awaiting the appropriate prompt value to be defined.
    /// </summary>
    [IsoId("_wQXeeRytEey6gI8SKlv7rg")]
    [DisplayName("Agent Fuel Prompt Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtFuelPrmptCd")]
    #endif
    [IsoXmlTag("AgtFuelPrmptCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AgentFuelPromptCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AgentFuelPromptCode { get; init; } 
    #else
    public System.String? AgentFuelPromptCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details related to an individual trip. 
    /// </summary>
    [IsoId("_wQXeexytEey6gI8SKlv7rg")]
    [DisplayName("Trip Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TripInf")]
    #endif
    [IsoXmlTag("TripInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TripInformation1? TripInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TripInformation1? TripInformation { get; init; } 
    #else
    public TripInformation1? TripInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the amenities available at the location where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_wQXefRytEey6gI8SKlv7rg")]
    [DisplayName("Local Amenity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclAmnty")]
    #endif
    [IsoXmlTag("LclAmnty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocalAmenity1? LocalAmenity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocalAmenity1? LocalAmenity { get; init; } 
    #else
    public LocalAmenity1? LocalAmenity { get; set; } 
    #endif
    
    /// <summary>
    /// Contains information related specifically to the transaction.
    /// </summary>
    [IsoId("_wQXefxytEey6gI8SKlv7rg")]
    [DisplayName("Transaction Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRltdData")]
    #endif
    [IsoXmlTag("TxRltdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction141? TransactionRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction141? TransactionRelatedData { get; init; } 
    #else
    public PaymentTransaction141? TransactionRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional fleet summary data.
    /// </summary>
    [IsoId("_wQXegRytEey6gI8SKlv7rg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation19? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation19? AdditionalData { get; init; } 
    #else
    public AdditionalInformation19? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
