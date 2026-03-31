// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a contract.
/// </summary>
[IsoId("_cL1LmVovEe23K4GXSpBSeg")]
[DisplayName("Contract Matching Criteria")]
public record ContractMatchingCriteria3
{
    /// <summary>
    /// Specifies whether the information on the ISINs are matching or not.
    /// </summary>
    [IsoId("_cNVAYVovEe23K4GXSpBSeg")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public CompareISINIdentifier2? ISIN { get; init; }

    /// <summary>
    /// Specifies whether the information on the Unique Product Identifiers are matching or not.
    /// </summary>
    [IsoId("_cNVAY1ovEe23K4GXSpBSeg")]
    [DisplayName("Unique Product Identifier")]
    [IsoXmlTag("UnqPdctIdr")]
    public CompareUniqueProductIdentifier2? UniqueProductIdentifier { get; init; }

    /// <summary>
    /// Specifies whether the information on the AIIs are matching or not.
    /// </summary>
    [IsoId("_aDxZ0FqmEe2in88Nl6zFFQ")]
    [DisplayName("Alternative Instrument Identification")]
    [IsoXmlTag("AltrntvInstrmId")]
    public CompareText1? AlternativeInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies whether the values defined as CFI (Classification of Financial Instruments-ISO 10962) identifier are matching or not.
    /// </summary>
    [IsoId("_cNVAZVovEe23K4GXSpBSeg")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    public CompareCFIIdentifier3? ProductClassification { get; init; }

    /// <summary>
    /// Specifies whether the information on the contract types are matching or not.
    /// </summary>
    [IsoId("_cNVAZ1ovEe23K4GXSpBSeg")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public CompareFinancialInstrumentContractType1? ContractType { get; init; }

    /// <summary>
    /// Specifies whether the information on the asset classes are matching or not.
    /// </summary>
    [IsoId("_cNVAaVovEe23K4GXSpBSeg")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public CompareAssetClass1? AssetClass { get; init; }

    /// <summary>
    /// Specifies whether the information on the derivatives based on crypto assets are matching or not.
    /// </summary>
    [IsoId("_cNVAa1ovEe23K4GXSpBSeg")]
    [DisplayName("Derivative Based On Crypto Asset")]
    [IsoXmlTag("DerivBasedOnCrptAsst")]
    public CompareTrueFalseIndicator3? DerivativeBasedOnCryptoAsset { get; init; }

    /// <summary>
    /// Specifies whether the information on the underlying instruments are matching or not.
    /// </summary>
    [IsoId("_cNVAbVovEe23K4GXSpBSeg")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public CompareUnderlyingInstrument3? UnderlyingInstrument { get; init; }

    /// <summary>
    /// Specifies whether the information on the settlement currency are matching or not.
    /// </summary>
    [IsoId("_cNVAb1ovEe23K4GXSpBSeg")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrency { get; init; }

    /// <summary>
    /// Specifies whether the information on the settlement currency second legs are matching or not.
    /// </summary>
    [IsoId("_cNVAcVovEe23K4GXSpBSeg")]
    [DisplayName("Settlement Currency Second Leg")]
    [IsoXmlTag("SttlmCcyScndLeg")]
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrencySecondLeg { get; init; }
}
