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
namespace BeneficialStrategies.Iso20022.Choices.AssetHolding1Choice
{
    /// <summary>
    /// Mark-to-market pre-haircut value of other commodity collateral.
    /// </summary>
    [IsoId("_SUOCgBYIEeejf-cbr8l5qw")]
    [DisplayName("Commodity")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Commodity : AssetHolding1Choice_
    #else
    public partial class Commodity : AssetHolding1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Commodity instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Commodity( ActiveCurrencyAnd24Amount reqMarketValue,AssetClassDetailedSubProductType1Choice_ reqCommodityType )
        {
            MarketValue = reqMarketValue;
            CommodityType = reqCommodityType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Mark-to-market pre-haircut value.
        /// </summary>
        [IsoId("_0jm5cBYHEeejf-cbr8l5qw")]
        [DisplayName("Market Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MktVal")]
        #endif
        [IsoXmlTag("MktVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyAnd24Amount MarketValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ActiveCurrencyAnd24Amount MarketValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAnd24Amount MarketValue { get; init; } 
        #else
        public ActiveCurrencyAnd24Amount MarketValue { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the type of commodity.
        /// </summary>
        [IsoId("_6IEnkBYHEeejf-cbr8l5qw")]
        [DisplayName("Commodity Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CmmdtyTp")]
        #endif
        [IsoXmlTag("CmmdtyTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AssetClassDetailedSubProductType1Choice_ CommodityType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AssetClassDetailedSubProductType1Choice_ CommodityType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AssetClassDetailedSubProductType1Choice_ CommodityType { get; init; } 
        #else
        public AssetClassDetailedSubProductType1Choice_ CommodityType { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
