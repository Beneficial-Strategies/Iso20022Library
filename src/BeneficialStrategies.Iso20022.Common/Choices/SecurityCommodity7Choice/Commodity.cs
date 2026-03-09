// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.SecurityCommodity7Choice
{
    /// <summary>
    /// Data specific to commodities being subject to the transaction.
    /// </summary>
    [IsoId("_Ul6y88gyEeuGrNSsxk3B0A")]
    [DisplayName("Commodity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Commodity : SecurityCommodity7Choice_
    #else
    public partial class Commodity : SecurityCommodity7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies whether the values defined asset class commodity are matching or not.
        /// </summary>
        [IsoId("_zNicg8gyEeuGrNSsxk3B0A")]
        [DisplayName("Classification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Clssfctn")]
        #endif
        [IsoXmlTag("Clssfctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareCommodityAssetClass3? Classification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareCommodityAssetClass3? Classification { get; init; } 
        #else
        public CompareCommodityAssetClass3? Classification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as decimal number are matching or not.
        /// </summary>
        [IsoId("_zNichcgyEeuGrNSsxk3B0A")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareDecimalNumber3? Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareDecimalNumber3? Quantity { get; init; } 
        #else
        public CompareDecimalNumber3? Quantity { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the the unit prices are matching or not.
        /// </summary>
        [IsoId("_zNich8gyEeuGrNSsxk3B0A")]
        [DisplayName("Unit Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitPric")]
        #endif
        [IsoXmlTag("UnitPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareUnitPrice6? UnitPrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareUnitPrice6? UnitPrice { get; init; } 
        #else
        public CompareUnitPrice6? UnitPrice { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as active or historic currency and amount are matching or not.
        /// </summary>
        [IsoId("_zNicicgyEeuGrNSsxk3B0A")]
        [DisplayName("Market Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MktVal")]
        #endif
        [IsoXmlTag("MktVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareAmountAndDirection2? MarketValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareAmountAndDirection2? MarketValue { get; init; } 
        #else
        public CompareAmountAndDirection2? MarketValue { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as unit of measure code are matching or not.
        /// </summary>
        [IsoId("_zNici8gyEeuGrNSsxk3B0A")]
        [DisplayName("Unit Of Measure")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitOfMeasr")]
        #endif
        [IsoXmlTag("UnitOfMeasr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareUnitOfMeasure3? UnitOfMeasure { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareUnitOfMeasure3? UnitOfMeasure { get; init; } 
        #else
        public CompareUnitOfMeasure3? UnitOfMeasure { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
