// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Extension to specify the stage in the corporate action event life cycle.
/// </summary>
[IsoId("_G3BX4DFpEeGKkIZzgd38VA")]
[DisplayName("Corporate Action Event Stage Format 4 SD")]
public partial record CorporateActionEventStageFormat4SD1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_qWadUFPGEeGs_NnqHXQZkw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// The number of securities purchased.
    /// The value should be the actual number, or 0 (if, as a result, TEND or BIDS will not take place).
    /// 買付株式数／未定／非設定
    /// ※買付前の通知において、「非設定」のデータが1件あり。未定との違いは不明。&quot;.
    /// </summary>
    [IsoId("_lJLu0DFpEeGKkIZzgd38VA")]
    [DisplayName("Securities Purchased")]
    [IsoXmlTag("SctiesPurchsd")]
    public required FinancialInstrumentQuantity15Choice_ SecuritiesPurchased { get; init; } 
    
    
    #nullable disable
    
}
