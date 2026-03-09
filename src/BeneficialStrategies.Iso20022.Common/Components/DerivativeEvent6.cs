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
/// Information related to derivative details.
/// </summary>
[IsoId("_lk8TIfbeEeyInphUKJZxtQ")]
[DisplayName("Derivative Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeEvent6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of derivative event type.
    /// </summary>
    [IsoId("_llrS8fbeEeyInphUKJZxtQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeEventType3Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeEventType3Code? Type { get; init; } 
    #else
    public DerivativeEventType3Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates means of identification of a derivative event.
    /// </summary>
    [IsoId("_jf75APbfEeyInphUKJZxtQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventIdentifier1Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventIdentifier1Choice_? Identification { get; init; } 
    #else
    public EventIdentifier1Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the time stamp of a derivative event.
    /// </summary>
    [IsoId("_llrS9fbeEeyInphUKJZxtQ")]
    [DisplayName("Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmStmp")]
    #endif
    [IsoXmlTag("TmStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? TimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? TimeStamp { get; init; } 
    #else
    public DateAndDateTime2Choice_? TimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator of whether the modification of the swap transaction reflects newly agreed upon term(s) from the previously negotiated terms resulting in price forming event.
    /// Usage: When absent, meaning of AmendmentIndicator is False.
    /// </summary>
    [IsoId("_x7bUoTNYEe2Mjc1DeLmBZw")]
    [DisplayName("Amendment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntInd")]
    #endif
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AmendmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmendmentIndicator { get; init; } 
    #else
    public System.String? AmendmentIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
