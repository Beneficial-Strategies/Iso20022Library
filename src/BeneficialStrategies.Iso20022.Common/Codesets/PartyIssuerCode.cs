// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the institution having originated a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VtaMxtp-Ed-ak6NoX_4Aeg_335333605")]
[Description(@"Identifies the institution having originated a party.")]
[DerivedFrom(typeof(IssuerCode))]
public enum PartyIssuerCode
{
    /// <summary>
    /// Based in Luxembourg, the holding, clearing and settlement agency for certain international securities, especially Eurobonds.
    /// Encoded/decoded by serializers as &quot;CEDE&quot;.
    /// </summary>
    [EnumMember(Value = "CEDE")]
    [IsoId("_VtaMx9p-Ed-ak6NoX_4Aeg_335333606")]
    [Description(@"Based in Luxembourg, the holding, clearing and settlement agency for certain international securities, especially Eurobonds.")]
    ClearstreamBankLuxemburg = IssuerCode.ClearstreamBankLuxemburg, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Caja de Valores S.A.
    /// Encoded/decoded by serializers as &quot;CAVL&quot;.
    /// </summary>
    [EnumMember(Value = "CAVL")]
    [IsoId("_VtaMyNp-Ed-ak6NoX_4Aeg_335333607")]
    [Description(@"Caja de Valores S.A.")]
    CajaDeValores = IssuerCode.CajaDeValores, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Austraclear Limited.
    /// Encoded/decoded by serializers as &quot;ACLR&quot;.
    /// </summary>
    [EnumMember(Value = "ACLR")]
    [IsoId("_VtaMydp-Ed-ak6NoX_4Aeg_335333608")]
    [Description(@"Austraclear Limited.")]
    AustraclearLtd = IssuerCode.AustraclearLtd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Australian Bank State Branch Code.
    /// Encoded/decoded by serializers as &quot;AUAU&quot;.
    /// </summary>
    [EnumMember(Value = "AUAU")]
    [IsoId("_Vtj9wNp-Ed-ak6NoX_4Aeg_335333617")]
    [Description(@"Australian Bank State Branch Code.")]
    AustralianBankStateBranch = IssuerCode.AustralianBankStateBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing House Electronic Settlements Systems.
    /// Encoded/decoded by serializers as &quot;CHES&quot;.
    /// </summary>
    [EnumMember(Value = "CHES")]
    [IsoId("_Vtj9wdp-Ed-ak6NoX_4Aeg_335333618")]
    [Description(@"Clearing House Electronic Settlements Systems.")]
    ClearingHouseElectronicSettlementSystems = IssuerCode.ClearingHouseElectronicSettlementSystems, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Austrian Bankleitzahl.
    /// Encoded/decoded by serializers as &quot;ATAT&quot;.
    /// </summary>
    [EnumMember(Value = "ATAT")]
    [IsoId("_Vtj9wtp-Ed-ak6NoX_4Aeg_335333619")]
    [Description(@"Austrian Bankleitzahl.")]
    AustrianBankLeitzahl = IssuerCode.AustrianBankLeitzahl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// OKB - Oesterreichische Kontrollbank AG.
    /// Encoded/decoded by serializers as &quot;OEKO&quot;.
    /// </summary>
    [EnumMember(Value = "OEKO")]
    [IsoId("_Vtj9w9p-Ed-ak6NoX_4Aeg_335333620")]
    [Description(@"OKB - Oesterreichische Kontrollbank AG.")]
    OesterreichischeKontrollbank = IssuerCode.OesterreichischeKontrollbank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CIK - Caisse Interprofessionelle de Depots et de Virements de Titres S.A.
    /// Encoded/decoded by serializers as &quot;CIKB&quot;.
    /// </summary>
    [EnumMember(Value = "CIKB")]
    [IsoId("_Vtj9xNp-Ed-ak6NoX_4Aeg_335333621")]
    [Description(@"CIK - Caisse Interprofessionelle de Depots et de Virements de Titres S.A.")]
    CaisseInterprofessionelleDepotsVirementsTitres = IssuerCode.CaisseInterprofessionelleDepotsVirementsTitres, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Euroclear.
    /// Encoded/decoded by serializers as &quot;EOCC&quot;.
    /// </summary>
    [EnumMember(Value = "EOCC")]
    [IsoId("_Vtj9xdp-Ed-ak6NoX_4Aeg_335333622")]
    [Description(@"Euroclear.")]
    Euroclear = IssuerCode.Euroclear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Banque Nationale de Belgique.
    /// Encoded/decoded by serializers as &quot;NBBE&quot;.
    /// </summary>
    [EnumMember(Value = "NBBE")]
    [IsoId("_Vtj9xtp-Ed-ak6NoX_4Aeg_335333623")]
    [Description(@"Banque Nationale de Belgique.")]
    BanqueNationaleDeBelgique = IssuerCode.BanqueNationaleDeBelgique, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CLC - Camara de Liquidacao e Custodia S.A. (Brazil).
    /// Encoded/decoded by serializers as &quot;CLCB&quot;.
    /// </summary>
    [EnumMember(Value = "CLCB")]
    [IsoId("_Vtj9x9p-Ed-ak6NoX_4Aeg_335333624")]
    [Description(@"CLC - Camara de Liquidacao e Custodia S.A. (Brazil).")]
    CamaraLiquidacaoCustodia = IssuerCode.CamaraLiquidacaoCustodia, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CDS - Canadian Depository for Securities Limited.
    /// Encoded/decoded by serializers as &quot;CDSL&quot;.
    /// </summary>
    [EnumMember(Value = "CDSL")]
    [IsoId("_Vtj9yNp-Ed-ak6NoX_4Aeg_335333625")]
    [Description(@"CDS - Canadian Depository for Securities Limited.")]
    CanadianDepositorySecuritiesLtd = IssuerCode.CanadianDepositorySecuritiesLtd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Canadian Payments Association Payment Routing Number.
    /// Encoded/decoded by serializers as &quot;CACC&quot;.
    /// </summary>
    [EnumMember(Value = "CACC")]
    [IsoId("_Vtj9ydp-Ed-ak6NoX_4Aeg_335333626")]
    [Description(@"Canadian Payments Association Payment Routing Number.")]
    CanadianPaymentsAssociation = IssuerCode.CanadianPaymentsAssociation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Chile Central Securities Depository Deposito Central de Valores.
    /// Encoded/decoded by serializers as &quot;CSDD&quot;.
    /// </summary>
    [EnumMember(Value = "CSDD")]
    [IsoId("_Vtj9ytp-Ed-ak6NoX_4Aeg_335333634")]
    [Description(@"Chile Central Securities Depository Deposito Central de Valores.")]
    CentralSecuritiesDepositoryDepositoCentralValores = IssuerCode.CentralSecuritiesDepositoryDepositoCentralValores, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shanghai Securities Central Clearing &amp; Registration Company.
    /// Encoded/decoded by serializers as &quot;SCRC&quot;.
    /// </summary>
    [EnumMember(Value = "SCRC")]
    [IsoId("_VttHsNp-Ed-ak6NoX_4Aeg_335333635")]
    [Description(@"Shanghai Securities Central Clearing & Registration Company.")]
    ShanghaiSecuritiesCentralClearingRegistrationCompany = IssuerCode.ShanghaiSecuritiesCentralClearingRegistrationCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shenzhen Securities Clearing Company.
    /// Encoded/decoded by serializers as &quot;SSCC&quot;.
    /// </summary>
    [EnumMember(Value = "SSCC")]
    [IsoId("_VttHsdp-Ed-ak6NoX_4Aeg_335333636")]
    [Description(@"Shenzhen Securities Clearing Company.")]
    ShenzhenSecuritiesClearingCompany = IssuerCode.ShenzhenSecuritiesClearingCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Colombia Central Depository System.
    /// Encoded/decoded by serializers as &quot;CDSY&quot;.
    /// </summary>
    [EnumMember(Value = "CDSY")]
    [IsoId("_VttHstp-Ed-ak6NoX_4Aeg_335333637")]
    [Description(@"Colombia Central Depository System.")]
    ColombiaCentralDepositorySystem = IssuerCode.ColombiaCentralDepositorySystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Denmark Vaerdipapircentralen.
    /// Encoded/decoded by serializers as &quot;VPDK&quot;.
    /// </summary>
    [EnumMember(Value = "VPDK")]
    [IsoId("_VttHs9p-Ed-ak6NoX_4Aeg_335333638")]
    [Description(@"Denmark Vaerdipapircentralen.")]
    DenmarkVaerdipapircentralen = IssuerCode.DenmarkVaerdipapircentralen, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Finnish Central Securities Depository Limited.
    /// Encoded/decoded by serializers as &quot;APKE&quot;.
    /// </summary>
    [EnumMember(Value = "APKE")]
    [IsoId("_VttHtNp-Ed-ak6NoX_4Aeg_335333639")]
    [Description(@"Finnish Central Securities Depository Limited.")]
    FinnishCentralSecuritiesDepositoryLtd = IssuerCode.FinnishCentralSecuritiesDepositoryLtd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// French R.I.B.
    /// Encoded/decoded by serializers as &quot;FRRI&quot;.
    /// </summary>
    [EnumMember(Value = "FRRI")]
    [IsoId("_VttHtdp-Ed-ak6NoX_4Aeg_335333648")]
    [Description(@"French R.I.B.")]
    FranceRIB = IssuerCode.FranceRIB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Societe Interprofessional Pour La Compensation des Valeurs Mobiliers in France.
    /// Encoded/decoded by serializers as &quot;SICV&quot;.
    /// </summary>
    [EnumMember(Value = "SICV")]
    [IsoId("_VttHttp-Ed-ak6NoX_4Aeg_335333649")]
    [Description(@"Societe Interprofessional Pour La Compensation des Valeurs Mobiliers in France.")]
    SICOVAM = IssuerCode.SICOVAM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Prague Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XPRA&quot;.
    /// </summary>
    [EnumMember(Value = "XPRA")]
    [IsoId("_VttHt9p-Ed-ak6NoX_4Aeg_335333650")]
    [Description(@"The Prague Stock Exchange.")]
    PragueStockExchange = IssuerCode.PragueStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bundesausichtsamt fur den Wertpapierhandel.
    /// Encoded/decoded by serializers as &quot;BUWE&quot;.
    /// </summary>
    [EnumMember(Value = "BUWE")]
    [IsoId("_VttHuNp-Ed-ak6NoX_4Aeg_335333651")]
    [Description(@"Bundesausichtsamt fur den Wertpapierhandel.")]
    BundesausichtsamtWertpapierhandel = IssuerCode.BundesausichtsamtWertpapierhandel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deutsche Boerse AG: Deutsche Terminborse.
    /// Encoded/decoded by serializers as &quot;XDTB&quot;.
    /// </summary>
    [EnumMember(Value = "XDTB")]
    [IsoId("_VttHudp-Ed-ak6NoX_4Aeg_335333652")]
    [Description(@"Deutsche Boerse AG: Deutsche Terminborse.")]
    DeutscheBoerseAGDeutscheTerminborse = IssuerCode.DeutscheBoerseAGDeutscheTerminborse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deutsche Boerse AG: Frankfurter Wertpapierborse.
    /// Encoded/decoded by serializers as &quot;XFRA&quot;.
    /// </summary>
    [EnumMember(Value = "XFRA")]
    [IsoId("_Vt24sNp-Ed-ak6NoX_4Aeg_335333653")]
    [Description(@"Deutsche Boerse AG: Frankfurter Wertpapierborse.")]
    DeutscheBoerseAGFrankfurterWertpapierborse = IssuerCode.DeutscheBoerseAGFrankfurterWertpapierborse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deutsche Boerse AG: XETRA (exchange electronic trading).
    /// Encoded/decoded by serializers as &quot;XETR&quot;.
    /// </summary>
    [EnumMember(Value = "XETR")]
    [IsoId("_Vt24sdp-Ed-ak6NoX_4Aeg_335333654")]
    [Description(@"Deutsche Boerse AG: XETRA (exchange electronic trading).")]
    DeutscheBoerseAGXETRA = IssuerCode.DeutscheBoerseAGXETRA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deutsche Borse Clearing AG.
    /// Encoded/decoded by serializers as &quot;DAKV&quot;.
    /// </summary>
    [EnumMember(Value = "DAKV")]
    [IsoId("_Vt24stp-Ed-ak6NoX_4Aeg_335333655")]
    [Description(@"Deutsche Borse Clearing AG.")]
    DeutscheBorseClearingAG = IssuerCode.DeutscheBorseClearingAG, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deutsche Bundesbank.
    /// Encoded/decoded by serializers as &quot;MARK&quot;.
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_Vt24s9p-Ed-ak6NoX_4Aeg_335333656")]
    [Description(@"Deutsche Bundesbank.")]
    DeutscheBundesbank = IssuerCode.DeutscheBundesbank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// German Bankleitzahl.
    /// Encoded/decoded by serializers as &quot;DEBL&quot;.
    /// </summary>
    [EnumMember(Value = "DEBL")]
    [IsoId("_Vt24tNp-Ed-ak6NoX_4Aeg_335333657")]
    [Description(@"German Bankleitzahl.")]
    GermanBankleitzahl = IssuerCode.GermanBankleitzahl, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Zentraler Kreditausschuss.
    /// Encoded/decoded by serializers as &quot;ZEKR&quot;.
    /// </summary>
    [EnumMember(Value = "ZEKR")]
    [IsoId("_Vt24tdp-Ed-ak6NoX_4Aeg_335333665")]
    [Description(@"Zentraler Kreditausschuss.")]
    ZentralerKreditausschuss = IssuerCode.ZentralerKreditausschuss, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hong KongCentral Clearing and Securities Settlement System.
    /// Encoded/decoded by serializers as &quot;CCAS&quot;.
    /// </summary>
    [EnumMember(Value = "CCAS")]
    [IsoId("_Vt24ttp-Ed-ak6NoX_4Aeg_335333666")]
    [Description(@"Hong KongCentral Clearing and Securities Settlement System.")]
    HongKongCentralClearingSecuritiesSettlementSystem = IssuerCode.HongKongCentralClearingSecuritiesSettlementSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hong Kong National Clearing System.
    /// Encoded/decoded by serializers as &quot;HKCH&quot;.
    /// </summary>
    [EnumMember(Value = "HKCH")]
    [IsoId("_Vt24t9p-Ed-ak6NoX_4Aeg_335333667")]
    [Description(@"Hong Kong National Clearing System.")]
    HongKongNationalClearing = IssuerCode.HongKongNationalClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// India National Securities Depositary.
    /// Encoded/decoded by serializers as &quot;NSDL&quot;.
    /// </summary>
    [EnumMember(Value = "NSDL")]
    [IsoId("_Vt24uNp-Ed-ak6NoX_4Aeg_335333668")]
    [Description(@"India National Securities Depositary.")]
    IndianNationalSecuritiesDepository = IssuerCode.IndianNationalSecuritiesDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indonesian Securities Central Depository.
    /// Encoded/decoded by serializers as &quot;KDEI&quot;.
    /// </summary>
    [EnumMember(Value = "KDEI")]
    [IsoId("_Vt24udp-Ed-ak6NoX_4Aeg_335333669")]
    [Description(@"Indonesian Securities Central Depository.")]
    IndonesianSecuritiesCentralDepository = IssuerCode.IndonesianSecuritiesCentralDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Irish National Clearing Code.
    /// Encoded/decoded by serializers as &quot;IESC&quot;.
    /// </summary>
    [EnumMember(Value = "IESC")]
    [IsoId("_Vt24utp-Ed-ak6NoX_4Aeg_335333670")]
    [Description(@"Irish National Clearing Code.")]
    IrishNationalClearing = IssuerCode.IrishNationalClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Israel Tel Aviv Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XTAE&quot;.
    /// </summary>
    [EnumMember(Value = "XTAE")]
    [IsoId("_VuApsNp-Ed-ak6NoX_4Aeg_335333679")]
    [Description(@"Israel Tel Aviv Stock Exchange.")]
    TelAvivStockExchange = IssuerCode.TelAvivStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Italian Domestic Identification Code.
    /// Encoded/decoded by serializers as &quot;ITIT&quot;.
    /// </summary>
    [EnumMember(Value = "ITIT")]
    [IsoId("_VuApsdp-Ed-ak6NoX_4Aeg_335333680")]
    [Description(@"Italian Domestic Identification Code.")]
    ItalianDomesticIdentification = IssuerCode.ItalianDomesticIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Italy - Monte Titoli.
    /// Encoded/decoded by serializers as &quot;MOTI&quot;.
    /// </summary>
    [EnumMember(Value = "MOTI")]
    [IsoId("_VuApstp-Ed-ak6NoX_4Aeg_335333681")]
    [Description(@"Italy - Monte Titoli.")]
    MonteTitoli = IssuerCode.MonteTitoli, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Japan Securities Clearing Corporation.
    /// Encoded/decoded by serializers as &quot;JSCC&quot;.
    /// </summary>
    [EnumMember(Value = "JSCC")]
    [IsoId("_VuAps9p-Ed-ak6NoX_4Aeg_335333682")]
    [Description(@"Japan Securities Clearing Corporation.")]
    JapanSecuritiesClearingCorporation = IssuerCode.JapanSecuritiesClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Japan Securities Depository Center.
    /// Encoded/decoded by serializers as &quot;JSDC&quot;.
    /// </summary>
    [EnumMember(Value = "JSDC")]
    [IsoId("_VuAptNp-Ed-ak6NoX_4Aeg_335333683")]
    [Description(@"Japan Securities Depository Center.")]
    JapanSecuritiesDepositoryCenter = IssuerCode.JapanSecuritiesDepositoryCenter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Korea Securities Depository.
    /// Encoded/decoded by serializers as &quot;KSDC&quot;.
    /// </summary>
    [EnumMember(Value = "KSDC")]
    [IsoId("_VuAptdp-Ed-ak6NoX_4Aeg_335333684")]
    [Description(@"Korea Securities Depository.")]
    KoreanSecuritiesDepository = IssuerCode.KoreanSecuritiesDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Malaysian Central Depositary.
    /// Encoded/decoded by serializers as &quot;MCDY&quot;.
    /// </summary>
    [EnumMember(Value = "MCDY")]
    [IsoId("_VuApttp-Ed-ak6NoX_4Aeg_335333685")]
    [Description(@"Malaysian Central Depositary.")]
    MalaysianCentralDepository = IssuerCode.MalaysianCentralDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mexico S.D. Indeval, S.A. de C.V.
    /// Encoded/decoded by serializers as &quot;INDE&quot;.
    /// </summary>
    [EnumMember(Value = "INDE")]
    [IsoId("_VuApt9p-Ed-ak6NoX_4Aeg_335333686")]
    [Description(@"Mexico S.D. Indeval, S.A. de C.V.")]
    IndevalSA = IssuerCode.IndevalSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amsterdamse Effectenbeurs.
    /// Encoded/decoded by serializers as &quot;XAMS&quot;.
    /// </summary>
    [EnumMember(Value = "XAMS")]
    [IsoId("_VuApuNp-Ed-ak6NoX_4Aeg_335333687")]
    [Description(@"Amsterdamse Effectenbeurs.")]
    AmsterdamseEffectenbeurs = IssuerCode.AmsterdamseEffectenbeurs, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Nederlands Centraal Instituut voor Giraal Effectenverkeer.
    /// Encoded/decoded by serializers as &quot;NECI&quot;.
    /// </summary>
    [EnumMember(Value = "NECI")]
    [IsoId("_VuApudp-Ed-ak6NoX_4Aeg_335333688")]
    [Description(@"Nederlands Centraal Instituut voor Giraal Effectenverkeer.")]
    NECIGEF = IssuerCode.NECIGEF, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New Zealand National Clearing Code.
    /// Encoded/decoded by serializers as &quot;NZBA&quot;.
    /// </summary>
    [EnumMember(Value = "NZBA")]
    [IsoId("_VuJzoNp-Ed-ak6NoX_4Aeg_335333696")]
    [Description(@"New Zealand National Clearing Code.")]
    NewZealandNationalClearing = IssuerCode.NewZealandNationalClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New Zealand Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XNZE&quot;.
    /// </summary>
    [EnumMember(Value = "XNZE")]
    [IsoId("_VuJzodp-Ed-ak6NoX_4Aeg_335333697")]
    [Description(@"New Zealand Stock Exchange.")]
    NewZealandStockExchange = IssuerCode.NewZealandStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Norway Verdipapirsentralen.
    /// Encoded/decoded by serializers as &quot;VPSN&quot;.
    /// </summary>
    [EnumMember(Value = "VPSN")]
    [IsoId("_VuJzotp-Ed-ak6NoX_4Aeg_335333698")]
    [Description(@"Norway Verdipapirsentralen.")]
    Verdipapirsentralen = IssuerCode.Verdipapirsentralen, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Philippine Central Depositary.
    /// Encoded/decoded by serializers as &quot;PCDY&quot;.
    /// </summary>
    [EnumMember(Value = "PCDY")]
    [IsoId("_VuJzo9p-Ed-ak6NoX_4Aeg_335333699")]
    [Description(@"Philippine Central Depositary.")]
    PhilippineCentralDepository = IssuerCode.PhilippineCentralDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Poland National Depository for Securities.
    /// Encoded/decoded by serializers as &quot;KDPW&quot;.
    /// </summary>
    [EnumMember(Value = "KDPW")]
    [IsoId("_VuJzpNp-Ed-ak6NoX_4Aeg_335333700")]
    [Description(@"Poland National Depository for Securities.")]
    PolandNationalDepositorySecurities = IssuerCode.PolandNationalDepositorySecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portugal Central de Valores de Mobiliaros.
    /// Encoded/decoded by serializers as &quot;CVMP&quot;.
    /// </summary>
    [EnumMember(Value = "CVMP")]
    [IsoId("_VuJzpdp-Ed-ak6NoX_4Aeg_335333701")]
    [Description(@"Portugal Central de Valores de Mobiliaros.")]
    CentralValoresMobiliaros = IssuerCode.CentralValoresMobiliaros, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Portuguese National Clearing Code.
    /// Encoded/decoded by serializers as &quot;PTIF&quot;.
    /// </summary>
    [EnumMember(Value = "PTIF")]
    [IsoId("_VuJzptp-Ed-ak6NoX_4Aeg_335333710")]
    [Description(@"Portuguese National Clearing Code.")]
    PortugueseNationalClearing = IssuerCode.PortugueseNationalClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Associacao para a Prestacao de Servicios as Bolsas de Valores.
    /// Encoded/decoded by serializers as &quot;XCVM&quot;.
    /// </summary>
    [EnumMember(Value = "XCVM")]
    [IsoId("_VuJzp9p-Ed-ak6NoX_4Aeg_335333711")]
    [Description(@"Associacao para a Prestacao de Servicios as Bolsas de Valores.")]
    INTERBOLSA = IssuerCode.INTERBOLSA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Russian Central Bank Identification Code.
    /// Encoded/decoded by serializers as &quot;RUIC&quot;.
    /// </summary>
    [EnumMember(Value = "RUIC")]
    [IsoId("_VuJzqNp-Ed-ak6NoX_4Aeg_335333712")]
    [Description(@"Russian Central Bank Identification Code.")]
    RussianCentralBankIdentification = IssuerCode.RussianCentralBankIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central Depository Pte Ltd.
    /// Encoded/decoded by serializers as &quot;CDPL&quot;.
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_VuJzqdp-Ed-ak6NoX_4Aeg_335333713")]
    [Description(@"Central Depository Pte Ltd.")]
    SingaporeCentralDepositoryLtd = IssuerCode.SingaporeCentralDepositoryLtd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Singapore International Monetary Exchange Limited.
    /// Encoded/decoded by serializers as &quot;XSIM&quot;.
    /// </summary>
    [EnumMember(Value = "XSIM")]
    [IsoId("_VuTkoNp-Ed-ak6NoX_4Aeg_335333714")]
    [Description(@"Singapore International Monetary Exchange Limited.")]
    SingaporeInternationalMonetaryExchange = IssuerCode.SingaporeInternationalMonetaryExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Bratislava Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XBRA&quot;.
    /// </summary>
    [EnumMember(Value = "XBRA")]
    [IsoId("_VuTkodp-Ed-ak6NoX_4Aeg_335333715")]
    [Description(@"The Bratislava Stock Exchange.")]
    BratislavaStockExchange = IssuerCode.BratislavaStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// South African National Clearing Code.
    /// Encoded/decoded by serializers as &quot;ZABS&quot;.
    /// </summary>
    [EnumMember(Value = "ZABS")]
    [IsoId("_VuTkotp-Ed-ak6NoX_4Aeg_335333716")]
    [Description(@"South African National Clearing Code.")]
    SouthAfricanNationalClearing = IssuerCode.SouthAfricanNationalClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Strate Clearing and Settlement (Proprietary) Limited.
    /// Encoded/decoded by serializers as &quot;STRA&quot;.
    /// </summary>
    [EnumMember(Value = "STRA")]
    [IsoId("_VuTko9p-Ed-ak6NoX_4Aeg_335333717")]
    [Description(@"Strate Clearing and Settlement (Proprietary) Limited.")]
    StrateClearingSettlementLtd = IssuerCode.StrateClearingSettlementLtd, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Banco de Espana.
    /// Encoded/decoded by serializers as &quot;ESPB&quot;.
    /// </summary>
    [EnumMember(Value = "ESPB")]
    [IsoId("_VuTkpNp-Ed-ak6NoX_4Aeg_335333718")]
    [Description(@"Banco de Espana.")]
    BancoEspana = IssuerCode.BancoEspana, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Servicio de Compensacion y Liquidacion de Valores.
    /// Encoded/decoded by serializers as &quot;SCLV&quot;.
    /// </summary>
    [EnumMember(Value = "SCLV")]
    [IsoId("_VuTkpdp-Ed-ak6NoX_4Aeg_335333719")]
    [Description(@"Servicio de Compensacion y Liquidacion de Valores.")]
    ServicioCompensacionLiquidacionValores = IssuerCode.ServicioCompensacionLiquidacionValores, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Spanish Domestic Interbanking Code.
    /// Encoded/decoded by serializers as &quot;ESES&quot;.
    /// </summary>
    [EnumMember(Value = "ESES")]
    [IsoId("_VuTkptp-Ed-ak6NoX_4Aeg_335333727")]
    [Description(@"Spanish Domestic Interbanking Code.")]
    SpanishDomesticInterbanking = IssuerCode.SpanishDomesticInterbanking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sweden Vardepapperscentralen.
    /// Encoded/decoded by serializers as &quot;VPCS&quot;.
    /// </summary>
    [EnumMember(Value = "VPCS")]
    [IsoId("_VuTkp9p-Ed-ak6NoX_4Aeg_335333728")]
    [Description(@"Sweden Vardepapperscentralen.")]
    Vardepapperscentralen = IssuerCode.Vardepapperscentralen, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SIS - SEGA/Intersettle.
    /// Encoded/decoded by serializers as &quot;SCOM&quot;.
    /// </summary>
    [EnumMember(Value = "SCOM")]
    [IsoId("_VuTkqNp-Ed-ak6NoX_4Aeg_335333729")]
    [Description(@"SIS - SEGA/Intersettle.")]
    SISSEGAIntersettle = IssuerCode.SISSEGAIntersettle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Swiss Clearing System.
    /// Encoded/decoded by serializers as &quot;CHSW&quot;.
    /// </summary>
    [EnumMember(Value = "CHSW")]
    [IsoId("_VuTkqdp-Ed-ak6NoX_4Aeg_335333730")]
    [Description(@"Swiss Clearing System.")]
    SwissClearingCode = IssuerCode.SwissClearingCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Thailand Securities Depository Company Limited.
    /// Encoded/decoded by serializers as &quot;TSDC&quot;.
    /// </summary>
    [EnumMember(Value = "TSDC")]
    [IsoId("_VuTkqtp-Ed-ak6NoX_4Aeg_335333731")]
    [Description(@"Thailand Securities Depository Company Limited.")]
    ThailandSecuritiesDepositoryCompany = IssuerCode.ThailandSecuritiesDepositoryCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Taiwan Securities Central Depository Co Limited.
    /// Encoded/decoded by serializers as &quot;TSCD&quot;.
    /// </summary>
    [EnumMember(Value = "TSCD")]
    [IsoId("_VudVoNp-Ed-ak6NoX_4Aeg_335333732")]
    [Description(@"Taiwan Securities Central Depository Co Limited.")]
    TaiwanSecuritiesCentralDepository = IssuerCode.TaiwanSecuritiesCentralDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Turkey Takasbank.
    /// Encoded/decoded by serializers as &quot;TVSB&quot;.
    /// </summary>
    [EnumMember(Value = "TVSB")]
    [IsoId("_VudVodp-Ed-ak6NoX_4Aeg_335333741")]
    [Description(@"Turkey Takasbank.")]
    Takasbank = IssuerCode.Takasbank, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// UK Domestic Sort Code.
    /// Encoded/decoded by serializers as &quot;GBSC&quot;.
    /// </summary>
    [EnumMember(Value = "GBSC")]
    [IsoId("_VudVotp-Ed-ak6NoX_4Aeg_335333742")]
    [Description(@"UK Domestic Sort Code.")]
    UKDomesticSort = IssuerCode.UKDomesticSort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank of England (Central Moneymarkets Office).
    /// Encoded/decoded by serializers as &quot;BKEN&quot;.
    /// </summary>
    [EnumMember(Value = "BKEN")]
    [IsoId("_VudVo9p-Ed-ak6NoX_4Aeg_335333743")]
    [Description(@"Bank of England (Central Moneymarkets Office).")]
    BankOfEnglandCMO = IssuerCode.BankOfEnglandCMO, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CRESTCo Ltd. Company operating two real-time securities settlement services: CREST (for UK, Irish and international securities and government bonds) and CMO (UK money market instrument settlement).
    /// Encoded/decoded by serializers as &quot;CRST&quot;.
    /// </summary>
    [EnumMember(Value = "CRST")]
    [IsoId("_VudVpNp-Ed-ak6NoX_4Aeg_335333744")]
    [Description(@"CRESTCo Ltd. Company operating two real-time securities settlement services: CREST (for UK, Irish and international securities and government bonds) and CMO (UK money market instrument settlement).")]
    CrestCo = IssuerCode.CrestCo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// UK Financial Services Authority.
    /// Encoded/decoded by serializers as &quot;FSAU&quot;.
    /// </summary>
    [EnumMember(Value = "FSAU")]
    [IsoId("_VudVpdp-Ed-ak6NoX_4Aeg_335333745")]
    [Description(@"UK Financial Services Authority.")]
    FinancialServicesAuthority = IssuerCode.FinancialServicesAuthority, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The London Clearing House.
    /// Encoded/decoded by serializers as &quot;LCHL&quot;.
    /// </summary>
    [EnumMember(Value = "LCHL")]
    [IsoId("_VudVptp-Ed-ak6NoX_4Aeg_335333746")]
    [Description(@"The London Clearing House.")]
    LondonClearingHouse = IssuerCode.LondonClearingHouse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// UK - International Securities Market Association.
    /// Encoded/decoded by serializers as &quot;XISM&quot;.
    /// </summary>
    [EnumMember(Value = "XISM")]
    [IsoId("_VudVp9p-Ed-ak6NoX_4Aeg_335333747")]
    [Description(@"UK - International Securities Market Association.")]
    InternationalSecuritiesMarketAssociation = IssuerCode.InternationalSecuritiesMarketAssociation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// London Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XLON&quot;.
    /// </summary>
    [EnumMember(Value = "XLON")]
    [IsoId("_VudVqNp-Ed-ak6NoX_4Aeg_335333748")]
    [Description(@"London Stock Exchange.")]
    LondonStockExchange = IssuerCode.LondonStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// American Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XASE&quot;.
    /// </summary>
    [EnumMember(Value = "XASE")]
    [IsoId("_VudVqdp-Ed-ak6NoX_4Aeg_335333749")]
    [Description(@"American Stock Exchange.")]
    AmericanStockExchange = IssuerCode.AmericanStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Depository Trust Company.
    /// Encoded/decoded by serializers as &quot;DTCC&quot;.
    /// </summary>
    [EnumMember(Value = "DTCC")]
    [IsoId("_VumfkNp-Ed-ak6NoX_4Aeg_335333750")]
    [Description(@"Depository Trust Company.")]
    DepositoryTrustCompany = IssuerCode.DepositoryTrustCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// USA Emerging Markets Clearing Corporation.
    /// Encoded/decoded by serializers as &quot;EMCC&quot;.
    /// </summary>
    [EnumMember(Value = "EMCC")]
    [IsoId("_Vumfkdp-Ed-ak6NoX_4Aeg_335333758")]
    [Description(@"USA Emerging Markets Clearing Corporation.")]
    EmergingMarketsClearingCorporation = IssuerCode.EmergingMarketsClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fedwire Routing Number.
    /// Encoded/decoded by serializers as &quot;USFW&quot;.
    /// </summary>
    [EnumMember(Value = "USFW")]
    [IsoId("_Vumfktp-Ed-ak6NoX_4Aeg_335333759")]
    [Description(@"Fedwire Routing Number.")]
    FedwireRoutingNumber = IssuerCode.FedwireRoutingNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Provider of trade netting and settlement for the US Government securities marketplace.
    /// Encoded/decoded by serializers as &quot;GSCC&quot;.
    /// </summary>
    [EnumMember(Value = "GSCC")]
    [IsoId("_Vumfk9p-Ed-ak6NoX_4Aeg_335333760")]
    [Description(@"Provider of trade netting and settlement for the US Government securities marketplace.")]
    GovernmentSecuritiesClearingCorporation = IssuerCode.GovernmentSecuritiesClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// International Securities Clearing Corporation.
    /// Encoded/decoded by serializers as &quot;ISCC&quot;.
    /// </summary>
    [EnumMember(Value = "ISCC")]
    [IsoId("_VumflNp-Ed-ak6NoX_4Aeg_335333761")]
    [Description(@"International Securities Clearing Corporation.")]
    InternationalSecuritiesClearingCorporation = IssuerCode.InternationalSecuritiesClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mortgage Backed Securities Clearing Corporation.
    /// Encoded/decoded by serializers as &quot;MBSC&quot;.
    /// </summary>
    [EnumMember(Value = "MBSC")]
    [IsoId("_Vumfldp-Ed-ak6NoX_4Aeg_335333762")]
    [Description(@"Mortgage Backed Securities Clearing Corporation.")]
    MortgageBackedSecuritiesClearingCorporation = IssuerCode.MortgageBackedSecuritiesClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National Association Securities Dealers.
    /// Encoded/decoded by serializers as &quot;XNAS&quot;.
    /// </summary>
    [EnumMember(Value = "XNAS")]
    [IsoId("_Vumfltp-Ed-ak6NoX_4Aeg_335333763")]
    [Description(@"National Association Securities Dealers.")]
    NationalAssociationSecuritiesDealers = IssuerCode.NationalAssociationSecuritiesDealers, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National Association of Securities Dealers Automated Quotation Service &quot;NASDAQ&quot; / National Market System.
    /// Encoded/decoded by serializers as &quot;XNMS&quot;.
    /// </summary>
    [EnumMember(Value = "XNMS")]
    [IsoId("_Vumfl9p-Ed-ak6NoX_4Aeg_335333772")]
    [Description(@"National Association of Securities Dealers Automated Quotation Service ""NASDAQ"" / National Market System.")]
    NASDAQ = IssuerCode.NASDAQ, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// National Securities Clearing Corporation.
    /// Encoded/decoded by serializers as &quot;NSCC&quot;.
    /// </summary>
    [EnumMember(Value = "NSCC")]
    [IsoId("_VumfmNp-Ed-ak6NoX_4Aeg_335333773")]
    [Description(@"National Securities Clearing Corporation.")]
    NationalSecuritiesClearingCorporation = IssuerCode.NationalSecuritiesClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New York Clearing House.
    /// Encoded/decoded by serializers as &quot;NYCH&quot;.
    /// </summary>
    [EnumMember(Value = "NYCH")]
    [IsoId("_Vumfmdp-Ed-ak6NoX_4Aeg_335333774")]
    [Description(@"New York Clearing House.")]
    NewYorkClearingHouse = IssuerCode.NewYorkClearingHouse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New York Stock Exchange.
    /// Encoded/decoded by serializers as &quot;XNYS&quot;.
    /// </summary>
    [EnumMember(Value = "XNYS")]
    [IsoId("_Vumfmtp-Ed-ak6NoX_4Aeg_335333775")]
    [Description(@"New York Stock Exchange.")]
    NewYorkStockExchange = IssuerCode.NewYorkStockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Options Clearing Corporation.
    /// Encoded/decoded by serializers as &quot;OCCX&quot;.
    /// </summary>
    [EnumMember(Value = "OCCX")]
    [IsoId("_VuwQkNp-Ed-ak6NoX_4Aeg_335333776")]
    [Description(@"Options Clearing Corporation.")]
    OptionsClearingCorporation = IssuerCode.OptionsClearingCorporation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participant Trust Company.
    /// Encoded/decoded by serializers as &quot;PTCY&quot;.
    /// </summary>
    [EnumMember(Value = "PTCY")]
    [IsoId("_VuwQkdp-Ed-ak6NoX_4Aeg_335333777")]
    [Description(@"Participant Trust Company.")]
    ParticipantTrustCompany = IssuerCode.ParticipantTrustCompany, // same ordinal as derivation source for type conversions
    
}
