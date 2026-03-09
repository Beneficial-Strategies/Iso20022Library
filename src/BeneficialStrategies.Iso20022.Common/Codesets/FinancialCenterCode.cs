// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the financial center taken into account to adjust a date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aoHzQNp-Ed-ak6NoX_4Aeg_627416502")]
[Description(@"Indicates the financial center taken into account to adjust a date.")]
public enum FinancialCenterCode
{
    /// <summary>
    /// Code for Brussels.
    /// Encoded/decoded by serializers as &quot;BEBR&quot;.
    /// </summary>
    [EnumMember(Value = "BEBR")]
    [IsoId("_aoHzQdp-Ed-ak6NoX_4Aeg_627416510")]
    [Description(@"Code for Brussels.")]
    Brussels,
    
    /// <summary>
    /// Code for Buenos Aires.
    /// Encoded/decoded by serializers as &quot;ARBA&quot;.
    /// </summary>
    [EnumMember(Value = "ARBA")]
    [IsoId("_aoHzQtp-Ed-ak6NoX_4Aeg_627416511")]
    [Description(@"Code for Buenos Aires.")]
    BuenosAires,
    
    /// <summary>
    /// Code for Vienna.
    /// Encoded/decoded by serializers as &quot;ATVI&quot;.
    /// </summary>
    [EnumMember(Value = "ATVI")]
    [IsoId("_aoHzQ9p-Ed-ak6NoX_4Aeg_627416512")]
    [Description(@"Code for Vienna.")]
    Vienna,
    
    /// <summary>
    /// Code for Melbourne.
    /// Encoded/decoded by serializers as &quot;AUME&quot;.
    /// </summary>
    [EnumMember(Value = "AUME")]
    [IsoId("_aoHzRNp-Ed-ak6NoX_4Aeg_627416513")]
    [Description(@"Code for Melbourne.")]
    Melbourne,
    
    /// <summary>
    /// Code for Sydney.
    /// Encoded/decoded by serializers as &quot;AUSY&quot;.
    /// </summary>
    [EnumMember(Value = "AUSY")]
    [IsoId("_aoHzRdp-Ed-ak6NoX_4Aeg_627416514")]
    [Description(@"Code for Sydney.")]
    Sydney,
    
    /// <summary>
    /// Code for Sao Paulo.
    /// Encoded/decoded by serializers as &quot;BRSP&quot;.
    /// </summary>
    [EnumMember(Value = "BRSP")]
    [IsoId("_aoHzRtp-Ed-ak6NoX_4Aeg_627416515")]
    [Description(@"Code for Sao Paulo.")]
    SaoPaulo,
    
    /// <summary>
    /// Code for Montreal.
    /// Encoded/decoded by serializers as &quot;CAMO&quot;.
    /// </summary>
    [EnumMember(Value = "CAMO")]
    [IsoId("_aoHzR9p-Ed-ak6NoX_4Aeg_627416741")]
    [Description(@"Code for Montreal.")]
    Montreal,
    
    /// <summary>
    /// Code for Toronto.
    /// Encoded/decoded by serializers as &quot;CATO&quot;.
    /// </summary>
    [EnumMember(Value = "CATO")]
    [IsoId("_aoHzSNp-Ed-ak6NoX_4Aeg_627416742")]
    [Description(@"Code for Toronto.")]
    Toronto,
    
    /// <summary>
    /// Code for Geneva.
    /// Encoded/decoded by serializers as &quot;CHGE&quot;.
    /// </summary>
    [EnumMember(Value = "CHGE")]
    [IsoId("_aoHzSdp-Ed-ak6NoX_4Aeg_627416743")]
    [Description(@"Code for Geneva.")]
    Geneva,
    
    /// <summary>
    /// Code for Bratislava.
    /// Encoded/decoded by serializers as &quot;SKBR&quot;.
    /// </summary>
    [EnumMember(Value = "SKBR")]
    [IsoId("_aoRkQNp-Ed-ak6NoX_4Aeg_627416744")]
    [Description(@"Code for Bratislava.")]
    Bratislava,
    
    /// <summary>
    /// Code for Santiago.
    /// Encoded/decoded by serializers as &quot;CLSA&quot;.
    /// </summary>
    [EnumMember(Value = "CLSA")]
    [IsoId("_aoRkQdp-Ed-ak6NoX_4Aeg_627416745")]
    [Description(@"Code for Santiago.")]
    Santiago,
    
    /// <summary>
    /// Code for Beijing.
    /// Encoded/decoded by serializers as &quot;CNBE&quot;.
    /// </summary>
    [EnumMember(Value = "CNBE")]
    [IsoId("_aoRkQtp-Ed-ak6NoX_4Aeg_627416746")]
    [Description(@"Code for Beijing.")]
    Beijing,
    
    /// <summary>
    /// Code for Prague.
    /// Encoded/decoded by serializers as &quot;CZPR&quot;.
    /// </summary>
    [EnumMember(Value = "CZPR")]
    [IsoId("_aoRkQ9p-Ed-ak6NoX_4Aeg_627416747")]
    [Description(@"Code for Prague.")]
    Prague,
    
    /// <summary>
    /// Code for Frankfurt.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_aoRkRNp-Ed-ak6NoX_4Aeg_627416748")]
    [Description(@"Code for Frankfurt.")]
    Frankfurt,
    
    /// <summary>
    /// Code for Copenhagen.
    /// Encoded/decoded by serializers as &quot;DKCO&quot;.
    /// </summary>
    [EnumMember(Value = "DKCO")]
    [IsoId("_aoRkRdp-Ed-ak6NoX_4Aeg_627416749")]
    [Description(@"Code for Copenhagen.")]
    Copenhagen,
    
    /// <summary>
    /// Code for Tallinn.
    /// Encoded/decoded by serializers as &quot;EETA&quot;.
    /// </summary>
    [EnumMember(Value = "EETA")]
    [IsoId("_aoRkRtp-Ed-ak6NoX_4Aeg_627416750")]
    [Description(@"Code for Tallinn.")]
    Tallinn,
    
    /// <summary>
    /// Code for Madrid.
    /// Encoded/decoded by serializers as &quot;ESMA&quot;.
    /// </summary>
    [EnumMember(Value = "ESMA")]
    [IsoId("_aoRkR9p-Ed-ak6NoX_4Aeg_627416758")]
    [Description(@"Code for Madrid.")]
    Madrid,
    
    /// <summary>
    /// Code for Helsinki.
    /// Encoded/decoded by serializers as &quot;FIHE&quot;.
    /// </summary>
    [EnumMember(Value = "FIHE")]
    [IsoId("_aoRkSNp-Ed-ak6NoX_4Aeg_627416759")]
    [Description(@"Code for Helsinki.")]
    Helsinki,
    
    /// <summary>
    /// Code for Paris.
    /// Encoded/decoded by serializers as &quot;FRPA&quot;.
    /// </summary>
    [EnumMember(Value = "FRPA")]
    [IsoId("_aoauMNp-Ed-ak6NoX_4Aeg_627416760")]
    [Description(@"Code for Paris.")]
    Paris,
    
    /// <summary>
    /// Code for London.
    /// Encoded/decoded by serializers as &quot;GBLO&quot;.
    /// </summary>
    [EnumMember(Value = "GBLO")]
    [IsoId("_aoauMdp-Ed-ak6NoX_4Aeg_627416761")]
    [Description(@"Code for London.")]
    London,
    
    /// <summary>
    /// Code for Athens.
    /// Encoded/decoded by serializers as &quot;GRAT&quot;.
    /// </summary>
    [EnumMember(Value = "GRAT")]
    [IsoId("_aoauMtp-Ed-ak6NoX_4Aeg_627416762")]
    [Description(@"Code for Athens.")]
    Athens,
    
    /// <summary>
    /// Code for Hong Kong.
    /// Encoded/decoded by serializers as &quot;HKHK&quot;.
    /// </summary>
    [EnumMember(Value = "HKHK")]
    [IsoId("_aoauM9p-Ed-ak6NoX_4Aeg_627416763")]
    [Description(@"Code for Hong Kong.")]
    HongKong,
    
    /// <summary>
    /// Code for Budapest.
    /// Encoded/decoded by serializers as &quot;HUBU&quot;.
    /// </summary>
    [EnumMember(Value = "HUBU")]
    [IsoId("_aoauNNp-Ed-ak6NoX_4Aeg_627416772")]
    [Description(@"Code for Budapest.")]
    Budapest,
    
    /// <summary>
    /// Code for Jakarta.
    /// Encoded/decoded by serializers as &quot;IDJA&quot;.
    /// </summary>
    [EnumMember(Value = "IDJA")]
    [IsoId("_aoauNdp-Ed-ak6NoX_4Aeg_627416773")]
    [Description(@"Code for Jakarta.")]
    Jakarta,
    
    /// <summary>
    /// Code for Dublin.
    /// Encoded/decoded by serializers as &quot;IEDU&quot;.
    /// </summary>
    [EnumMember(Value = "IEDU")]
    [IsoId("_aoauNtp-Ed-ak6NoX_4Aeg_627416774")]
    [Description(@"Code for Dublin.")]
    Dublin,
    
    /// <summary>
    /// Code for Tel Aviv.
    /// Encoded/decoded by serializers as &quot;ILTA&quot;.
    /// </summary>
    [EnumMember(Value = "ILTA")]
    [IsoId("_aoauN9p-Ed-ak6NoX_4Aeg_627416775")]
    [Description(@"Code for Tel Aviv.")]
    TelAviv,
    
    /// <summary>
    /// Code for Milan.
    /// Encoded/decoded by serializers as &quot;ITMI&quot;.
    /// </summary>
    [EnumMember(Value = "ITMI")]
    [IsoId("_aoauONp-Ed-ak6NoX_4Aeg_627416776")]
    [Description(@"Code for Milan.")]
    Milan,
    
    /// <summary>
    /// Code for Rome.
    /// Encoded/decoded by serializers as &quot;ITRO&quot;.
    /// </summary>
    [EnumMember(Value = "ITRO")]
    [IsoId("_aoauOdp-Ed-ak6NoX_4Aeg_627416777")]
    [Description(@"Code for Rome.")]
    Rome,
    
    /// <summary>
    /// Code for Tokyo.
    /// Encoded/decoded by serializers as &quot;JPTO&quot;.
    /// </summary>
    [EnumMember(Value = "JPTO")]
    [IsoId("_aokfMNp-Ed-ak6NoX_4Aeg_627416778")]
    [Description(@"Code for Tokyo.")]
    Tokyo,
    
    /// <summary>
    /// Code for Seoul.
    /// Encoded/decoded by serializers as &quot;KRSE&quot;.
    /// </summary>
    [EnumMember(Value = "KRSE")]
    [IsoId("_aokfMdp-Ed-ak6NoX_4Aeg_627416779")]
    [Description(@"Code for Seoul.")]
    Seoul,
    
    /// <summary>
    /// Code for Beirut.
    /// Encoded/decoded by serializers as &quot;LBBE&quot;.
    /// </summary>
    [EnumMember(Value = "LBBE")]
    [IsoId("_aokfMtp-Ed-ak6NoX_4Aeg_627416780")]
    [Description(@"Code for Beirut.")]
    Beirut,
    
    /// <summary>
    /// Code for Luxembourg.
    /// Encoded/decoded by serializers as &quot;LULU&quot;.
    /// </summary>
    [EnumMember(Value = "LULU")]
    [IsoId("_aokfM9p-Ed-ak6NoX_4Aeg_627416781")]
    [Description(@"Code for Luxembourg.")]
    Luxembourg,
    
    /// <summary>
    /// Code for Kuala Lumpur.
    /// Encoded/decoded by serializers as &quot;MYKL&quot;.
    /// </summary>
    [EnumMember(Value = "MYKL")]
    [IsoId("_aokfNNp-Ed-ak6NoX_4Aeg_627416789")]
    [Description(@"Code for Kuala Lumpur.")]
    KualaLumpur,
    
    /// <summary>
    /// Code for Mexico City.
    /// Encoded/decoded by serializers as &quot;MXMC&quot;.
    /// </summary>
    [EnumMember(Value = "MXMC")]
    [IsoId("_aokfNdp-Ed-ak6NoX_4Aeg_627416790")]
    [Description(@"Code for Mexico City.")]
    MexicoCity,
    
    /// <summary>
    /// Code for Amsterdam.
    /// Encoded/decoded by serializers as &quot;NLAM&quot;.
    /// </summary>
    [EnumMember(Value = "NLAM")]
    [IsoId("_aokfNtp-Ed-ak6NoX_4Aeg_627416791")]
    [Description(@"Code for Amsterdam.")]
    Amsterdam,
    
    /// <summary>
    /// Code for Oslo.
    /// Encoded/decoded by serializers as &quot;NOOS&quot;.
    /// </summary>
    [EnumMember(Value = "NOOS")]
    [IsoId("_aokfN9p-Ed-ak6NoX_4Aeg_627416792")]
    [Description(@"Code for Oslo.")]
    Oslo,
    
    /// <summary>
    /// Code for New York Fed.
    /// Encoded/decoded by serializers as &quot;NYFD&quot;.
    /// </summary>
    [EnumMember(Value = "NYFD")]
    [IsoId("_aokfONp-Ed-ak6NoX_4Aeg_627416793")]
    [Description(@"Code for New York Fed.")]
    NewYorkFed,
    
    /// <summary>
    /// Code for New York Stock Exchange.
    /// Encoded/decoded by serializers as &quot;NYSE&quot;.
    /// </summary>
    [EnumMember(Value = "NYSE")]
    [IsoId("_aokfOdp-Ed-ak6NoX_4Aeg_627416794")]
    [Description(@"Code for New York Stock Exchange.")]
    NewYorkStockExchange,
    
    /// <summary>
    /// Code for Auckland.
    /// Encoded/decoded by serializers as &quot;NZAU&quot;.
    /// </summary>
    [EnumMember(Value = "NZAU")]
    [IsoId("_aouQMNp-Ed-ak6NoX_4Aeg_627416803")]
    [Description(@"Code for Auckland.")]
    Auckland,
    
    /// <summary>
    /// Code for Wellington.
    /// Encoded/decoded by serializers as &quot;NZWE&quot;.
    /// </summary>
    [EnumMember(Value = "NZWE")]
    [IsoId("_aouQMdp-Ed-ak6NoX_4Aeg_627416804")]
    [Description(@"Code for Wellington.")]
    Wellington,
    
    /// <summary>
    /// Code for Panama City.
    /// Encoded/decoded by serializers as &quot;PAPC&quot;.
    /// </summary>
    [EnumMember(Value = "PAPC")]
    [IsoId("_aouQMtp-Ed-ak6NoX_4Aeg_627416805")]
    [Description(@"Code for Panama City.")]
    PanamaCity,
    
    /// <summary>
    /// Code for Manila.
    /// Encoded/decoded by serializers as &quot;PHMA&quot;.
    /// </summary>
    [EnumMember(Value = "PHMA")]
    [IsoId("_aouQM9p-Ed-ak6NoX_4Aeg_627416806")]
    [Description(@"Code for Manila.")]
    Manila,
    
    /// <summary>
    /// Code for Warsaw.
    /// Encoded/decoded by serializers as &quot;PLWA&quot;.
    /// </summary>
    [EnumMember(Value = "PLWA")]
    [IsoId("_aouQNNp-Ed-ak6NoX_4Aeg_627416807")]
    [Description(@"Code for Warsaw.")]
    Warsaw,
    
    /// <summary>
    /// Code for Lisbon.
    /// Encoded/decoded by serializers as &quot;PTLI&quot;.
    /// </summary>
    [EnumMember(Value = "PTLI")]
    [IsoId("_aouQNdp-Ed-ak6NoX_4Aeg_627416808")]
    [Description(@"Code for Lisbon.")]
    Lisbon,
    
    /// <summary>
    /// Code for Moscow.
    /// Encoded/decoded by serializers as &quot;RUMO&quot;.
    /// </summary>
    [EnumMember(Value = "RUMO")]
    [IsoId("_aouQNtp-Ed-ak6NoX_4Aeg_627416809")]
    [Description(@"Code for Moscow.")]
    Moscow,
    
    /// <summary>
    /// Code for Riyadh.
    /// Encoded/decoded by serializers as &quot;SARI&quot;.
    /// </summary>
    [EnumMember(Value = "SARI")]
    [IsoId("_aouQN9p-Ed-ak6NoX_4Aeg_627416810")]
    [Description(@"Code for Riyadh.")]
    Riyadh,
    
    /// <summary>
    /// Code for Stockholm.
    /// Encoded/decoded by serializers as &quot;SEST&quot;.
    /// </summary>
    [EnumMember(Value = "SEST")]
    [IsoId("_aouQONp-Ed-ak6NoX_4Aeg_627416811")]
    [Description(@"Code for Stockholm.")]
    Stockholm,
    
    /// <summary>
    /// Code for Singapore.
    /// Encoded/decoded by serializers as &quot;SGSI&quot;.
    /// </summary>
    [EnumMember(Value = "SGSI")]
    [IsoId("_aouQOdp-Ed-ak6NoX_4Aeg_627416812")]
    [Description(@"Code for Singapore.")]
    Singapore,
    
    /// <summary>
    /// Code for Bangkok.
    /// Encoded/decoded by serializers as &quot;THBA&quot;.
    /// </summary>
    [EnumMember(Value = "THBA")]
    [IsoId("_ao3aINp-Ed-ak6NoX_4Aeg_627416820")]
    [Description(@"Code for Bangkok.")]
    Bangkok,
    
    /// <summary>
    /// Code for Taipei.
    /// Encoded/decoded by serializers as &quot;TWTA&quot;.
    /// </summary>
    [EnumMember(Value = "TWTA")]
    [IsoId("_ao3aIdp-Ed-ak6NoX_4Aeg_627416821")]
    [Description(@"Code for Taipei.")]
    Taipei,
    
    /// <summary>
    /// Code for Ankara.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ao3aItp-Ed-ak6NoX_4Aeg_627416822")]
    [Description(@"Code for Ankara.")]
    Ankara,
    
    /// <summary>
    /// Code for Chicago.
    /// Encoded/decoded by serializers as &quot;USCH&quot;.
    /// </summary>
    [EnumMember(Value = "USCH")]
    [IsoId("_ao3aI9p-Ed-ak6NoX_4Aeg_627416823")]
    [Description(@"Code for Chicago.")]
    Chicago,
    
    /// <summary>
    /// Code for Los Angeles.
    /// Encoded/decoded by serializers as &quot;USLA&quot;.
    /// </summary>
    [EnumMember(Value = "USLA")]
    [IsoId("_ao3aJNp-Ed-ak6NoX_4Aeg_627416824")]
    [Description(@"Code for Los Angeles.")]
    LosAngeles,
    
    /// <summary>
    /// Code for U.S. Government Securities.
    /// Encoded/decoded by serializers as &quot;USGS&quot;.
    /// </summary>
    [EnumMember(Value = "USGS")]
    [IsoId("_ao3aJdp-Ed-ak6NoX_4Aeg_627416825")]
    [Description(@"Code for U.S. Government Securities.")]
    USGovernmentSecurities,
    
    /// <summary>
    /// Code for New York.
    /// Encoded/decoded by serializers as &quot;USNY&quot;.
    /// </summary>
    [EnumMember(Value = "USNY")]
    [IsoId("_ao3aJtp-Ed-ak6NoX_4Aeg_627416834")]
    [Description(@"Code for New York.")]
    NewYork,
    
    /// <summary>
    /// Code for Johannesburg.
    /// Encoded/decoded by serializers as &quot;ZAJO&quot;.
    /// </summary>
    [EnumMember(Value = "ZAJO")]
    [IsoId("_ao3aJ9p-Ed-ak6NoX_4Aeg_627416835")]
    [Description(@"Code for Johannesburg.")]
    Johannesburg,
    
    /// <summary>
    /// Code for Zurich.
    /// Encoded/decoded by serializers as &quot;CHZU&quot;.
    /// </summary>
    [EnumMember(Value = "CHZU")]
    [IsoId("_ao3aKNp-Ed-ak6NoX_4Aeg_627416836")]
    [Description(@"Code for Zurich.")]
    Zurich,
    
}
