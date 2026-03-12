// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityCommodity7Choice
{
    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_Ul6y88gyEeuGrNSsxk3B0A")]
    [DisplayName("Commodity")]
    public partial record Commodity : SecurityCommodity7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies whether the values defined asset class commodity are matching or not.
        /// </summary>
        [IsoId("_zNicg8gyEeuGrNSsxk3B0A")]
        [DisplayName("Classification")]
        [IsoXmlTag("Clssfctn")]
        public CompareCommodityAssetClass3? Classification { get; init; } 
        
        /// <summary>
        /// Specifies whether the values defined as decimal number are matching or not.
        /// </summary>
        [IsoId("_zNichcgyEeuGrNSsxk3B0A")]
        [DisplayName("Quantity")]
        [IsoXmlTag("Qty")]
        public CompareDecimalNumber3? Quantity { get; init; } 
        
        /// <summary>
        /// Specifies whether the the unit prices are matching or not.
        /// </summary>
        [IsoId("_zNich8gyEeuGrNSsxk3B0A")]
        [DisplayName("Unit Price")]
        [IsoXmlTag("UnitPric")]
        public CompareUnitPrice6? UnitPrice { get; init; } 
        
        /// <summary>
        /// Specifies whether the values defined as active or historic currency and amount are matching or not.
        /// </summary>
        [IsoId("_zNicicgyEeuGrNSsxk3B0A")]
        [DisplayName("Market Value")]
        [IsoXmlTag("MktVal")]
        public CompareAmountAndDirection2? MarketValue { get; init; } 
        
        /// <summary>
        /// Specifies whether the values defined as unit of measure code are matching or not.
        /// </summary>
        [IsoId("_zNici8gyEeuGrNSsxk3B0A")]
        [DisplayName("Unit Of Measure")]
        [IsoXmlTag("UnitOfMeasr")]
        public CompareUnitOfMeasure3? UnitOfMeasure { get; init; } 
        
        
        #nullable disable
        
    }
}
