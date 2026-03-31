// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a4g_ttp-Ed-ak6NoX_4Aeg_136709281")]
[Description(
    @"Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed."
)]
[DerivedFrom(typeof(CashClearingSystemCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashClearingSystem3Code>))]
#endif
public enum CashClearingSystem3Code
{
    /// <summary>
    /// Scheme code for EBA Euro1/Step1.
    /// Encoded/decoded by serializers as &quot;ABE&quot;.
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_a4qwsNp-Ed-ak6NoX_4Aeg_136709300")]
    [Description(@"Scheme code for EBA Euro1/Step1.")]
    EBAEuro1Step1 = CashClearingSystemCode.EBAEuro1Step1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as &quot;ART&quot;.
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_a4qwsdp-Ed-ak6NoX_4Aeg_136709324")]
    [Description(@"Scheme code for AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian = CashClearingSystemCode.Austrian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as &quot;AVP&quot;.
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_a4qwstp-Ed-ak6NoX_4Aeg_136709341")]
    [Description(@"Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand = CashClearingSystemCode.NewZealand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as &quot;AZM&quot;.
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_a4qws9p-Ed-ak6NoX_4Aeg_136709359")]
    [Description(@"Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan = CashClearingSystemCode.Azerbaijan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as &quot;BAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_a4qwtNp-Ed-ak6NoX_4Aeg_136709376")]
    [Description(@"Scheme code for BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina = CashClearingSystemCode.BosniaHerzegovina, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as &quot;BEL&quot;.
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_a4qwtdp-Ed-ak6NoX_4Aeg_136709394")]
    [Description(@"Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium = CashClearingSystemCode.Belgium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as &quot;BOF&quot;.
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_a4qwttp-Ed-ak6NoX_4Aeg_136709636")]
    [Description(@"Scheme code for FI (Finland) - RTGS (BOF).")]
    Finland = CashClearingSystemCode.Finland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as &quot;BRL&quot;.
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_a4qwt9p-Ed-ak6NoX_4Aeg_136709653")]
    [Description(@"Scheme code for IT (Italy) - Italy RTGS (BIREL).")]
    Italy = CashClearingSystemCode.Italy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).
    /// Encoded/decoded by serializers as &quot;CAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_a4qwuNp-Ed-ak6NoX_4Aeg_136709671")]
    [Description(@"Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).")]
    Canada = CashClearingSystemCode.Canada, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for ES (Spain).
    /// Encoded/decoded by serializers as &quot;CAM&quot;.
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_a4qwudp-Ed-ak6NoX_4Aeg_136709696")]
    [Description(@"Scheme code for ES (Spain).")]
    SpainCAM = CashClearingSystemCode.SpainCAM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as &quot;CBJ&quot;.
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_a4z6oNp-Ed-ak6NoX_4Aeg_136709713")]
    [Description(@"Scheme code for IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland = CashClearingSystemCode.Ireland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as &quot;CHP&quot;.
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_a4z6odp-Ed-ak6NoX_4Aeg_136709731")]
    [Description(@"Scheme code for GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom = CashClearingSystemCode.UnitedKingdom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).
    /// Encoded/decoded by serializers as &quot;DKC&quot;.
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_a4z6otp-Ed-ak6NoX_4Aeg_136709766")]
    [Description(@"Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).")]
    Denmark = CashClearingSystemCode.Denmark, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as &quot;RTP&quot;.
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_a4z6o9p-Ed-ak6NoX_4Aeg_136709774")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyRTGSPlus = CashClearingSystemCode.GermanyRTGSPlus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for EBA Euro1.
    /// Encoded/decoded by serializers as &quot;EBA&quot;.
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_a4z6pNp-Ed-ak6NoX_4Aeg_136709791")]
    [Description(@"Scheme code for EBA Euro1.")]
    EBAEuro1 = CashClearingSystemCode.EBAEuro1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as &quot;ELS&quot;.
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_a4z6pdp-Ed-ak6NoX_4Aeg_136709808")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyELS = CashClearingSystemCode.GermanyELS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for EBA step 1 (members).
    /// Encoded/decoded by serializers as &quot;ERP&quot;.
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_a4z6ptp-Ed-ak6NoX_4Aeg_136710074")]
    [Description(@"Scheme code for EBA step 1 (members).")]
    EBAStep1 = CashClearingSystemCode.EBAStep1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for EBA step 2.
    /// Encoded/decoded by serializers as &quot;XCT&quot;.
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_a4z6p9p-Ed-ak6NoX_4Aeg_136710099")]
    [Description(@"Scheme code for EBA step 2.")]
    EBAStep2 = CashClearingSystemCode.EBAStep2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as &quot;HRK&quot;.
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_a4z6qNp-Ed-ak6NoX_4Aeg_136710116")]
    [Description(@"Scheme code for HR (Croatia) - HSVP.")]
    Croatia = CashClearingSystemCode.Croatia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as &quot;HRM&quot;.
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_a4z6qdp-Ed-ak6NoX_4Aeg_136710134")]
    [Description(@"Scheme code for GR (Greece) - Greek RTGS (HERMES).")]
    Greece = CashClearingSystemCode.Greece, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as &quot;HUF&quot;.
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_a49roNp-Ed-ak6NoX_4Aeg_136710151")]
    [Description(@"Scheme code for HU (Hungary) - VIBER.")]
    Hungary = CashClearingSystemCode.Hungary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as &quot;LGS&quot;.
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_a49rodp-Ed-ak6NoX_4Aeg_136710169")]
    [Description(@"Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg = CashClearingSystemCode.Luxemburg, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for LV (Latvia).
    /// Encoded/decoded by serializers as &quot;LVL&quot;.
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_a49rotp-Ed-ak6NoX_4Aeg_136710194")]
    [Description(@"Scheme code for LV (Latvia).")]
    Latvia = CashClearingSystemCode.Latvia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for MU (Mauritius).
    /// Encoded/decoded by serializers as &quot;MUP&quot;.
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_a49ro9p-Ed-ak6NoX_4Aeg_136710229")]
    [Description(@"Scheme code for MU (Mauritius).")]
    Mauritius = CashClearingSystemCode.Mauritius, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for NO (Norway).
    /// Encoded/decoded by serializers as &quot;NOC&quot;.
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_a49rpNp-Ed-ak6NoX_4Aeg_136710254")]
    [Description(@"Scheme code for NO (Norway).")]
    Norway = CashClearingSystemCode.Norway, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for CH (Switzerland).
    /// Encoded/decoded by serializers as &quot;PCH&quot;.
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_a49rpdp-Ed-ak6NoX_4Aeg_136710271")]
    [Description(@"Scheme code for CH (Switzerland).")]
    Switzerland = CashClearingSystemCode.Switzerland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for AU (Australia).
    /// Encoded/decoded by serializers as &quot;PDS&quot;.
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_a49rptp-Ed-ak6NoX_4Aeg_136710289")]
    [Description(@"Scheme code for AU (Australia).")]
    Australia = CashClearingSystemCode.Australia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for EG (Egypt).
    /// Encoded/decoded by serializers as &quot;PEG&quot;.
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_a49rp9p-Ed-ak6NoX_4Aeg_136710306")]
    [Description(@"Scheme code for EG (Egypt).")]
    Egypt = CashClearingSystemCode.Egypt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for FR (France).
    /// Encoded/decoded by serializers as &quot;PNS&quot;.
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_a49rqNp-Ed-ak6NoX_4Aeg_136710324")]
    [Description(@"Scheme code for FR (France).")]
    FrancePNS = CashClearingSystemCode.FrancePNS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for Ve (Venezuela).
    /// Encoded/decoded by serializers as &quot;PVE&quot;.
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_a49rqdp-Ed-ak6NoX_4Aeg_136710349")]
    [Description(@"Scheme code for Ve (Venezuela).")]
    Venezuela = CashClearingSystemCode.Venezuela, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_a49rqtp-Ed-ak6NoX_4Aeg_136710366")]
    [Description(@"Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC = CashClearingSystemCode.SwedenSEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for SI (Slovenia).
    /// Encoded/decoded by serializers as &quot;SIT&quot;.
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_a5G1kNp-Ed-ak6NoX_4Aeg_136710601")]
    [Description(@"Scheme code for SI (Slovenia).")]
    Slovania = CashClearingSystemCode.Slovania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as &quot;SLB&quot;.
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_a5G1kdp-Ed-ak6NoX_4Aeg_136710626")]
    [Description(@"Scheme code for ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES = CashClearingSystemCode.SpainES, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as &quot;SPG&quot;.
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_a5G1ktp-Ed-ak6NoX_4Aeg_136710643")]
    [Description(@"Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal = CashClearingSystemCode.Portugal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;SSK&quot;.
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_a5G1k9p-Ed-ak6NoX_4Aeg_136710662")]
    [Description(@"Scheme code for SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK = CashClearingSystemCode.SwedenSSK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as &quot;TBF&quot;.
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_a5G1lNp-Ed-ak6NoX_4Aeg_136710687")]
    [Description(@"Scheme code for FR (France) - French RTGS (TBF).")]
    FranceFR = CashClearingSystemCode.FranceFR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for Target.
    /// Encoded/decoded by serializers as &quot;TGT&quot;.
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_a5G1ldp-Ed-ak6NoX_4Aeg_136710688")]
    [Description(@"Scheme code for Target.")]
    Target = CashClearingSystemCode.Target, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for NL (Netherlands) - Dutch RTGS (TOP).
    /// Encoded/decoded by serializers as &quot;TOP&quot;.
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_a5G1ltp-Ed-ak6NoX_4Aeg_136710704")]
    [Description(@"Scheme code for NL (Netherlands) - Dutch RTGS (TOP).")]
    Netherlands = CashClearingSystemCode.Netherlands, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for the US national real time gross settlement system.
    /// Encoded/decoded by serializers as &quot;FDW&quot;.
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_a5G1l9p-Ed-ak6NoX_4Aeg_136710722")]
    [Description(@"Scheme code for the US national real time gross settlement system.")]
    Fedwire = CashClearingSystemCode.Fedwire, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as &quot;BOJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_a5G1mNp-Ed-ak6NoX_4Aeg_136710739")]
    [Description(@"Scheme code for the Bank of Japan clearing system.")]
    BankOfJapanNet = CashClearingSystemCode.BankOfJapanNet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as &quot;FEY&quot;.
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_a5G1mdp-Ed-ak6NoX_4Aeg_136710757")]
    [Description(
        @"Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank."
    )]
    ForeignExchangeYenClearing = CashClearingSystemCode.ForeignExchangeYenClearing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as &quot;ZEN&quot;.
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_a5QmkNp-Ed-ak6NoX_4Aeg_136711030")]
    [Description(
        @"Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association."
    )]
    Zengin = CashClearingSystemCode.Zengin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for DK (Denmark) - Danish Krone RTGS (KRONOS).
    /// Encoded/decoded by serializers as &quot;DDK&quot;.
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_a5Qmkdp-Ed-ak6NoX_4Aeg_-1489579518")]
    [Description(@"Scheme code for DK (Denmark) - Danish Krone RTGS (KRONOS).")]
    DenmarkDDK = CashClearingSystemCode.DenmarkDDK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for AL (Albania) - Albania Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;AIP&quot;.
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_a5Qmktp-Ed-ak6NoX_4Aeg_-1488659469")]
    [Description(@"Scheme code for AL (Albania) - Albania Interbank Payment System.")]
    Albania = CashClearingSystemCode.Albania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as &quot;BCC&quot;.
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_a5Qmk9p-Ed-ak6NoX_4Aeg_-1488659452")]
    [Description(@"Scheme code for SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC = CashClearingSystemCode.SwedenBGC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as &quot;BDS&quot;.
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_a5QmlNp-Ed-ak6NoX_4Aeg_-1488659434")]
    [Description(@"Scheme code for BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados = CashClearingSystemCode.Barbados, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as &quot;BGN&quot;.
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_a5Qmldp-Ed-ak6NoX_4Aeg_-1488659417")]
    [Description(@"Scheme code for BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria = CashClearingSystemCode.Bulgaria, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as &quot;BHS&quot;.
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_a5Qmltp-Ed-ak6NoX_4Aeg_-1488659374")]
    [Description(@"Scheme code for BS (Bahamas) - Bahamas RTGS.")]
    Bahamas = CashClearingSystemCode.Bahamas, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;BIS&quot;.
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_a5Qml9p-Ed-ak6NoX_4Aeg_-1488659357")]
    [Description(@"Scheme code for BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana = CashClearingSystemCode.Botswana, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as &quot;BSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_a5QmmNp-Ed-ak6NoX_4Aeg_-1488659339")]
    [Description(@"Scheme code for PH (Philippines) - Philippines Payment System.")]
    Philippines = CashClearingSystemCode.Philippines, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as &quot;EPM&quot;.
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_a5Qmmdp-Ed-ak6NoX_4Aeg_-1488659314")]
    [Description(@"Scheme code for ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB = CashClearingSystemCode.ECB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for the US CHIPS-ACH.
    /// Encoded/decoded by serializers as &quot;EPN&quot;.
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_a5aXkNp-Ed-ak6NoX_4Aeg_-1488659297")]
    [Description(@"Scheme code for the US CHIPS-ACH.")]
    USChipsACH = CashClearingSystemCode.USChipsACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for the US FED-ACH.
    /// Encoded/decoded by serializers as &quot;FDA&quot;.
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_a5aXkdp-Ed-ak6NoX_4Aeg_-1488659262")]
    [Description(@"Scheme code for the US FED-ACH.")]
    USFedACH = CashClearingSystemCode.USFedACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as &quot;GIS&quot;.
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_a5aXktp-Ed-ak6NoX_4Aeg_-1488659244")]
    [Description(@"Scheme code for GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana = CashClearingSystemCode.Ghana, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for NL (Netherlands) - Netherlands Interpay CUG.
    /// Encoded/decoded by serializers as &quot;INC&quot;.
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_a5aXk9p-Ed-ak6NoX_4Aeg_-1488659002")]
    [Description(@"Scheme code for NL (Netherlands) - Netherlands Interpay CUG.")]
    NetherlandsIP = CashClearingSystemCode.NetherlandsIP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as &quot;JOD&quot;.
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_a5aXlNp-Ed-ak6NoX_4Aeg_-1488658967")]
    [Description(@"Scheme code for JO (Jordan) - Jordan RTGS.")]
    Jordan = CashClearingSystemCode.Jordan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as &quot;KPS&quot;.
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_a5aXldp-Ed-ak6NoX_4Aeg_-1488658907")]
    [Description(@"Scheme code for KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya = CashClearingSystemCode.Kenya, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as &quot;LKB&quot;.
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_a5aXltp-Ed-ak6NoX_4Aeg_-1488658890")]
    [Description(@"Scheme code for LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka = CashClearingSystemCode.SriLanka, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as &quot;MEP&quot;.
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_a5aXl9p-Ed-ak6NoX_4Aeg_-1488658872")]
    [Description(@"Scheme code for SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore = CashClearingSystemCode.Singapore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;MRS&quot;.
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_a5aXmNp-Ed-ak6NoX_4Aeg_-1488658539")]
    [Description(@"Scheme code for MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta = CashClearingSystemCode.Malta, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;NAM&quot;.
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_a5aXmdp-Ed-ak6NoX_4Aeg_-1488658522")]
    [Description(@"Scheme code for NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia = CashClearingSystemCode.Namibia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as &quot;PTR&quot;.
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_a5aXmtp-Ed-ak6NoX_4Aeg_-1488658487")]
    [Description(@"Scheme code for AO (Angola) - Angola RTGS.")]
    Angola = CashClearingSystemCode.Angola, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as &quot;ROL&quot;.
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_a5jhgNp-Ed-ak6NoX_4Aeg_-1488658469")]
    [Description(@"Scheme code for RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO = CashClearingSystemCode.RomaniaEPO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as &quot;ROS&quot;.
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_a5jhgdp-Ed-ak6NoX_4Aeg_-1488658384")]
    [Description(@"Scheme code for RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS = CashClearingSystemCode.RomaniaGSRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;SCP&quot;.
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_a5jhgtp-Ed-ak6NoX_4Aeg_-1488658349")]
    [Description(@"Scheme code for CL (Chile) - Chilean Interbank Payment System.")]
    Chili = CashClearingSystemCode.Chili, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as &quot;STG&quot;.
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_a5jhg9p-Ed-ak6NoX_4Aeg_-1330056061")]
    [Description(@"Scheme code for UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP = CashClearingSystemCode.UnitedKingdomGBP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for TH (Thailand) - Thailand Payment System (Bahtnet/2).
    /// Encoded/decoded by serializers as &quot;THB&quot;.
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_a5jhhNp-Ed-ak6NoX_4Aeg_-1330055683")]
    [Description(@"Scheme code for TH (Thailand) - Thailand Payment System (Bahtnet/2).")]
    Thailand = CashClearingSystemCode.Thailand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as &quot;TIS&quot;.
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_a5jhhdp-Ed-ak6NoX_4Aeg_-1330055598")]
    [Description(@"Scheme code for TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania = CashClearingSystemCode.Tanzania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as &quot;TTD&quot;.
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_a5jhhtp-Ed-ak6NoX_4Aeg_-1330055528")]
    [Description(@"Scheme code for TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago = CashClearingSystemCode.TrinidadAndTobago, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;UIS&quot;.
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_a5jhh9p-Ed-ak6NoX_4Aeg_-1330055486")]
    [Description(@"Scheme code for UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda = CashClearingSystemCode.Uganda, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as &quot;MOS&quot;.
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_a5jhiNp-Ed-ak6NoX_4Aeg_-1330055391")]
    [Description(@"Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica = CashClearingSystemCode.SouthAfrica, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for ZW (Zimbabwe) - Zimbabwe Electronic Transfer &amp; Settlement System.
    /// Encoded/decoded by serializers as &quot;ZET&quot;.
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_a5jhidp-Ed-ak6NoX_4Aeg_-1330055071")]
    [Description(
        @"Scheme code for ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System."
    )]
    Zimbabwe = CashClearingSystemCode.Zimbabwe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for ZM (Zambia) - Zambian Interbank Payment &amp;Settlement System.
    /// Encoded/decoded by serializers as &quot;ZIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_a5tSgNp-Ed-ak6NoX_4Aeg_-1330055054")]
    [Description(@"Scheme code for ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia = CashClearingSystemCode.Zambia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CHIPS is the Clearing House Interbank Payment System in the US.
    /// Encoded/decoded by serializers as &quot;CHI&quot;.
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_a5tSgdp-Ed-ak6NoX_4Aeg_1448951502")]
    [Description(@"CHIPS is the Clearing House Interbank Payment System in the US.")]
    USChips = CashClearingSystemCode.USChips, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Scheme code for Columbia (CO) - Colombian ACH CENIT Central Bank Payment System.
    /// Encoded/decoded by serializers as &quot;COP&quot;.
    /// </summary>
    [EnumMember(Value = "COP")]
    [IsoId("_a5tSgtp-Ed-ak6NoX_4Aeg_489129340")]
    [Description(
        @"Scheme code for Columbia (CO) - Colombian ACH CENIT Central Bank Payment System."
    )]
    Columbia = CashClearingSystemCode.Columbia, // same ordinal as derivation source for type conversions
}
