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
/// Information about a drawdown.
/// </summary>
[IsoId("_68-ZgXzoEeuEHsEB8Johfw")]
[DisplayName("Drawdown")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Drawdown3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Previous employment information.
    /// </summary>
    [IsoId("_7U2G83zoEeuEHsEB8Johfw")]
    [DisplayName("Employment Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MplymntDtls")]
    #endif
    [IsoXmlTag("MplymntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EmploymentDetails1? EmploymentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EmploymentDetails1? EmploymentDetails { get; init; } 
    #else
    public EmploymentDetails1? EmploymentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    [IsoId("_7U2HEXzoEeuEHsEB8Johfw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
