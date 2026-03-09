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
/// Provides constrains on a range of business values.
/// </summary>
[IsoId("_MVJmYZJOEeuAlLVx8pyt3w")]
[DisplayName("Amount Or Percentage Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountOrPercentageRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication of the relationship between two variables.
    /// </summary>
    [IsoId("_MXgV8ZJOEeuAlLVx8pyt3w")]
    [DisplayName("Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Opr")]
    #endif
    [IsoXmlTag("Opr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Operation1Code? Operation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Operation1Code? Operation { get; init; } 
    #else
    public Operation1Code? Operation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates one of the constraints of a range of business values.
    /// </summary>
    [IsoId("_MXgV85JOEeuAlLVx8pyt3w")]
    [DisplayName("Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Term")]
    #endif
    [IsoXmlTag("Term")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Term1> Term { get; init; } = new ValueList<Term1>(){};
    
    
    #nullable disable
    
}
