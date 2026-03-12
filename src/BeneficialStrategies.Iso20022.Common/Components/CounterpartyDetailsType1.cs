// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information of the counterparty in case of [sankaku] gappei (a third party is involved as one of the counterparties in the merger but there is no security movement from the third party).
/// </summary>
[IsoId("_01K7cGHNEeGknP6xAc4fKw")]
[DisplayName("Counterparty Details Type")]
public partial record CounterpartyDetailsType1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_Jd4r4GHOEeGknP6xAc4fKw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification15 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Classification of the Issuer or the Counterparty institution in case of a merger.
    /// 存続/消滅/親会社/子会社/未定の区分
    /// ※イベントタイプがMRGRの場合に、存続会社or消滅会社、親会社or子会社の通知を見分けるために必要。.
    /// </summary>
    [IsoId("_Xq3vAGHOEeGknP6xAc4fKw")]
    [DisplayName("Post Effective Date Classification")]
    [IsoXmlTag("PstFctvDtClssfctn")]
    public InstitutionalClassificationCode? PostEffectiveDateClassification { get; init; } 
    
    /// <summary>
    /// Abbreviated name of underlying securities in the local language.
    /// Note that in case of non-listed securities, it will be a full local language security name.
    /// 銘柄名（銘柄略称）.
    /// </summary>
    [IsoId("_2kS6QGHOEeGknP6xAc4fKw")]
    [DisplayName("Abbreviated Local Language Security Name")]
    [IsoXmlTag("AbbrvtdLclLangSctyNm")]
    [IsoSimpleType(IsoSimpleType.Max240Text)]
    [StringLength(maximumLength: 240 ,MinimumLength = 1)]
    public required IsoMax240Text AbbreviatedLocalLanguageSecurityName { get; init; } 
    
    
    #nullable disable
    
}
