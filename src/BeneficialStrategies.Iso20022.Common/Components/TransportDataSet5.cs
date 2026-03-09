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
/// Provides details on the transportation of goods that are part of a commercial trade agreement.
/// </summary>
[IsoId("_2DIaMTckEeSaC-PiOaz_KQ")]
[DisplayName("Transport Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransportDataSet5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransportDataSet5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransportDataSet5( DocumentIdentification1 reqDataSetIdentification,PartyIdentification26 reqConsignor,TransportDetails4 reqTransportInformation )
    {
        DataSetIdentification = reqDataSetIdentification;
        Consignor = reqConsignor;
        TransportInformation = reqTransportInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the submitted transport data set.
    /// </summary>
    [IsoId("_2ZcocTckEeSaC-PiOaz_KQ")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 DataSetIdentification { get; init; } 
    #else
    public DocumentIdentification1 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_2ZcoczckEeSaC-PiOaz_KQ")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Buyer { get; init; } 
    #else
    public PartyIdentification26? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_2ZcodTckEeSaC-PiOaz_KQ")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Seller { get; init; } 
    #else
    public PartyIdentification26? Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_2ZcodzckEeSaC-PiOaz_KQ")]
    [DisplayName("Consignor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnr")]
    #endif
    [IsoXmlTag("Consgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Consignor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Consignor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Consignor { get; init; } 
    #else
    public PartyIdentification26 Consignor { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods must be delivered.
    /// </summary>
    [IsoId("_2ZcoeTckEeSaC-PiOaz_KQ")]
    [DisplayName("Consignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgn")]
    #endif
    [IsoXmlTag("Consgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Consignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Consignee { get; init; } 
    #else
    public PartyIdentification26? Consignee { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods must be delivered in the end.
    /// </summary>
    [IsoId("_2ZcoezckEeSaC-PiOaz_KQ")]
    [DisplayName("Ship To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipTo")]
    #endif
    [IsoXmlTag("ShipTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? ShipTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? ShipTo { get; init; } 
    #else
    public PartyIdentification26? ShipTo { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the shipment date, the charges, the routing and the goods that are described in the transport document.
    /// </summary>
    [IsoId("_2ZcofTckEeSaC-PiOaz_KQ")]
    [DisplayName("Transport Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsprtInf")]
    #endif
    [IsoXmlTag("TrnsprtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransportDetails4 TransportInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransportDetails4 TransportInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransportDetails4 TransportInformation { get; init; } 
    #else
    public TransportDetails4 TransportInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
