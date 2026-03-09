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
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument63Choice
{
    /// <summary>
    /// Identification of the cash asset.
    /// </summary>
    [IsoId("_nj5gM6PvEemf4IaGqCtquA")]
    [DisplayName("Cash Asset")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CashAsset : FinancialInstrument63Choice_
    #else
    public partial class CashAsset : FinancialInstrument63Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CashAsset instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CashAsset( CashAssetType1Choice_ reqCashAssetType,string reqHoldingCurrency )
        {
            CashAssetType = reqCashAssetType;
            HoldingCurrency = reqHoldingCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Type of cash asset.
        /// </summary>
        [IsoId("_UKrowaPvEemf4IaGqCtquA")]
        [DisplayName("Cash Asset Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshAsstTp")]
        #endif
        [IsoXmlTag("CshAsstTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CashAssetType1Choice_ CashAssetType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CashAssetType1Choice_ CashAssetType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAssetType1Choice_ CashAssetType { get; init; } 
        #else
        public CashAssetType1Choice_ CashAssetType { get; set; } 
        #endif
        
        /// <summary>
        /// Currency of the asset in the holding.
        /// </summary>
        [IsoId("_UKrow6PvEemf4IaGqCtquA")]
        [DisplayName("Holding Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HldgCcy")]
        #endif
        [IsoXmlTag("HldgCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyCode HoldingCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string HoldingCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string HoldingCurrency { get; init; } 
        #else
        public string HoldingCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Currency of the asset in another currency.
        /// </summary>
        [IsoId("_UKroxaPvEemf4IaGqCtquA")]
        [DisplayName("Transfer Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrfCcy")]
        #endif
        [IsoXmlTag("TrfCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyCode? TransferCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? TransferCurrency { get; init; } 
        #else
        public string? TransferCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the cash asset.
        /// </summary>
        [IsoId("_UKrox6PvEemf4IaGqCtquA")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        #else
        public AdditionalInformation15? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
