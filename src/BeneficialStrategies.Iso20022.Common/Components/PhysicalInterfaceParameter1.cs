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
/// Configuration parameters for physical interface.
/// </summary>
[IsoId("_jVcYQNqfEeearpaEPXv9UA")]
[DisplayName("Physical Interface Parameter")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PhysicalInterfaceParameter1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PhysicalInterfaceParameter1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PhysicalInterfaceParameter1( System.String reqInterfaceName )
    {
        InterfaceName = reqInterfaceName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the interface.
    /// </summary>
    [IsoId("_-ROCMNqfEeearpaEPXv9UA")]
    [DisplayName("Interface Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrfcNm")]
    #endif
    [IsoXmlTag("IntrfcNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InterfaceName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InterfaceName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InterfaceName { get; init; } 
    #else
    public System.String InterfaceName { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the physical link layer.
    /// </summary>
    [IsoId("_IBxWQNqgEeearpaEPXv9UA")]
    [DisplayName("Interface Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrfcTp")]
    #endif
    [IsoXmlTag("IntrfcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public POICommunicationType2Code? InterfaceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public POICommunicationType2Code? InterfaceType { get; init; } 
    #else
    public POICommunicationType2Code? InterfaceType { get; set; } 
    #endif
    
    /// <summary>
    /// Optional user name to provide to use this interface.
    /// </summary>
    [IsoId("_SCt2wNqgEeearpaEPXv9UA")]
    [DisplayName("User Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrNm")]
    #endif
    [IsoXmlTag("UsrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? UserName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UserName { get; init; } 
    #else
    public System.String? UserName { get; set; } 
    #endif
    
    /// <summary>
    /// Optional access code to provide to use this interface.
    /// </summary>
    [IsoId("_ZFeH0NqgEeearpaEPXv9UA")]
    [DisplayName("Access Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccsCd")]
    #endif
    [IsoXmlTag("AccsCd")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? AccessCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AccessCode { get; init; } 
    #else
    public System.Byte[]? AccessCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the optional security profile to use with this interface.
    /// </summary>
    [IsoId("_f-XSQNqgEeearpaEPXv9UA")]
    [DisplayName("Security Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyPrfl")]
    #endif
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecurityProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityProfile { get; init; } 
    #else
    public System.String? SecurityProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Any other parameters relevant for this interface.
    /// </summary>
    [IsoId("_qB5zwNqgEeearpaEPXv9UA")]
    [DisplayName("Additional Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlParams")]
    #endif
    [IsoXmlTag("AddtlParams")]
    [IsoSimpleType(IsoSimpleType.Max2KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2KBinary? AdditionalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AdditionalParameters { get; init; } 
    #else
    public System.Byte[]? AdditionalParameters { get; set; } 
    #endif
    
    
    #nullable disable
    
}
