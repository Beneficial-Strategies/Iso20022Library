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
/// Compares information related to both sides of a contract.
/// </summary>
[IsoId("_cL1LmVovEe23K4GXSpBSeg")]
[DisplayName("Contract Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractMatchingCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the ISINs are matching or not.
    /// </summary>
    [IsoId("_cNVAYVovEe23K4GXSpBSeg")]
    [DisplayName("ISIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISIN")]
    #endif
    [IsoXmlTag("ISIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareISINIdentifier2? ISIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareISINIdentifier2? ISIN { get; init; } 
    #else
    public CompareISINIdentifier2? ISIN { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the Unique Product Identifiers are matching or not.
    /// </summary>
    [IsoId("_cNVAY1ovEe23K4GXSpBSeg")]
    [DisplayName("Unique Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqPdctIdr")]
    #endif
    [IsoXmlTag("UnqPdctIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUniqueProductIdentifier2? UniqueProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUniqueProductIdentifier2? UniqueProductIdentifier { get; init; } 
    #else
    public CompareUniqueProductIdentifier2? UniqueProductIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the AIIs are matching or not.
    /// </summary>
    [IsoId("_aDxZ0FqmEe2in88Nl6zFFQ")]
    [DisplayName("Alternative Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrntvInstrmId")]
    #endif
    [IsoXmlTag("AltrntvInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareText1? AlternativeInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareText1? AlternativeInstrumentIdentification { get; init; } 
    #else
    public CompareText1? AlternativeInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as CFI (Classification of Financial Instruments-ISO 10962) identifier are matching or not.
    /// </summary>
    [IsoId("_cNVAZVovEe23K4GXSpBSeg")]
    [DisplayName("Product Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctClssfctn")]
    #endif
    [IsoXmlTag("PdctClssfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareCFIIdentifier3? ProductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareCFIIdentifier3? ProductClassification { get; init; } 
    #else
    public CompareCFIIdentifier3? ProductClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the contract types are matching or not.
    /// </summary>
    [IsoId("_cNVAZ1ovEe23K4GXSpBSeg")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFinancialInstrumentContractType1? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFinancialInstrumentContractType1? ContractType { get; init; } 
    #else
    public CompareFinancialInstrumentContractType1? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the asset classes are matching or not.
    /// </summary>
    [IsoId("_cNVAaVovEe23K4GXSpBSeg")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAssetClass1? AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAssetClass1? AssetClass { get; init; } 
    #else
    public CompareAssetClass1? AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the derivatives based on crypto assets are matching or not.
    /// </summary>
    [IsoId("_cNVAa1ovEe23K4GXSpBSeg")]
    [DisplayName("Derivative Based On Crypto Asset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivBasedOnCrptAsst")]
    #endif
    [IsoXmlTag("DerivBasedOnCrptAsst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator3? DerivativeBasedOnCryptoAsset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator3? DerivativeBasedOnCryptoAsset { get; init; } 
    #else
    public CompareTrueFalseIndicator3? DerivativeBasedOnCryptoAsset { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the underlying instruments are matching or not.
    /// </summary>
    [IsoId("_cNVAbVovEe23K4GXSpBSeg")]
    [DisplayName("Underlying Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrm")]
    #endif
    [IsoXmlTag("UndrlygInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnderlyingInstrument3? UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnderlyingInstrument3? UnderlyingInstrument { get; init; } 
    #else
    public CompareUnderlyingInstrument3? UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the settlement currency are matching or not.
    /// </summary>
    [IsoId("_cNVAb1ovEe23K4GXSpBSeg")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrency { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the settlement currency second legs are matching or not.
    /// </summary>
    [IsoId("_cNVAcVovEe23K4GXSpBSeg")]
    [DisplayName("Settlement Currency Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcyScndLeg")]
    #endif
    [IsoXmlTag("SttlmCcyScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrencySecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrencySecondLeg { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrencySecondLeg { get; set; } 
    #endif
    
    
    #nullable disable
    
}
