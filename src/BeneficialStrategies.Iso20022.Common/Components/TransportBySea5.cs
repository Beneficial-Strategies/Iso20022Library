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
[IsoId("_IIXFodQxEeK0PPbKncCqzA")]
[DisplayName("Transport By Sea")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportBySea5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportBySea5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportBySea5( System.String reqPortOfLoading,System.String reqPortOfDischarge )
    {
        PortOfLoading = reqPortOfLoading;
        PortOfDischarge = reqPortOfDischarge;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the port where the goods are loaded on board the ship.
    /// </summary>
    [IsoId("_IjneQdQxEeK0PPbKncCqzA")]
    [DisplayName("Port Of Loading")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfLoadng")]
    #endif
    [IsoXmlTag("PortOfLoadng")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PortOfLoading { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PortOfLoading { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PortOfLoading { get; init; } 
    #else
    public System.String PortOfLoading { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the port where the goods are discharged.
    /// </summary>
    [IsoId("_IjneQ9QxEeK0PPbKncCqzA")]
    [DisplayName("Port Of Discharge")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PortOfDschrge")]
    #endif
    [IsoXmlTag("PortOfDschrge")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PortOfDischarge { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PortOfDischarge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PortOfDischarge { get; init; } 
    #else
    public System.String PortOfDischarge { get; set; } 
    #endif
    
    /// <summary>
    /// Name of a vessel.
    /// </summary>
    [IsoId("_IjneRdQxEeK0PPbKncCqzA")]
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
    [IsoId("_IjneR9QxEeK0PPbKncCqzA")]
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
    [IsoId("_AU6FgNQzEeK0PPbKncCqzA")]
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
    [IsoId("_RYdtINQzEeK0PPbKncCqzA")]
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
    [IsoId("_VRJ18NQzEeK0PPbKncCqzA")]
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
    
    /// <summary>
    /// Name of the master or captain of a vessel that signs the document for example, bill of lading, charter party bill of lading, non-negotiable sea waybill or multimodal transport document that evidences shipment of the goods from a port of loading to a port of discharge.
    /// </summary>
    [IsoId("_6GgNENQzEeK0PPbKncCqzA")]
    [DisplayName("Master Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrNm")]
    #endif
    [IsoXmlTag("MstrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? MasterName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterName { get; init; } 
    #else
    public System.String? MasterName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the company or individual that signs a charter party bill of lading that evidences shipment of the goods from a port of loading to a port of discharge and acts in the capacity of charterer.
    /// </summary>
    [IsoId("_AwsNINQ0EeK0PPbKncCqzA")]
    [DisplayName("Charterer Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrtrrNm")]
    #endif
    [IsoXmlTag("ChrtrrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ChartererName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ChartererName { get; init; } 
    #else
    public System.String? ChartererName { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the company or individual that signs a charter party bill of lading that evidences shipment of the goods from a port of loading to a port of discharge and acts in the capacity of owner;.
    /// </summary>
    [IsoId("_GBZRwNQ0EeK0PPbKncCqzA")]
    [DisplayName("Owner Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OwnrNm")]
    #endif
    [IsoXmlTag("OwnrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? OwnerName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OwnerName { get; init; } 
    #else
    public System.String? OwnerName { get; set; } 
    #endif
    
    /// <summary>
    /// International Maritime Organisation identification of a ship. The IMO identification number scheme was introduced in 1987 as a measure aimed at enhancing maritime safety and pollution prevention and to facilitate the prevention of maritime fraud. It assigns a permanent number to each vessel for identification purposes. This number remains unchanged upon transfer of the vessel to other flag(s) and is inserted in all vessel certificates. The IMO identification number is made up of the three letters &quot;IMO&quot; followed by a seven-digit number assigned to all vessels by IHS FairPlay (formerly known as Lloyd&apos;s Register-Fairplay). This is a unique seven digit number that is assigned to vessels and aids banks in determining whether a vessel is subject to an order that would not permit a bank to handle a certain transaction under local or international laws.
    /// </summary>
    [IsoId("_Xiw2wNQ0EeK0PPbKncCqzA")]
    [DisplayName("IMO Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IMONb")]
    #endif
    [IsoXmlTag("IMONb")]
    [IsoSimpleType(IsoSimpleType.Exact7NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact7NumericText? IMONumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IMONumber { get; init; } 
    #else
    public System.String? IMONumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the voyage by sea.
    /// </summary>
    [IsoId("_zjc3ABUyEeOCqpkCrPgk4g")]
    [DisplayName("Voyage Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VygNb")]
    #endif
    [IsoXmlTag("VygNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? VoyageNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? VoyageNumber { get; init; } 
    #else
    public System.String? VoyageNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
