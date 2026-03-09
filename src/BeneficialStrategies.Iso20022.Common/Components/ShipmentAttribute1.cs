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
/// Further details on the shipment conditions.
/// </summary>
[IsoId("_wGRaAdM_EeSDLevdaFPXHw")]
[DisplayName("Shipment Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShipmentAttribute1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ShipmentAttribute1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ShipmentAttribute1( string reqCountryOfCounterParty )
    {
        CountryOfCounterParty = reqCountryOfCounterParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Shipment conditions.
    /// </summary>
    [IsoId("_6NKKcNM_EeSDLevdaFPXHw")]
    [DisplayName("Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Conds")]
    #endif
    [IsoXmlTag("Conds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalShipmentCondition1Code? Conditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalShipmentCondition1Code? Conditions { get; init; } 
    #else
    public ExternalShipmentCondition1Code? Conditions { get; set; } 
    #endif
    
    /// <summary>
    /// Expected shipment date.
    /// </summary>
    [IsoId("_-CyYMNM_EeSDLevdaFPXHw")]
    [DisplayName("Expected Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdDt")]
    #endif
    [IsoXmlTag("XpctdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpectedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpectedDate { get; init; } 
    #else
    public System.DateOnly? ExpectedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the counter party is located.
    /// </summary>
    [IsoId("_ibf2oNNAEeSDLevdaFPXHw")]
    [DisplayName("Country Of Counter Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfCntrPty")]
    #endif
    [IsoXmlTag("CtryOfCntrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode CountryOfCounterParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CountryOfCounterParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CountryOfCounterParty { get; init; } 
    #else
    public string CountryOfCounterParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
