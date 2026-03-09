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
[IsoId("_Ste39tp-Ed-ak6NoX_4Aeg_-1923970939")]
[DisplayName("Transport Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportDetails2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportDetails2( TransportMeans2 reqRoutingSummary,System.DateOnly reqProposedShipmentDate,System.DateOnly reqActualShipmentDate )
    {
        RoutingSummary = reqRoutingSummary;
        ProposedShipmentDate = reqProposedShipmentDate;
        ActualShipmentDate = reqActualShipmentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the identification of the underlying transport document.
    /// </summary>
    [IsoId("_Ste399p-Ed-ak6NoX_4Aeg_-1923970514")]
    [DisplayName("Transport Document Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtDocRef")]
    #endif
    [IsoXmlTag("TrnsprtDocRef")]
    public ValueList<DocumentIdentification7> TransportDocumentReference { get; init; } = new ValueList<DocumentIdentification7>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Ste399p-Ed-ak6NoX_4Aeg_-1923970514
    
    /// <summary>
    /// Goods that are transported.
    /// </summary>
    [IsoId("_Ste3-Np-Ed-ak6NoX_4Aeg_-1923969895")]
    [DisplayName("Transported Goods")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtdGoods")]
    #endif
    [IsoXmlTag("TrnsprtdGoods")]
    public ValueList<TransportedGoods1> TransportedGoods { get; init; } = new ValueList<TransportedGoods1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Ste3-Np-Ed-ak6NoX_4Aeg_-1923969895
    
    /// <summary>
    /// Physical packaging of goods for transport.
    /// </summary>
    [IsoId("_Ste3-dp-Ed-ak6NoX_4Aeg_-492454414")]
    [DisplayName("Consignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnmt")]
    #endif
    [IsoXmlTag("Consgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Consignment1? Consignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Consignment1? Consignment { get; init; } 
    #else
    public Consignment1? Consignment { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the conveyance of goods.
    /// </summary>
    [IsoId("_Stoo8Np-Ed-ak6NoX_4Aeg_-1923970164")]
    [DisplayName("Routing Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtgSummry")]
    #endif
    [IsoXmlTag("RtgSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransportMeans2 RoutingSummary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransportMeans2 RoutingSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportMeans2 RoutingSummary { get; init; } 
    #else
    public TransportMeans2 RoutingSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Proposed date on which the goods should be shipped.
    /// </summary>
    [IsoId("_Stoo8dp-Ed-ak6NoX_4Aeg_-1923970904")]
    [DisplayName("Proposed Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdShipmntDt")]
    #endif
    [IsoXmlTag("PropsdShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ProposedShipmentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ProposedShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ProposedShipmentDate { get; init; } 
    #else
    public System.DateOnly ProposedShipmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Actual date whereby the goods were shipped.
    /// </summary>
    [IsoId("_Stoo8tp-Ed-ak6NoX_4Aeg_-1923970627")]
    [DisplayName("Actual Shipment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActlShipmntDt")]
    #endif
    [IsoXmlTag("ActlShipmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ActualShipmentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ActualShipmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ActualShipmentDate { get; init; } 
    #else
    public System.DateOnly ActualShipmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_Stoo89p-Ed-ak6NoX_4Aeg_-1923970093")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms2? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms2? Incoterms { get; init; } 
    #else
    public Incoterms2? Incoterms { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the conveyance of goods.
    /// </summary>
    [IsoId("_Stoo9Np-Ed-ak6NoX_4Aeg_-1923969990")]
    [DisplayName("Freight Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrghtChrgs")]
    #endif
    [IsoXmlTag("FrghtChrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charge13? FreightCharges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charge13? FreightCharges { get; init; } 
    #else
    public Charge13? FreightCharges { get; set; } 
    #endif
    
    
    #nullable disable
    
}
