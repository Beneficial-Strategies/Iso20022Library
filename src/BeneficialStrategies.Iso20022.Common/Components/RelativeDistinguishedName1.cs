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
/// Relative distinguished name defined by X.500 and X.509.
/// </summary>
[IsoId("_Sw--ugEcEeCQm6a_G2yO_w_-2086938163")]
[DisplayName("Relative Distinguished Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RelativeDistinguishedName1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RelativeDistinguishedName1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RelativeDistinguishedName1( AttributeType1Code reqAttributeType,System.String reqAttributeValue )
    {
        AttributeType = reqAttributeType;
        AttributeValue = reqAttributeValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_Sw--uwEcEeCQm6a_G2yO_w_2126667271")]
    [DisplayName("Attribute Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttrTp")]
    #endif
    [IsoXmlTag("AttrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AttributeType1Code AttributeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AttributeType1Code AttributeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttributeType1Code AttributeType { get; init; } 
    #else
    public AttributeType1Code AttributeType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_Sw--vAEcEeCQm6a_G2yO_w_-1820514760")]
    [DisplayName("Attribute Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttrVal")]
    #endif
    [IsoXmlTag("AttrVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text AttributeValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AttributeValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AttributeValue { get; init; } 
    #else
    public System.String AttributeValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
