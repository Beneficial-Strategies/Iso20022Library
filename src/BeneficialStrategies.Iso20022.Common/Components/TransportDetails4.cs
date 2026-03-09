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
/// Information on the shipment date, the charges, the routing and the goods described in the transport document.
/// </summary>
[IsoId("_2ZcofzckEeSaC-PiOaz_KQ")]
[DisplayName("Transport Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportDetails4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportDetails4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportDetails4( TransportMeans6 reqRoutingSummary,ShipmentDate1Choice_ reqShipmentDate )
    {
        RoutingSummary = reqRoutingSummary;
        ShipmentDate = reqShipmentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying transport document.
    /// </summary>
    [IsoId("_2vnswTckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport Document Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtDocRef")]
    #endif
    [IsoXmlTag("TrnsprtDocRef")]
    public ValueList<DocumentIdentification7> TransportDocumentReference { get; init; } = new ValueList<DocumentIdentification7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2vnswTckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Goods that are transported.
    /// </summary>
    [IsoId("_2vnswzckEeSaC-PiOaz_KQ")]
    [DisplayName("Transported Goods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtdGoods")]
    #endif
    [IsoXmlTag("TrnsprtdGoods")]
    public ValueList<TransportedGoods1> TransportedGoods { get; init; } = new ValueList<TransportedGoods1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2vnswzckEeSaC-PiOaz_KQ
    
    /// <summary>
    /// Physical packaging of goods for transport.
    /// </summary>
    [IsoId("_2vnsxTckEeSaC-PiOaz_KQ")]
    [DisplayName("Consignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnmt")]
    #endif
    [IsoXmlTag("Consgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Consignment3? Consignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Consignment3? Consignment { get; init; } 
    #else
    public Consignment3? Consignment { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_2vnsxzckEeSaC-PiOaz_KQ")]
    [DisplayName("Routing Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtgSummry")]
    #endif
    [IsoXmlTag("RtgSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransportMeans6 RoutingSummary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransportMeans6 RoutingSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportMeans6 RoutingSummary { get; init; } 
    #else
    public TransportMeans6 RoutingSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Shipment date, actual or proposed.
    /// </summary>
    [IsoId("_2vnsyTckEeSaC-PiOaz_KQ")]
    [DisplayName("Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipmntDt")]
    #endif
    [IsoXmlTag("ShipmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShipmentDate1Choice_ ShipmentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShipmentDate1Choice_ ShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentDate1Choice_ ShipmentDate { get; init; } 
    #else
    public ShipmentDate1Choice_ ShipmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_2vnsyzckEeSaC-PiOaz_KQ")]
    [DisplayName("Freight Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtChrgs")]
    #endif
    [IsoXmlTag("FrghtChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge25? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge25? FreightCharges { get; init; } 
    #else
    public Charge25? FreightCharges { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_2vnszTckEeSaC-PiOaz_KQ")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms4? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms4? Incoterms { get; init; } 
    #else
    public Incoterms4? Incoterms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
