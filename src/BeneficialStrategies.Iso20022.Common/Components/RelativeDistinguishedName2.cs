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
/// Attribute of the certificate service to be put in the certificate extensions, or to be used for the request.
/// </summary>
[IsoId("_W-n0EY4TEeW6h7rGyYlyTg")]
[DisplayName("Relative Distinguished Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RelativeDistinguishedName2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RelativeDistinguishedName2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RelativeDistinguishedName2( AttributeType2Code reqAttributeType,System.String reqAttributeValue )
    {
        AttributeType = reqAttributeType;
        AttributeValue = reqAttributeValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_XKBLwY4TEeW6h7rGyYlyTg")]
    [DisplayName("Attribute Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttrTp")]
    #endif
    [IsoXmlTag("AttrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AttributeType2Code AttributeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AttributeType2Code AttributeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttributeType2Code AttributeType { get; init; } 
    #else
    public AttributeType2Code AttributeType { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_XKBLw44TEeW6h7rGyYlyTg")]
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
