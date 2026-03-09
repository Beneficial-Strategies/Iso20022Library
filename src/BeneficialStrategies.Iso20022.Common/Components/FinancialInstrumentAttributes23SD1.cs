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
/// Extension for UnderlyingSecurity.
/// </summary>
[IsoId("_7_9PY1IwEeGxk_7PmgdPEg")]
[DisplayName("Financial Instrument Attributes 23 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributes23SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributes23SD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributes23SD1( InstitutionalClassificationCode reqPostEffectiveDateClassification )
    {
        PostEffectiveDateClassification = reqPostEffectiveDateClassification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_0mZxUFPEEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the Issuer or the Counterparty institution in case of a merger.
    /// 存続/消滅/親会社/子会社/未定の区分
    /// ※イベントタイプがMRGRの場合に、存続会社or消滅会社、親会社or子会社の通知を見分けるために必要。.
    /// </summary>
    [IsoId("_ll5nsFIxEeGxk_7PmgdPEg")]
    [DisplayName("Post Effective Date Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstFctvDtClssfctn")]
    #endif
    [IsoXmlTag("PstFctvDtClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstitutionalClassificationCode PostEffectiveDateClassification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstitutionalClassificationCode PostEffectiveDateClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstitutionalClassificationCode PostEffectiveDateClassification { get; init; } 
    #else
    public InstitutionalClassificationCode PostEffectiveDateClassification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
