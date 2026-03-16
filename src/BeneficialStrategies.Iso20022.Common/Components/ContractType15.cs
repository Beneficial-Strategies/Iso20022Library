// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract Type15.
/// </summary>
[IsoId("_v8SdgbnvEe6Uq84qj-dV5Q")]
[DisplayName("Contract Type15")]
public record ContractType15
{
    /// <summary>
    /// Asset Class.
    /// </summary>
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; }

    /// <summary>
    /// Contract Type.
    /// </summary>
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; }

    /// <summary>
    /// Derivative Based On Crypto Asset.
    /// </summary>
    [DisplayName("Derivative Based On Crypto Asset")]
    [IsoXmlTag("DerivBasedOnCrptAsst")]
    public IsoTrueFalseIndicator? DerivativeBasedOnCryptoAsset { get; init; }

    /// <summary>
    /// Place Of Settlement.
    /// </summary>
    [DisplayName("Place Of Settlement")]
    [IsoXmlTag("PlcOfSttlm")]
    public CountryCode? PlaceOfSettlement { get; init; }

    /// <summary>
    /// Product Classification.
    /// </summary>
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    public IsoCFIOct2015Identifier? ProductClassification { get; init; }

    /// <summary>
    /// Product Identification.
    /// </summary>
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification46? ProductIdentification { get; init; }

    /// <summary>
    /// Settlement Currency.
    /// </summary>
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public CurrencyExchange23? SettlementCurrency { get; init; }

    /// <summary>
    /// Settlement Currency Second Leg.
    /// </summary>
    [DisplayName("Settlement Currency Second Leg")]
    [IsoXmlTag("SttlmCcyScndLeg")]
    public CurrencyExchange23? SettlementCurrencySecondLeg { get; init; }

    /// <summary>
    /// Underlying Asset Price Source.
    /// </summary>
    [DisplayName("Underlying Asset Price Source")]
    [IsoXmlTag("UndrlygAsstPricSrc")]
    public IsoMax50Text? UnderlyingAssetPriceSource { get; init; }

    /// <summary>
    /// Underlying Asset Trading Platform Identifier.
    /// </summary>
    [DisplayName("Underlying Asset Trading Platform Identifier")]
    [IsoXmlTag("UndrlygAsstTradgPltfmIdr")]
    public IsoMICIdentifier? UnderlyingAssetTradingPlatformIdentifier { get; init; }

    /// <summary>
    /// Underlying Instrument.
    /// </summary>
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public SecurityIdentification41Choice_? UnderlyingInstrument { get; init; }
}
