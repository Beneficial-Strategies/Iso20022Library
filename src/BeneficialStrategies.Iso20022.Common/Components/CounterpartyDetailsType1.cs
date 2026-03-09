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
/// Information of the counterparty in case of [sankaku] gappei (a third party is involved as one of the counterparties in the merger but there is no security movement from the third party).
/// </summary>
[IsoId("_01K7cGHNEeGknP6xAc4fKw")]
[DisplayName("Counterparty Details Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CounterpartyDetailsType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CounterpartyDetailsType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CounterpartyDetailsType1( SecurityIdentification15 reqFinancialInstrumentIdentification,System.String reqAbbreviatedLocalLanguageSecurityName )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        AbbreviatedLocalLanguageSecurityName = reqAbbreviatedLocalLanguageSecurityName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_Jd4r4GHOEeGknP6xAc4fKw")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification15 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification15 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification15 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification15 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the Issuer or the Counterparty institution in case of a merger.
    /// 存続/消滅/親会社/子会社/未定の区分
    /// ※イベントタイプがMRGRの場合に、存続会社or消滅会社、親会社or子会社の通知を見分けるために必要。.
    /// </summary>
    [IsoId("_Xq3vAGHOEeGknP6xAc4fKw")]
    [DisplayName("Post Effective Date Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstFctvDtClssfctn")]
    #endif
    [IsoXmlTag("PstFctvDtClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstitutionalClassificationCode? PostEffectiveDateClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstitutionalClassificationCode? PostEffectiveDateClassification { get; init; } 
    #else
    public InstitutionalClassificationCode? PostEffectiveDateClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Abbreviated name of underlying securities in the local language.
    /// Note that in case of non-listed securities, it will be a full local language security name.
    /// 銘柄名（銘柄略称）.
    /// </summary>
    [IsoId("_2kS6QGHOEeGknP6xAc4fKw")]
    [DisplayName("Abbreviated Local Language Security Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AbbrvtdLclLangSctyNm")]
    #endif
    [IsoXmlTag("AbbrvtdLclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax240Text AbbreviatedLocalLanguageSecurityName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AbbreviatedLocalLanguageSecurityName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AbbreviatedLocalLanguageSecurityName { get; init; } 
    #else
    public System.String AbbreviatedLocalLanguageSecurityName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
