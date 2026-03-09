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
namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData14Choice
{
    /// <summary>
    /// Data on collateral used for the buy sell back transaction.
    /// </summary>
    [IsoId("_kyCmM__9Eemefbt-QjTNnA")]
    [DisplayName("Buy Sell Back")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BuySellBack : TransactionCollateralData14Choice_
    #else
    public partial class BuySellBack : TransactionCollateralData14Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
        /// </summary>
        [IsoId("_k2Zhwf_9Eemefbt-QjTNnA")]
        [DisplayName("Collateral Value Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollValDt")]
        #endif
        [IsoXmlTag("CollValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? CollateralValueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? CollateralValueDate { get; init; } 
        #else
        public System.DateOnly? CollateralValueDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication of the type of collateral component.
        /// </summary>
        [IsoId("_k2Zhw__9Eemefbt-QjTNnA")]
        [DisplayName("Asset Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AsstTp")]
        #endif
        [IsoXmlTag("AsstTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralType14? AssetType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralType14? AssetType { get; init; } 
        #else
        public CollateralType14? AssetType { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
        /// </summary>
        [IsoId("_k2Zhxf_9Eemefbt-QjTNnA")]
        [DisplayName("Net Exposure Collateralisation Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NetXpsrCollstnInd")]
        #endif
        [IsoXmlTag("NetXpsrCollstnInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? NetExposureCollateralisationIndicator { get; init; } 
        #else
        public System.String? NetExposureCollateralisationIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the collateral basket.
        /// </summary>
        [IsoId("_k2Zhx__9Eemefbt-QjTNnA")]
        [DisplayName("Basket Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BsktIdr")]
        #endif
        [IsoXmlTag("BsktIdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
        #else
        public SecurityIdentification26Choice_? BasketIdentifier { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
