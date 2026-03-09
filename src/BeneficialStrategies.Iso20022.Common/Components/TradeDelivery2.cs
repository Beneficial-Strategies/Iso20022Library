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
[IsoId("_3kwR0cNSEeWGDrnsYu2p6g")]
[DisplayName("Trade Delivery")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeDelivery2
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
    [IsoId("_3xZmscNSEeWGDrnsYu2p6g")]
    [DisplayName("Delivery Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryPrd")]
    #endif
    [IsoXmlTag("DlvryPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period1? DeliveryPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period1? DeliveryPeriod { get; init; } 
    #else
    public Period1? DeliveryPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Actual delivery date/time of the products and/or services.
    /// </summary>
    [IsoId("_3xZms8NSEeWGDrnsYu2p6g")]
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
    [IsoId("_3xZmtcNSEeWGDrnsYu2p6g")]
    [DisplayName("Ship From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipFr")]
    #endif
    [IsoXmlTag("ShipFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty3? ShipFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty3? ShipFrom { get; init; } 
    #else
    public TradeParty3? ShipFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_3xZmt8NSEeWGDrnsYu2p6g")]
    [DisplayName("Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipTo")]
    #endif
    [IsoXmlTag("ShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty3? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty3? ShipTo { get; init; } 
    #else
    public TradeParty3? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Final party to whom the goods are dispatched.
    /// </summary>
    [IsoId("_3xZmucNSEeWGDrnsYu2p6g")]
    [DisplayName("Ultimate Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtShipTo")]
    #endif
    [IsoXmlTag("UltmtShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty3? UltimateShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty3? UltimateShipTo { get; init; } 
    #else
    public TradeParty3? UltimateShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Delivery note related to the delivery of the products and/or services.
    /// </summary>
    [IsoId("_3xZmu8NSEeWGDrnsYu2p6g")]
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
    [IsoId("_3xZmvcNSEeWGDrnsYu2p6g")]
    [DisplayName("Consignment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnmt")]
    #endif
    [IsoXmlTag("Consgnmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Consignment4? Consignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Consignment4? Consignment { get; init; } 
    #else
    public Consignment4? Consignment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
