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
[IsoId("_u9kHQbGYEeuSTr8k0UEM8A")]
[DisplayName("Shipment Attribute")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ShipmentAttribute2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Shipment conditions.
    /// </summary>
    [IsoId("_u-la8bGYEeuSTr8k0UEM8A")]
    [DisplayName("Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Conds")]
    #endif
    [IsoXmlTag("Conds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShipmentCondition1Choice_? Conditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentCondition1Choice_? Conditions { get; init; } 
    #else
    public ShipmentCondition1Choice_? Conditions { get; set; } 
    #endif
    
    /// <summary>
    /// Expected shipment date.
    /// </summary>
    [IsoId("_u-la87GYEeuSTr8k0UEM8A")]
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
    [IsoId("_u-la9bGYEeuSTr8k0UEM8A")]
    [DisplayName("Country Of Counter Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfCntrPty")]
    #endif
    [IsoXmlTag("CtryOfCntrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfCounterParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfCounterParty { get; init; } 
    #else
    public string? CountryOfCounterParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
