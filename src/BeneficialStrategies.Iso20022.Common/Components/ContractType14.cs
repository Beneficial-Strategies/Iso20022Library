// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract attributes.
/// </summary>
[IsoId("_k5ZioWEUEe2P-L9DBerEgA")]
[DisplayName("Contract Type")]
public partial record ContractType14
{
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_k6RFUWEUEe2P-L9DBerEgA")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_k6RFU2EUEe2P-L9DBerEgA")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; } 
    
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    [IsoId("_k6RFVWEUEe2P-L9DBerEgA")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ProductClassification { get; init; } 
    
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    [IsoId("_k6RFWWEUEe2P-L9DBerEgA")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification46? ProductIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_k6RFW2EUEe2P-L9DBerEgA")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public SecurityIdentification41Choice_? UnderlyingInstrument { get; init; } 
    
    /// <summary>
    /// Specifies the currency to be used for cash settlement of the transaction. 
    /// Usage: For multicurrency transactions that do not net, SettlementCurrency is to be considered as the first leg.
    /// </summary>
    [IsoId("_k6RFXWEUEe2P-L9DBerEgA")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public CurrencyExchange23? SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the currency second leg to be used for cash settlement of the transaction. 
    /// </summary>
    [IsoId("_k6RFX2EUEe2P-L9DBerEgA")]
    [DisplayName("Settlement Currency Second Leg")]
    [IsoXmlTag("SttlmCcyScndLeg")]
    public CurrencyExchange23? SettlementCurrencySecondLeg { get; init; } 
    
    /// <summary>
    /// Specifies the place where settlement of the transaction occurs as stipulated in the contract.
    /// </summary>
    [IsoId("_k6RFYWEUEe2P-L9DBerEgA")]
    [DisplayName("Place Of Settlement")]
    [IsoXmlTag("PlcOfSttlm")]
    public CountryCode? PlaceOfSettlement { get; init; } 
    
    /// <summary>
    /// Indicator whether the derivative is based on crypto-asset.
    /// Usage: If the element is not present, the DerivativeBasedOnCryptoAsset is False.
    /// </summary>
    [IsoId("_k6RFY2EUEe2P-L9DBerEgA")]
    [DisplayName("Derivative Based On Crypto Asset")]
    [IsoXmlTag("DerivBasedOnCrptAsst")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? DerivativeBasedOnCryptoAsset { get; init; } 
    
    
    #nullable disable
    
}
