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
/// Information about the journey before or after the rental.
/// </summary>
[IsoId("_fEn7AF1mEeeu75xdwwAXQw")]
[DisplayName("Journey Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record JourneyInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of journey.
    /// </summary>
    [IsoId("_vnTDIF1mEeeu75xdwwAXQw")]
    [DisplayName("Journey Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JrnyTp")]
    #endif
    [IsoXmlTag("JrnyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public JourneyType1Code? JourneyType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public JourneyType1Code? JourneyType { get; init; } 
    #else
    public JourneyType1Code? JourneyType { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the type of journey selected (for example, AF1234 when FlightNumber selected).
    /// </summary>
    [IsoId("_-v9rYF1mEeeu75xdwwAXQw")]
    [DisplayName("Journey Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JrnyData")]
    #endif
    [IsoXmlTag("JrnyData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? JourneyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? JourneyData { get; init; } 
    #else
    public System.String? JourneyData { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time related to the journey type selected.
    /// </summary>
    [IsoId("_dQ-EsF1pEeeu75xdwwAXQw")]
    [DisplayName("Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtAndTm")]
    #endif
    [IsoXmlTag("DtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DateAndTime { get; init; } 
    #else
    public System.DateTime? DateAndTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
