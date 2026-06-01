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
[IsoId("71ff57b8-e55d-488c-a1df-f66442371b1f")]
[Description(@"Specifies the financial instrument identification type.")]
[Derivations(typeof(FinancialInstrumentIdentificationType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FinancialInstrumentIdentificationTypeCode>))]
public enum FinancialInstrumentIdentificationTypeCode
{
    /// <summary>
    /// National securities identification number for BE issued by the National Numbering Association SIX Telekurs Belgium.
    /// Encoded/decoded by serializers as &quot;BELC&quot;.
    /// </summary>
    [EnumMember(Value = "BELC")]
    [IsoId("fdf84ef5-4131-4224-8bff-1bdcd98bc383")]
    [Description(@"National securities identification number for BE issued by the National Numbering Association SIX Telekurs Belgium.")]
    CodeSRWSecretariaatVoorRoerendeWaardenOrSVMSecrétariatDesValeursMobilières,

    /// <summary>
    /// Ticker-like code assigned by Bloomberg to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;BLOM&quot;.
    /// </summary>
    [EnumMember(Value = "BLOM")]
    [IsoId("ee659850-b0f0-404a-9cd7-16940a181923")]
    [Description(@"Ticker-like code assigned by Bloomberg to identify financial instruments.")]
    Bloomberg,

    /// <summary>
    /// National Securities Identification Number issued by the National Numbering Association for a country for which no specific financial instrument identification type code already yet. The first two letters of the code represents the country code (for example, EGDC for Egyptian NSIN). To be used only until the code is added to the ISO ExternalFinancialInstrumentIdentificationType1Code list.
    /// Encoded/decoded by serializers as &quot;CCCD&quot;.
    /// </summary>
    [EnumMember(Value = "CCCD")]
    [IsoId("791bbf80-399e-4232-a108-9fc21ad4b2f5")]
    [Description(@"National Securities Identification Number issued by the National Numbering Association for a country for which no specific financial instrument identification type code already yet. The first two letters of the code represents the country code (for example, EGDC for Egyptian NSIN). To be used only until the code is added to the ISO ExternalFinancialInstrumentIdentificationType1Code list.")]
    OtherNationalSecuritiesIdentificationNumber,

    /// <summary>
    /// National Bond identification number for China issued by CHINA CENTRAL DEPOSITORY &amp; CLEARING CO., Limited.
    /// Encoded/decoded by serializers as &quot;CCDC&quot;.
    /// </summary>
    [EnumMember(Value = "CCDC")]
    [IsoId("c88d3ee5-0a2f-4b2f-a5e9-debdceadacc0")]
    [Description(@"National Bond identification number for China issued by CHINA CENTRAL DEPOSITORY & CLEARING CO., Limited.")]
    BondIdentificationCodeListChina,

    /// <summary>
    /// Ticker-like code assigned by the Chicago Mercantile Exchange to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as &quot;CMED&quot;.
    /// </summary>
    [EnumMember(Value = "CMED")]
    [IsoId("1f930761-70cd-466e-b8d3-069f63ca52f0")]
    [Description(@"Ticker-like code assigned by the Chicago Mercantile Exchange to identify listed-derivatives instruments.")]
    ChicagoMercantileExchangeCME,

    /// <summary>
    /// National securities identification number for ICSDs issued by the National Numbering Association Clearstream and Euroclear.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("0ea94508-1cfb-47b6-9039-f27f0448e184")]
    [Description(@"National securities identification number for ICSDs issued by the National Numbering Association Clearstream and Euroclear.")]
    CommonCode,

    /// <summary>
    /// Ticker-like code assigned by the Consolidated Tape Association to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;CTAC&quot;.
    /// </summary>
    [EnumMember(Value = "CTAC")]
    [IsoId("5fde86b7-92ea-4a1f-b635-f393fc50b1d1")]
    [Description(@"Ticker-like code assigned by the Consolidated Tape Association to identify financial instruments.")]
    ConsolidatedTapeAssociationCTA,

    /// <summary>
    /// National securities identification number for US and CA issued by the National Numbering Association Standard &amp; Poor´s - CUSIP Global Services.
    /// Encoded/decoded by serializers as &quot;CUSP&quot;.
    /// </summary>
    [EnumMember(Value = "CUSP")]
    [IsoId("4fb87f59-9b12-48d3-984c-6b8dee7beddd")]
    [Description(@"National securities identification number for US and CA issued by the National Numbering Association Standard & Poor´s - CUSIP Global Services.")]
    CommitteeOnUniformSecurityIdentificationProceduresCUSIP,

    /// <summary>
    /// Digital Token Identifier, as defined in ISO 24165.
    /// Encoded/decoded by serializers as &quot;DTID&quot;.
    /// </summary>
    [EnumMember(Value = "DTID")]
    [IsoId("c00bb642-e6d3-4ef4-ac27-e164a0e11183")]
    [Description(@"Digital Token Identifier, as defined in ISO 24165.")]
    DigitalTokenIdentifier,

    /// <summary>
    /// A Financial Instrument Global Identifier Composite (FIGC) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the composite level, is associated with one or more FIGI venue level ID's and a single Share Class level ID.
    /// Encoded/decoded by serializers as &quot;FIGC&quot;.
    /// </summary>
    [EnumMember(Value = "FIGC")]
    [IsoId("6e85b427-ab49-418d-bc60-6c3ae35c1da3")]
    [Description(@"A Financial Instrument Global Identifier Composite (FIGC) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the composite level, is associated with one or more FIGI venue level ID's and a single Share Class level ID.")]
    FinancialInstrumentGlobalIdentifierComposite,

    /// <summary>
    /// A Financial Instrument Global Identifier Share Class (FIGG) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the global share class level, and is associated with one or more Composite level ID's.
    /// Encoded/decoded by serializers as &quot;FIGG&quot;.
    /// </summary>
    [EnumMember(Value = "FIGG")]
    [IsoId("f79a7d62-2e38-4289-8c3f-54ebe9744ec1")]
    [Description(@"A Financial Instrument Global Identifier Share Class (FIGG) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the global share class level, and is associated with one or more Composite level ID's.")]
    FinancialInstrumentGlobalIdentifierShareClass,

    /// <summary>
    /// A Financial Instrument Global Identifier (FIGI) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the venue level. It is associated with one Composite ID.
    /// Encoded/decoded by serializers as &quot;FIGI&quot;.
    /// </summary>
    [EnumMember(Value = "FIGI")]
    [IsoId("8b62a724-3ca4-4471-9836-b3f3c7ecec0a")]
    [Description(@"A Financial Instrument Global Identifier (FIGI) is a unique, persistent twelve character string that serves to identify financial instruments across asset classes at the venue level. It is associated with one Composite ID.")]
    FinancialInstrumentGlobalIdentifier,

    /// <summary>
    /// URL in Description to identify OTC derivatives instruments.
    /// Encoded/decoded by serializers as &quot;ISDU&quot;.
    /// </summary>
    [EnumMember(Value = "ISDU")]
    [IsoId("3a1f71e6-414e-4b6d-a125-be455847b5ef")]
    [Description(@"URL in Description to identify OTC derivatives instruments.")]
    ISDAAndFpMLProductURLInSecurityID,

    /// <summary>
    /// XML in Description to identify OTC derivatives instruments.
    /// Encoded/decoded by serializers as &quot;ISDX&quot;.
    /// </summary>
    [EnumMember(Value = "ISDX")]
    [IsoId("1b6bc2c8-8030-4af1-a90d-9043d6244e50")]
    [Description(@"XML in Description to identify OTC derivatives instruments.")]
    ISDAAndFpMLProductSpecificationXMLInEncodedSecurityDesc,

    /// <summary>
    /// Ticker-like code assigned by LCH to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as &quot;LCHD&quot;.
    /// </summary>
    [EnumMember(Value = "LCHD")]
    [IsoId("793fea56-ce8c-4657-9e73-964c0b1820cc")]
    [Description(@"Ticker-like code assigned by LCH to identify listed-derivatives instruments.")]
    LCHClearnet,

    /// <summary>
    /// Ticker-like code assigned by the Options Clearing Corporation to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;OCCS&quot;.
    /// </summary>
    [EnumMember(Value = "OCCS")]
    [IsoId("6b9b8bba-dbde-48c4-a409-5753dc59e43e")]
    [Description(@"Ticker-like code assigned by the Options Clearing Corporation to identify financial instruments.")]
    OptionsClearingCorpOCC,

    /// <summary>
    /// Ticker-like code assigned by the Options Price Reporting Authority to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;OPRA&quot;.
    /// </summary>
    [EnumMember(Value = "OPRA")]
    [IsoId("3f05808f-6884-4c19-9695-64182cb85274")]
    [Description(@"Ticker-like code assigned by the Options Price Reporting Authority to identify financial instruments.")]
    OptionsPriceReportingAuthorityOPRA,

    /// <summary>
    /// Ticker-like code assigned by Markit to identify listed-derivatives instruments.
    /// Encoded/decoded by serializers as &quot;RCMD&quot;.
    /// </summary>
    [EnumMember(Value = "RCMD")]
    [IsoId("ea6553b3-2e48-4b87-9883-aeff8ef7e4ae")]
    [Description(@"Ticker-like code assigned by Markit to identify listed-derivatives instruments.")]
    MarkitRedCode,

    /// <summary>
    /// Ticker-like code assigned by Thomson Reuters to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;RICC&quot;.
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("31da4047-e3b0-4870-ab80-4d390cf86da2")]
    [Description(@"Ticker-like code assigned by Thomson Reuters to identify financial instruments.")]
    ReutersInstrumentCodeRIC,

    /// <summary>
    /// National securities identification number for GB issued by the National Numbering Association London Stock Exchange.
    /// Encoded/decoded by serializers as &quot;SEDL&quot;.
    /// </summary>
    [EnumMember(Value = "SEDL")]
    [IsoId("c8195361-f5ce-42f0-b9e8-b8190ab72694")]
    [Description(@"National securities identification number for GB issued by the National Numbering Association London Stock Exchange.")]
    StockExchangeDailyOfficialListSEDOL,

    /// <summary>
    /// National securities identification number for JP issued by the National Numbering Association 6 Stock Exchanges and JASDEC (Securities Identification Ticker-like code Committee).
    /// Encoded/decoded by serializers as &quot;SICC&quot;.
    /// </summary>
    [EnumMember(Value = "SICC")]
    [IsoId("397b1872-60bf-4409-b372-688a4e38e1d8")]
    [Description(@"National securities identification number for JP issued by the National Numbering Association 6 Stock Exchanges and JASDEC (Securities Identification Ticker-like code Committee).")]
    SecuritiesIdentificationCodeCommittee,

    /// <summary>
    /// Ticker Code assigned by an exchange to identify financial instruments.
    /// Encoded/decoded by serializers as &quot;TIKR&quot;.
    /// </summary>
    [EnumMember(Value = "TIKR")]
    [IsoId("d4104db6-489e-46c3-a78a-fa887e793620")]
    [Description(@"Ticker Code assigned by an exchange to identify financial instruments.")]
    TickerSymbolTS,

    /// <summary>
    /// National securities identification number for CH and LI issued by the National Numbering Association SIX Telekurs Ltd.
    /// Encoded/decoded by serializers as &quot;VALO&quot;.
    /// </summary>
    [EnumMember(Value = "VALO")]
    [IsoId("98b7d49e-8edf-4a8e-bdca-c40df018945e")]
    [Description(@"National securities identification number for CH and LI issued by the National Numbering Association SIX Telekurs Ltd.")]
    VALOR,

    /// <summary>
    /// National securities identification number for DE issued by the National Numbering Association WM Datenservice.
    /// Encoded/decoded by serializers as &quot;WKNR&quot;.
    /// </summary>
    [EnumMember(Value = "WKNR")]
    [IsoId("2e56a833-77ac-4d4f-8d25-7efacf17082e")]
    [Description(@"National securities identification number for DE issued by the National Numbering Association WM Datenservice.")]
    WertpapierkennummerWKN,
}
