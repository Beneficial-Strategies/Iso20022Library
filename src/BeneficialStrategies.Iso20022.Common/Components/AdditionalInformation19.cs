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
/// Additional information relevant to the destination.
/// </summary>
[IsoId("_EkHNFf2qEeiS2rs-hXBB5Q")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Key-entered numeric data.
    /// </summary>
    [IsoId("_EkHNGf2qEeiS2rs-hXBB5Q")]
    [DisplayName("Entered Data Numeric")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtrdDataNmrc")]
    #endif
    [IsoXmlTag("NtrdDataNmrc")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? EnteredDataNumeric { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EnteredDataNumeric { get; init; } 
    #else
    public System.String? EnteredDataNumeric { get; set; } 
    #endif
    
    /// <summary>
    /// Key-entered alphanumeric data.
    /// </summary>
    [IsoId("_UZ4L4P2qEeiS2rs-hXBB5Q")]
    [DisplayName("Entered Data Alpha Numeric")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtrdDataAlphaNmrc")]
    #endif
    [IsoXmlTag("NtrdDataAlphaNmrc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? EnteredDataAlphaNumeric { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EnteredDataAlphaNumeric { get; init; } 
    #else
    public System.String? EnteredDataAlphaNumeric { get; set; } 
    #endif
    
    /// <summary>
    /// Additional fleet summary data. 
    /// </summary>
    [IsoId("_W13GIP2qEeiS2rs-hXBB5Q")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
