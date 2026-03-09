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
/// Source of funding
/// </summary>
[IsoId("_xJXl8EUUEeea-M6VZkEPUw")]
[DisplayName("Funding Source")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundingSource2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of source funding used to perform the transfer of funds.
    /// </summary>
    [IsoId("_GpSEIEUVEeea-M6VZkEPUw")]
    [DisplayName("Source Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcTp")]
    #endif
    [IsoXmlTag("SrcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundingSourceType2Code? SourceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundingSourceType2Code? SourceType { get; init; } 
    #else
    public FundingSourceType2Code? SourceType { get; set; } 
    #endif
    
    /// <summary>
    /// Any other type of funding source used to perform the transfer of funds.
    /// </summary>
    [IsoId("_21b7cEUVEeea-M6VZkEPUw")]
    [DisplayName("Other Source Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrSrcTp")]
    #endif
    [IsoXmlTag("OthrSrcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherSourceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherSourceType { get; init; } 
    #else
    public System.String? OtherSourceType { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the funding source.
    /// </summary>
    [IsoId("_8T0PsEUVEeea-M6VZkEPUw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
