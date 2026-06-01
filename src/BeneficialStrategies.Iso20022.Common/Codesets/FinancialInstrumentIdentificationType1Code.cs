// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the financial instrument identification type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("af2e4a21-1f5f-4da6-82a6-b1715e1d5d9f")]
[Description(@"Specifies the financial instrument identification type.")]
[DerivedFrom(typeof(FinancialInstrumentIdentificationTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FinancialInstrumentIdentificationType1Code>))]
public enum FinancialInstrumentIdentificationType1Code
{
    /// <summary>
    /// National securities identification number for BE issued by the National Numbering Association SIX Telekurs Belgium.
    /// Encoded/decoded by serializers as &quot;BELC&quot;.
    /// </summary>
    [EnumMember(Value = "BELC")]
    [IsoId("622e6d39-0086-45cb-84fb-3c3d54614bde")]
    [Description(@"National securities identification number for BE issued by the National Numbering Association SIX Telekurs Belgium.")]
    CodeSRWSecretariaatVoorRoerendeWaardenOrSVMSecrétariatDesValeursMobilières = FinancialInstrumentIdentificationTypeCode.CodeSRWSecretariaatVoorRoerendeWaardenOrSVMSecrétariatDesValeursMobilières, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by Bloomberg to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;BLOM&quot;.
    /// </summary>
    [EnumMember(Value = "BLOM")]
    [IsoId("35cb0c33-8956-4c40-9338-a223c758a4b2")]
    [Description(@"Ticker-like code assigned by Bloomberg to identify financial instruments.")]
    Bloomberg = FinancialInstrumentIdentificationTypeCode.Bloomberg, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National Securities Identification Number issued by the National Numbering Association for a country for which no specific financial instrument identification type code already yet.
    /// Encoded/decoded by serializers as &quot;CCCD&quot;.
    /// </summary>
    [EnumMember(Value = "CCCD")]
    [IsoId("247d1c25-2afe-4570-8bac-8153e1f4f6d0")]
    [Description(@"National Securities Identification Number issued by the National Numbering Association for a country for which no specific financial instrument identification type code already yet. The first two letters of the code represents the country code (for example, EGDC for Egyptian NSIN). To be used only until the code is added to the ISO ExternalFinancialInstrumentIdentificationType1Code list.")]
    OtherNationalSecuritiesIdentificationNumber = FinancialInstrumentIdentificationTypeCode.OtherNationalSecuritiesIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National Bond identification number for China issued by CHINA CENTRAL DEPOSITORY &amp; CLEARING CO., Limited.
    /// Encoded/decoded by serializers as &quot;CCDC&quot;.
    /// </summary>
    [EnumMember(Value = "CCDC")]
    [IsoId("c3e2a817-b00e-46be-ae40-a23e013ec81d")]
    [Description(@"National Bond identification number for China issued by CHINA CENTRAL DEPOSITORY & CLEARING CO., Limited.")]
    BondIdentificationCodeListChina = FinancialInstrumentIdentificationTypeCode.BondIdentificationCodeListChina, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by the Chicago Mercantile Exchange to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as &quot;CMED&quot;.
    /// </summary>
    [EnumMember(Value = "CMED")]
    [IsoId("9a3e34ad-660b-40a2-83d2-3f28ce46524d")]
    [Description(@"Ticker-like code assigned by the Chicago Mercantile Exchange to identify listed-derivatives instruments.")]
    ChicagoMercantileExchangeCME = FinancialInstrumentIdentificationTypeCode.ChicagoMercantileExchangeCME, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National securities identification number for ICSDs issued by the National Numbering Association Clearstream and Euroclear.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("6e89af7e-deec-45d9-8e26-f6285f2a97b2")]
    [Description(@"National securities identification number for ICSDs issued by the National Numbering Association Clearstream and Euroclear.")]
    CommonCode = FinancialInstrumentIdentificationTypeCode.CommonCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by the Consolidated Tape Association to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;CTAC&quot;.
    /// </summary>
    [EnumMember(Value = "CTAC")]
    [IsoId("7af832b9-4b2e-43f3-ab90-491aada23eb3")]
    [Description(@"Ticker-like code assigned by the Consolidated Tape Association to identify financial instruments.")]
    ConsolidatedTapeAssociationCTA = FinancialInstrumentIdentificationTypeCode.ConsolidatedTapeAssociationCTA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National securities identification number for US and CA issued by the National Numbering Association Standard &amp; Poor´s - CUSIP Global Services.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("ca05292d-b5b4-4fc2-9218-27a5ff75fe7a")]
    [Description(@"National securities identification number for US and CA issued by the National Numbering Association Standard & Poor´s - CUSIP Global Services.")]
    CommitteeOnUniformSecurityIdentificationProceduresCUSIP = FinancialInstrumentIdentificationTypeCode.CommitteeOnUniformSecurityIdentificationProceduresCUSIP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Digital Token Identifier, as defined in ISO 24165.
    /// Encoded/decoded by serializers as &quot;DTID&quot;.
    /// </summary>
    [EnumMember(Value = "DTID")]
    [IsoId("d76e5c87-735d-40e1-9cfd-dc4b1ab9544e")]
    [Description(@"Digital Token Identifier, as defined in ISO 24165.")]
    DigitalTokenIdentifier = FinancialInstrumentIdentificationTypeCode.DigitalTokenIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A Financial Instrument Global Identifier Composite (FIGC) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the composite level.
    /// Encoded/decoded by serializers as &quot;FIGC&quot;.
    /// </summary>
    [EnumMember(Value = "FIGC")]
    [IsoId("e28d7350-4cb1-4cc8-a4b7-bc9dd096da03")]
    [Description(@"A Financial Instrument Global Identifier Composite (FIGC) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the composite level, is associated with one or more FIGI venue level ID's and a single Share Class level ID.")]
    FinancialInstrumentGlobalIdentifierComposite = FinancialInstrumentIdentificationTypeCode.FinancialInstrumentGlobalIdentifierComposite, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A Financial Instrument Global Identifier Share Class (FIGG) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the global share class level.
    /// Encoded/decoded by serializers as &quot;FIGG&quot;.
    /// </summary>
    [EnumMember(Value = "FIGG")]
    [IsoId("3349cc9b-79c5-46c8-a02d-8a5639ec2ae9")]
    [Description(@"A Financial Instrument Global Identifier Share Class (FIGG) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the global share class level, and is associated with one or more Composite level ID's.")]
    FinancialInstrumentGlobalIdentifierShareClass = FinancialInstrumentIdentificationTypeCode.FinancialInstrumentGlobalIdentifierShareClass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A Financial Instrument Global Identifier (FIGI) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the venue level.
    /// Encoded/decoded by serializers as &quot;FIGI&quot;.
    /// </summary>
    [EnumMember(Value = "FIGI")]
    [IsoId("dc0d730a-37f7-4e60-a45b-4bf334b2f99f")]
    [Description(@"A Financial Instrument Global Identifier (FIGI) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the venue level. It is associated with one Composite ID.")]
    FinancialInstrumentGlobalIdentifier = FinancialInstrumentIdentificationTypeCode.FinancialInstrumentGlobalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// URL in Description to identify OTC derivatives instruments.
    /// Encoded/decoded by serializers as &quot;ISDU&quot;.
    /// </summary>
    [EnumMember(Value = "ISDU")]
    [IsoId("4599eb7a-48d2-4486-b7c9-134526646481")]
    [Description(@"URL in Description to identify OTC derivatives instruments.")]
    ISDAAndFpMLProductURLInSecurityID = FinancialInstrumentIdentificationTypeCode.ISDAAndFpMLProductURLInSecurityID, // same ordinal as derivation source for type conversions

    /// <summary>
    /// XML in Description to identify OTC derivatives instruments.
    /// Encoded/decoded by serializers as &quot;ISDX&quot;.
    /// </summary>
    [EnumMember(Value = "ISDX")]
    [IsoId("020ea11d-0b6b-4d13-90e0-9bde0f46e68c")]
    [Description(@"XML in Description to identify OTC derivatives instruments.")]
    ISDAAndFpMLProductSpecificationXMLInEncodedSecurityDesc = FinancialInstrumentIdentificationTypeCode.ISDAAndFpMLProductSpecificationXMLInEncodedSecurityDesc, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by LCH to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as &quot;LCHD&quot;.
    /// </summary>
    [EnumMember(Value = "LCHD")]
    [IsoId("fe082602-9cd5-4814-9139-9a3189561ea9")]
    [Description(@"Ticker-like code assigned by LCH to identify listed-derivatives instruments.")]
    LCHClearnet = FinancialInstrumentIdentificationTypeCode.LCHClearnet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by the Options Clearing Corporation to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;OCCS&quot;.
    /// </summary>
    [EnumMember(Value = "OCCS")]
    [IsoId("c605d210-0c55-4878-a30d-5d0ffdc252b2")]
    [Description(@"Ticker-like code assigned by the Options Clearing Corporation to identify financial instruments.")]
    OptionsClearingCorpOCC = FinancialInstrumentIdentificationTypeCode.OptionsClearingCorpOCC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by the Options Price Reporting Authority to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;OPRA&quot;.
    /// </summary>
    [EnumMember(Value = "OPRA")]
    [IsoId("9502eaf5-c77f-4534-a406-4433b4883b88")]
    [Description(@"Ticker-like code assigned by the Options Price Reporting Authority to identify financial instruments.")]
    OptionsPriceReportingAuthorityOPRA = FinancialInstrumentIdentificationTypeCode.OptionsPriceReportingAuthorityOPRA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by Markit to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as &quot;RCMD&quot;.
    /// </summary>
    [EnumMember(Value = "RCMD")]
    [IsoId("b5ccc20d-e850-40c0-b6ba-b51eeaba92cf")]
    [Description(@"Ticker-like code assigned by Markit to identify listed-derivatives instruments.")]
    MarkitRedCode = FinancialInstrumentIdentificationTypeCode.MarkitRedCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker-like code assigned by Thomson Reuters to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;RICC&quot;.
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("cb69b970-b616-4803-a720-0a8eb4a93f8a")]
    [Description(@"Ticker-like code assigned by Thomson Reuters to identify financial instruments.")]
    ReutersInstrumentCodeRIC = FinancialInstrumentIdentificationTypeCode.ReutersInstrumentCodeRIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National securities identification number for GB issued by the National Numbering Association London Stock Exchange.
    /// Encoded/decoded by serializers as &quot;SEDL&quot;.
    /// </summary>
    [EnumMember(Value = "SEDL")]
    [IsoId("3a56b021-9084-4bee-a9ce-dece59406b97")]
    [Description(@"National securities identification number for GB issued by the National Numbering Association London Stock Exchange.")]
    StockExchangeDailyOfficialListSEDOL = FinancialInstrumentIdentificationTypeCode.StockExchangeDailyOfficialListSEDOL, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National securities identification number for JP issued by the National Numbering Association 6 Stock Exchanges and JASDEC.
    /// Encoded/decoded by serializers as &quot;SICC&quot;.
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("e01084cf-6be3-46ce-bbed-0eb9c4613cae")]
    [Description(@"National securities identification number for JP issued by the National Numbering Association 6 Stock Exchanges and JASDEC (Securities Identification Ticker-like code Committee).")]
    SecuritiesIdentificationCodeCommittee = FinancialInstrumentIdentificationTypeCode.SecuritiesIdentificationCodeCommittee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ticker Code assigned by an exchange to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;TIKR&quot;.
    /// </summary>
    [EnumMember(Value = "TIKR")]
    [IsoId("e8502f99-8227-456b-80ca-fe0f2a2cf0a8")]
    [Description(@"Ticker Code assigned by an exchange to identify financial instruments.")]
    TickerSymbolTS = FinancialInstrumentIdentificationTypeCode.TickerSymbolTS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National securities identification number for CH and LI issued by the National Numbering Association SIX Telekurs Ltd.
    /// Encoded/decoded by serializers as &quot;VALO&quot;.
    /// </summary>
    [EnumMember(Value = "VALO")]
    [IsoId("0087f2a7-f156-48c0-9994-bb63f0da4000")]
    [Description(@"National securities identification number for CH and LI issued by the National Numbering Association SIX Telekurs Ltd.")]
    VALOR = FinancialInstrumentIdentificationTypeCode.VALOR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National securities identification number for DE issued by the National Numbering Association WM Datenservice.
    /// Encoded/decoded by serializers as &quot;WKNR&quot;.
    /// </summary>
    [EnumMember(Value = "WKNR")]
    [IsoId("f7bc3e32-bcb4-4786-b367-87d1314b720a")]
    [Description(@"National securities identification number for DE issued by the National Numbering Association WM Datenservice.")]
    WertpapierkennummerWKN = FinancialInstrumentIdentificationTypeCode.WertpapierkennummerWKN, // same ordinal as derivation source for type conversions
}
