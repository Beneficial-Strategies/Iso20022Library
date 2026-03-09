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
/// Information related for the transportation of goods by sea.
/// </summary>
[IsoId("_WhO5YRriEeOVR9VN6fAMUg")]
[DisplayName("Transport By Sea")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportBySea6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_W4LZwRriEeOVR9VN6fAMUg")]
    [DisplayName("Port Of Loading")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfLoadng")]
    #endif
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PortOfLoading { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PortOfLoading { get; init; } 
    #else
    public System.String? PortOfLoading { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_W4LZwxriEeOVR9VN6fAMUg")]
    [DisplayName("Port Of Discharge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfDschrge")]
    #endif
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    public SimpleValueList<System.String> PortOfDischarge { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _W4LZwxriEeOVR9VN6fAMUg
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_zkY0kEUpEeOdq_w94HL6tQ")]
    [DisplayName("Vessel Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VsslNm")]
    #endif
    [IsoXmlTag("VsslNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? VesselName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VesselName { get; init; } 
    #else
    public System.String? VesselName { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party that is responsible for the conveyance of the goods from one place to another.
    /// </summary>
    [IsoId("_W4LZxxriEeOVR9VN6fAMUg")]
    [DisplayName("Sea Carrier Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeaCrrierNm")]
    #endif
    [IsoXmlTag("SeaCrrierNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SeaCarrierName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SeaCarrierName { get; init; } 
    #else
    public System.String? SeaCarrierName { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the carrier of the goods, for example, shipping company, is located or registered.
    /// </summary>
    [IsoId("_W4LZyRriEeOVR9VN6fAMUg")]
    [DisplayName("Sea Carrier Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeaCrrierCtry")]
    #endif
    [IsoXmlTag("SeaCrrierCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? SeaCarrierCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SeaCarrierCountry { get; init; } 
    #else
    public string? SeaCarrierCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_W4LZyxriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierAgtNm")]
    #endif
    [IsoXmlTag("CrrierAgtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CarrierAgentName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CarrierAgentName { get; init; } 
    #else
    public System.String? CarrierAgentName { get; set; } 
    #endif
    
    /// <summary>
    /// Country of registration of the carrier&apos;s (for example, shipping company&apos;s) agent that acts on behalf of the carrier and may be the issuer of transport documents relating to the underlying shipment.
    /// </summary>
    [IsoId("_W4LZzRriEeOVR9VN6fAMUg")]
    [DisplayName("Carrier Agent Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierAgtCtry")]
    #endif
    [IsoXmlTag("CrrierAgtCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CarrierAgentCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CarrierAgentCountry { get; init; } 
    #else
    public string? CarrierAgentCountry { get; set; } 
    #endif
    
    
    #nullable disable
    
}
