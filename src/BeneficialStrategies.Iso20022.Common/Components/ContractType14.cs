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
/// Information related to contract attributes.
/// </summary>
[IsoId("_k5ZioWEUEe2P-L9DBerEgA")]
[DisplayName("Contract Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractType14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_k6RFUWEUEe2P-L9DBerEgA")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #else
    public FinancialInstrumentContractType2Code? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_k6RFU2EUEe2P-L9DBerEgA")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductType4Code? AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType4Code? AssetClass { get; init; } 
    #else
    public ProductType4Code? AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    [IsoId("_k6RFVWEUEe2P-L9DBerEgA")]
    [DisplayName("Product Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctClssfctn")]
    #endif
    [IsoXmlTag("PdctClssfctn")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ProductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductClassification { get; init; } 
    #else
    public System.String? ProductClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    [IsoId("_k6RFWWEUEe2P-L9DBerEgA")]
    [DisplayName("Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctId")]
    #endif
    [IsoXmlTag("PdctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification46? ProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification46? ProductIdentification { get; init; } 
    #else
    public SecurityIdentification46? ProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_k6RFW2EUEe2P-L9DBerEgA")]
    [DisplayName("Underlying Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrm")]
    #endif
    [IsoXmlTag("UndrlygInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification41Choice_? UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification41Choice_? UnderlyingInstrument { get; init; } 
    #else
    public SecurityIdentification41Choice_? UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency to be used for cash settlement of the transaction. 
    /// Usage: For multicurrency transactions that do not net, SettlementCurrency is to be considered as the first leg.
    /// </summary>
    [IsoId("_k6RFXWEUEe2P-L9DBerEgA")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange23? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange23? SettlementCurrency { get; init; } 
    #else
    public CurrencyExchange23? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency second leg to be used for cash settlement of the transaction. 
    /// </summary>
    [IsoId("_k6RFX2EUEe2P-L9DBerEgA")]
    [DisplayName("Settlement Currency Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcyScndLeg")]
    #endif
    [IsoXmlTag("SttlmCcyScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange23? SettlementCurrencySecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange23? SettlementCurrencySecondLeg { get; init; } 
    #else
    public CurrencyExchange23? SettlementCurrencySecondLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the place where settlement of the transaction occurs as stipulated in the contract.
    /// </summary>
    [IsoId("_k6RFYWEUEe2P-L9DBerEgA")]
    [DisplayName("Place Of Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlm")]
    #endif
    [IsoXmlTag("PlcOfSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfSettlement { get; init; } 
    #else
    public string? PlaceOfSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator whether the derivative is based on crypto-asset.
    /// Usage: If the element is not present, the DerivativeBasedOnCryptoAsset is False.
    /// </summary>
    [IsoId("_k6RFY2EUEe2P-L9DBerEgA")]
    [DisplayName("Derivative Based On Crypto Asset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivBasedOnCrptAsst")]
    #endif
    [IsoXmlTag("DerivBasedOnCrptAsst")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DerivativeBasedOnCryptoAsset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DerivativeBasedOnCryptoAsset { get; init; } 
    #else
    public System.String? DerivativeBasedOnCryptoAsset { get; set; } 
    #endif
    
    
    #nullable disable
    
}
