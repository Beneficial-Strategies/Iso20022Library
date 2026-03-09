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
/// ATM terminal equipment.
/// </summary>
[IsoId("_eqOMIIn8EeShMpas3885ww")]
[DisplayName("ATM Equipment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMEquipment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// ATM Manufacturer.
    /// </summary>
    [IsoId("_mJCHEIn8EeShMpas3885ww")]
    [DisplayName("Manufacturer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Manfctr")]
    #endif
    [IsoXmlTag("Manfctr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Manufacturer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Manufacturer { get; init; } 
    #else
    public System.String? Manufacturer { get; set; } 
    #endif
    
    /// <summary>
    /// Model of ATM.
    /// </summary>
    [IsoId("_pkwnEIn8EeShMpas3885ww")]
    [DisplayName("Model")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mdl")]
    #endif
    [IsoXmlTag("Mdl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Model { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Model { get; init; } 
    #else
    public System.String? Model { get; set; } 
    #endif
    
    /// <summary>
    /// Serial number of the ATM.
    /// </summary>
    [IsoId("_sqRmgIn8EeShMpas3885ww")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerialNumber { get; init; } 
    #else
    public System.String? SerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Provider of the ATM application software.
    /// </summary>
    [IsoId("_vW_EYIn8EeShMpas3885ww")]
    [DisplayName("Application Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplPrvdr")]
    #endif
    [IsoXmlTag("ApplPrvdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationProvider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationProvider { get; init; } 
    #else
    public System.String? ApplicationProvider { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the software product.
    /// </summary>
    [IsoId("_yIPrEIn8EeShMpas3885ww")]
    [DisplayName("Application Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplNm")]
    #endif
    [IsoXmlTag("ApplNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationName { get; init; } 
    #else
    public System.String? ApplicationName { get; set; } 
    #endif
    
    /// <summary>
    /// Current version of the software that might include the release number.
    /// </summary>
    [IsoId("_1TiiYIn8EeShMpas3885ww")]
    [DisplayName("Application Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApplVrsn")]
    #endif
    [IsoXmlTag("ApplVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApplicationVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApplicationVersion { get; init; } 
    #else
    public System.String? ApplicationVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Unique assessment number for the component.
    /// </summary>
    [IsoId("_4CQycIn8EeShMpas3885ww")]
    [DisplayName("Approval Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvlNb")]
    #endif
    [IsoXmlTag("ApprvlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ApprovalNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ApprovalNumber { get; init; } 
    #else
    public System.String? ApprovalNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameter version.
    /// </summary>
    [IsoId("_fAK8EIn-EeShMpas3885ww")]
    [DisplayName("Configuration Parameter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CfgtnParam")]
    #endif
    [IsoXmlTag("CfgtnParam")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMConfigurationParameter1? ConfigurationParameter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMConfigurationParameter1? ConfigurationParameter { get; init; } 
    #else
    public ATMConfigurationParameter1? ConfigurationParameter { get; set; } 
    #endif
    
    
    #nullable disable
    
}
