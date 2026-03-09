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
/// Specifies how the supply chain shipping arrangements and the delivery of products and/or services as well as related documentation.
/// </summary>
[IsoId("_2ul9weWhEeevU7McUP3D1w")]
[DisplayName("Trade Delivery")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeDelivery3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Actual delivery period of the products and/or services.
    /// </summary>
    [IsoId("_23eM8eWhEeevU7McUP3D1w")]
    [DisplayName("Delivery Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryPrd")]
    #endif
    [IsoXmlTag("DlvryPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period14? DeliveryPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period14? DeliveryPeriod { get; init; } 
    #else
    public Period14? DeliveryPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Actual delivery date/time of the products and/or services.
    /// </summary>
    [IsoId("_23eM8-WhEeevU7McUP3D1w")]
    [DisplayName("Delivery Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryDtTm")]
    #endif
    [IsoXmlTag("DlvryDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DeliveryDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DeliveryDateTime { get; init; } 
    #else
    public System.DateTime? DeliveryDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Party from whom the goods are dispatched.
    /// </summary>
    [IsoId("_23eM9eWhEeevU7McUP3D1w")]
    [DisplayName("Ship From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipFr")]
    #endif
    [IsoXmlTag("ShipFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty4? ShipFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty4? ShipFrom { get; init; } 
    #else
    public TradeParty4? ShipFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_23eM9-WhEeevU7McUP3D1w")]
    [DisplayName("Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipTo")]
    #endif
    [IsoXmlTag("ShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty4? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty4? ShipTo { get; init; } 
    #else
    public TradeParty4? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Final party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_23eM-eWhEeevU7McUP3D1w")]
    [DisplayName("Ultimate Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtShipTo")]
    #endif
    [IsoXmlTag("UltmtShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty4? UltimateShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty4? UltimateShipTo { get; init; } 
    #else
    public TradeParty4? UltimateShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery note related to the delivery of the products and/or services.
    /// </summary>
    [IsoId("_23eM--WhEeevU7McUP3D1w")]
    [DisplayName("Delivery Note")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryNote")]
    #endif
    [IsoXmlTag("DlvryNote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? DeliveryNote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? DeliveryNote { get; init; } 
    #else
    public DocumentIdentification22? DeliveryNote { get; set; } 
    #endif
    
    /// <summary>
    /// Physical consolidation of goods for transport.
    /// </summary>
    [IsoId("_23eM_eWhEeevU7McUP3D1w")]
    [DisplayName("Consignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnmt")]
    #endif
    [IsoXmlTag("Consgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Consignment5? Consignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Consignment5? Consignment { get; init; } 
    #else
    public Consignment5? Consignment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
