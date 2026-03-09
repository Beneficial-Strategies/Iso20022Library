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
/// Complete name of the cardholder.
/// </summary>
[IsoId("_s6MQgcriEeuQjLd-KKZrCg")]
[DisplayName("Cardholder Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderName3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the cardholder, which is usually the full name.
    /// </summary>
    [IsoId("_s_YSgcriEeuQjLd-KKZrCg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_s_Y5kcriEeuQjLd-KKZrCg")]
    [DisplayName("Given Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvnNm")]
    #endif
    [IsoXmlTag("GvnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? GivenName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GivenName { get; init; } 
    #else
    public System.String? GivenName { get; set; } 
    #endif
    
    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_s_Y5k8riEeuQjLd-KKZrCg")]
    [DisplayName("Middle Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MddlNm")]
    #endif
    [IsoXmlTag("MddlNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MiddleName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MiddleName { get; init; } 
    #else
    public System.String? MiddleName { get; set; } 
    #endif
    
    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_s_Y5lcriEeuQjLd-KKZrCg")]
    [DisplayName("Last Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastNm")]
    #endif
    [IsoXmlTag("LastNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LastName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LastName { get; init; } 
    #else
    public System.String? LastName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
