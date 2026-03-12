// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension for UnderlyingSecurity.
/// </summary>
[IsoId("_7_9PY1IwEeGxk_7PmgdPEg")]
[DisplayName("Financial Instrument Attributes 23 SD")]
public partial record FinancialInstrumentAttributes23SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_0mZxUFPEEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Classification of the Issuer or the Counterparty institution in case of a merger.
    /// 存続/消滅/親会社/子会社/未定の区分
    /// ※イベントタイプがMRGRの場合に、存続会社or消滅会社、親会社or子会社の通知を見分けるために必要。.
    /// </summary>
    [IsoId("_ll5nsFIxEeGxk_7PmgdPEg")]
    [DisplayName("Post Effective Date Classification")]
    [IsoXmlTag("PstFctvDtClssfctn")]
    public required InstitutionalClassificationCode PostEffectiveDateClassification { get; init; } 
    
    
    #nullable disable
    
}
