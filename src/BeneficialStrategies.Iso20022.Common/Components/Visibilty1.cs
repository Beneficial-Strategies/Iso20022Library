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
/// Specifies the details of the visibility of the creditor enrolment as shown to the debtors.
/// </summary>
[IsoId("_FnUAsEWOEempSe_3C1a9EQ")]
[DisplayName("Visibilty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Visibilty1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Start date when the information will be shown to the debtors.
    /// </summary>
    [IsoId("_NQ95sEWOEempSe_3C1a9EQ")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? StartDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// End date when the information will be shown to the debtors.
    /// </summary>
    [IsoId("_RliGMEWOEempSe_3C1a9EQ")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EndDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the information is shown to the debtors or not.
    /// Usage: when absent, the default value is no limited visibility (false).
    /// </summary>
    [IsoId("_cjMGkEWOEempSe_3C1a9EQ")]
    [DisplayName("Limited Visibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdVsblty")]
    #endif
    [IsoXmlTag("LtdVsblty")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LimitedVisibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedVisibility { get; init; } 
    #else
    public System.String? LimitedVisibility { get; set; } 
    #endif
    
    
    #nullable disable
    
}
