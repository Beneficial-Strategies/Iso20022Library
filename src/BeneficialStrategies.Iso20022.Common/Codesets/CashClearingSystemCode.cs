// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a5tSg9p-Ed-ak6NoX_4Aeg_381100265")]
[Description(
    @"Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed."
)]
[Derivations(
    typeof(CashClearingSystem1Code),
    typeof(CashClearingSystem3Code),
    typeof(CashClearingSystem2Code)
)]
public enum CashClearingSystemCode
{
    /// <summary>
    /// Scheme code for EBA Euro1/Step1.
    /// Encoded/decoded by serializers as &quot;ABE&quot;.
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_a5tShNp-Ed-ak6NoX_4Aeg_381100633")]
    [Description(@"Scheme code for EBA Euro1/Step1.")]
    EBAEuro1Step1,

    /// <summary>
    /// Scheme code for AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as &quot;ART&quot;.
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_a5tShdp-Ed-ak6NoX_4Aeg_381100634")]
    [Description(@"Scheme code for AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian,

    /// <summary>
    /// Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as &quot;AVP&quot;.
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_a5tShtp-Ed-ak6NoX_4Aeg_381100650")]
    [Description(@"Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand,

    /// <summary>
    /// Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as &quot;AZM&quot;.
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_a5tSh9p-Ed-ak6NoX_4Aeg_381100651")]
    [Description(@"Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan,

    /// <summary>
    /// Scheme code for BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as &quot;BAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_a5tSiNp-Ed-ak6NoX_4Aeg_381100660")]
    [Description(@"Scheme code for BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina,

    /// <summary>
    /// Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as &quot;BEL&quot;.
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_a5tSidp-Ed-ak6NoX_4Aeg_381100661")]
    [Description(@"Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium,

    /// <summary>
    /// Scheme code for FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as &quot;BOF&quot;.
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_a53DgNp-Ed-ak6NoX_4Aeg_381100668")]
    [Description(@"Scheme code for FI (Finland) - RTGS (BOF).")]
    Finland,

    /// <summary>
    /// Scheme code for IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as &quot;BRL&quot;.
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_a53Dgdp-Ed-ak6NoX_4Aeg_381100669")]
    [Description(@"Scheme code for IT (Italy) - Italy RTGS (BIREL).")]
    Italy,

    /// <summary>
    /// Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).
    /// Encoded/decoded by serializers as &quot;CAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_a53Dgtp-Ed-ak6NoX_4Aeg_381100677")]
    [Description(@"Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).")]
    Canada,

    /// <summary>
    /// Scheme code for ES (Spain).
    /// Encoded/decoded by serializers as &quot;CAM&quot;.
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_a53Dg9p-Ed-ak6NoX_4Aeg_381100693")]
    [Description(@"Scheme code for ES (Spain).")]
    SpainCAM,

    /// <summary>
    /// Scheme code for IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as &quot;CBJ&quot;.
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_a53DhNp-Ed-ak6NoX_4Aeg_381100694")]
    [Description(@"Scheme code for IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland,

    /// <summary>
    /// Scheme code for GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as &quot;CHP&quot;.
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_a53Dhdp-Ed-ak6NoX_4Aeg_381100695")]
    [Description(@"Scheme code for GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom,

    /// <summary>
    /// Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).
    /// Encoded/decoded by serializers as &quot;DKC&quot;.
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_a53Dhtp-Ed-ak6NoX_4Aeg_381100710")]
    [Description(@"Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).")]
    Denmark,

    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as &quot;RTP&quot;.
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_a53Dh9p-Ed-ak6NoX_4Aeg_381100711")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyRTGSPlus,

    /// <summary>
    /// Scheme code for EBA Euro1.
    /// Encoded/decoded by serializers as &quot;EBA&quot;.
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_a53DiNp-Ed-ak6NoX_4Aeg_381100712")]
    [Description(@"Scheme code for EBA Euro1.")]
    EBAEuro1,

    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as &quot;ELS&quot;.
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_a53Didp-Ed-ak6NoX_4Aeg_381100713")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyELS,

    /// <summary>
    /// Scheme code for EBA step 1 (members).
    /// Encoded/decoded by serializers as &quot;ERP&quot;.
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_a6ANcNp-Ed-ak6NoX_4Aeg_381100728")]
    [Description(@"Scheme code for EBA step 1 (members).")]
    EBAStep1,

    /// <summary>
    /// Scheme code for EBA step 2.
    /// Encoded/decoded by serializers as &quot;XCT&quot;.
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_a6ANcdp-Ed-ak6NoX_4Aeg_381100729")]
    [Description(@"Scheme code for EBA step 2.")]
    EBAStep2,

    /// <summary>
    /// Scheme code for HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as &quot;HRK&quot;.
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_a6ANctp-Ed-ak6NoX_4Aeg_381100730")]
    [Description(@"Scheme code for HR (Croatia) - HSVP.")]
    Croatia,

    /// <summary>
    /// Scheme code for GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as &quot;HRM&quot;.
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_a6ANc9p-Ed-ak6NoX_4Aeg_381100753")]
    [Description(@"Scheme code for GR (Greece) - Greek RTGS (HERMES).")]
    Greece,

    /// <summary>
    /// Scheme code for HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as &quot;HUF&quot;.
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_a6ANdNp-Ed-ak6NoX_4Aeg_381100754")]
    [Description(@"Scheme code for HU (Hungary) - VIBER.")]
    Hungary,

    /// <summary>
    /// Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as &quot;LGS&quot;.
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_a6ANddp-Ed-ak6NoX_4Aeg_381100755")]
    [Description(@"Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg,

    /// <summary>
    /// Scheme code for LV (Latvia).
    /// Encoded/decoded by serializers as &quot;LVL&quot;.
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_a6ANdtp-Ed-ak6NoX_4Aeg_381100770")]
    [Description(@"Scheme code for LV (Latvia).")]
    Latvia,

    /// <summary>
    /// Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as &quot;MOS&quot;.
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_a6ANd9p-Ed-ak6NoX_4Aeg_381100771")]
    [Description(@"Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica,

    /// <summary>
    /// Scheme code for MU (Mauritius).
    /// Encoded/decoded by serializers as &quot;MUP&quot;.
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_a6ANeNp-Ed-ak6NoX_4Aeg_381100772")]
    [Description(@"Scheme code for MU (Mauritius).")]
    Mauritius,

    /// <summary>
    /// Scheme code for NO (Norway).
    /// Encoded/decoded by serializers as &quot;NOC&quot;.
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_a6ANedp-Ed-ak6NoX_4Aeg_381100773")]
    [Description(@"Scheme code for NO (Norway).")]
    Norway,

    /// <summary>
    /// Scheme code for CH (Switzerland).
    /// Encoded/decoded by serializers as &quot;PCH&quot;.
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_a6J-cNp-Ed-ak6NoX_4Aeg_381100788")]
    [Description(@"Scheme code for CH (Switzerland).")]
    Switzerland,

    /// <summary>
    /// Scheme code for AU (Australia).
    /// Encoded/decoded by serializers as &quot;PDS&quot;.
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_a6J-cdp-Ed-ak6NoX_4Aeg_381100789")]
    [Description(@"Scheme code for AU (Australia).")]
    Australia,

    /// <summary>
    /// Scheme code for EG (Egypt).
    /// Encoded/decoded by serializers as &quot;PEG&quot;.
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_a6J-ctp-Ed-ak6NoX_4Aeg_381100790")]
    [Description(@"Scheme code for EG (Egypt).")]
    Egypt,

    /// <summary>
    /// Scheme code for FR (France).
    /// Encoded/decoded by serializers as &quot;PNS&quot;.
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_a6J-c9p-Ed-ak6NoX_4Aeg_381100805")]
    [Description(@"Scheme code for FR (France).")]
    FrancePNS,

    /// <summary>
    /// Scheme code for Ve (Venezuela).
    /// Encoded/decoded by serializers as &quot;PVE&quot;.
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_a6J-dNp-Ed-ak6NoX_4Aeg_381100806")]
    [Description(@"Scheme code for Ve (Venezuela).")]
    Venezuela,

    /// <summary>
    /// Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_a6J-ddp-Ed-ak6NoX_4Aeg_381100815")]
    [Description(@"Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC,

    /// <summary>
    /// Scheme code for SI (Slovenia).
    /// Encoded/decoded by serializers as &quot;SIT&quot;.
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_a6J-dtp-Ed-ak6NoX_4Aeg_381100823")]
    [Description(@"Scheme code for SI (Slovenia).")]
    Slovania,

    /// <summary>
    /// Scheme code for ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as &quot;SLB&quot;.
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_a6J-d9p-Ed-ak6NoX_4Aeg_381100824")]
    [Description(@"Scheme code for ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES,

    /// <summary>
    /// Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as &quot;SPG&quot;.
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_a6J-eNp-Ed-ak6NoX_4Aeg_381100832")]
    [Description(@"Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal,

    /// <summary>
    /// Scheme code for SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;SSK&quot;.
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_a6J-edp-Ed-ak6NoX_4Aeg_381100833")]
    [Description(@"Scheme code for SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK,

    /// <summary>
    /// Scheme code for FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as &quot;TBF&quot;.
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_a6J-etp-Ed-ak6NoX_4Aeg_381100848")]
    [Description(@"Scheme code for FR (France) - French RTGS (TBF).")]
    FranceFR,

    /// <summary>
    /// Scheme code for Target.
    /// Encoded/decoded by serializers as &quot;TGT&quot;.
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_a6TIYNp-Ed-ak6NoX_4Aeg_381100849")]
    [Description(@"Scheme code for Target.")]
    Target,

    /// <summary>
    /// Scheme code for NL (Netherlands) - Dutch RTGS (TOP).
    /// Encoded/decoded by serializers as &quot;TOP&quot;.
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_a6TIYdp-Ed-ak6NoX_4Aeg_381100850")]
    [Description(@"Scheme code for NL (Netherlands) - Dutch RTGS (TOP).")]
    Netherlands,

    /// <summary>
    /// Scheme code for the US national real time gross settlement system.
    /// Encoded/decoded by serializers as &quot;FDW&quot;.
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_a6TIYtp-Ed-ak6NoX_4Aeg_381100865")]
    [Description(@"Scheme code for the US national real time gross settlement system.")]
    Fedwire,

    /// <summary>
    /// Scheme code for the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as &quot;BOJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_a6TIY9p-Ed-ak6NoX_4Aeg_381100866")]
    [Description(@"Scheme code for the Bank of Japan clearing system.")]
    BankOfJapanNet,

    /// <summary>
    /// Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as &quot;FEY&quot;.
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_a6TIZNp-Ed-ak6NoX_4Aeg_381100867")]
    [Description(
        @"Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank."
    )]
    ForeignExchangeYenClearing,

    /// <summary>
    /// Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as &quot;ZEN&quot;.
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_a6TIZdp-Ed-ak6NoX_4Aeg_381100884")]
    [Description(
        @"Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association."
    )]
    Zengin,

    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as &quot;RTG&quot;.
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_a6TIZtp-Ed-ak6NoX_4Aeg_1933335943")]
    [Description(
        @"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money."
    )]
    RTGS,

    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;ACH&quot;.
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_a6TIZ9p-Ed-ak6NoX_4Aeg_1951806337")]
    [Description(
        @"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis."
    )]
    ACH,

    /// <summary>
    /// CHIPS is the Clearing House Interbank Payment System in the US.
    /// Encoded/decoded by serializers as &quot;CHI&quot;.
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_a6TIaNp-Ed-ak6NoX_4Aeg_1964734717")]
    [Description(@"CHIPS is the Clearing House Interbank Payment System in the US.")]
    USChips,

    /// <summary>
    /// FedNet is a link to a Federal Bank account via the internet. FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc.
    /// Encoded/decoded by serializers as &quot;FDN&quot;.
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_a6TIadp-Ed-ak6NoX_4Aeg_1976741419")]
    [Description(
        @"FedNet is a link to a Federal Bank account via the internet. FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc."
    )]
    FedNet,

    /// <summary>
    /// Scheme code for DK (Denmark) - Danish Krone RTGS (KRONOS).
    /// Encoded/decoded by serializers as &quot;DDK&quot;.
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_a6c5YNp-Ed-ak6NoX_4Aeg_-1659899775")]
    [Description(@"Scheme code for DK (Denmark) - Danish Krone RTGS (KRONOS).")]
    DenmarkDDK,

    /// <summary>
    /// Scheme code for AL (Albania) - Albania Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;AIP&quot;.
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_a6c5Ydp-Ed-ak6NoX_4Aeg_-1533051108")]
    [Description(@"Scheme code for AL (Albania) - Albania Interbank Payment System.")]
    Albania,

    /// <summary>
    /// Scheme code for SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as &quot;BCC&quot;.
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_a6c5Ytp-Ed-ak6NoX_4Aeg_-1430540534")]
    [Description(@"Scheme code for SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC,

    /// <summary>
    /// Scheme code for BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as &quot;BDS&quot;.
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_a6c5Y9p-Ed-ak6NoX_4Aeg_-1429614744")]
    [Description(@"Scheme code for BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados,

    /// <summary>
    /// Scheme code for BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as &quot;BGN&quot;.
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_a6c5ZNp-Ed-ak6NoX_4Aeg_-1427769950")]
    [Description(@"Scheme code for BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria,

    /// <summary>
    /// Scheme code for BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as &quot;BHS&quot;.
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_a6c5Zdp-Ed-ak6NoX_4Aeg_-1418533937")]
    [Description(@"Scheme code for BS (Bahamas) - Bahamas RTGS.")]
    Bahamas,

    /// <summary>
    /// Scheme code for BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;BIS&quot;.
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_a6c5Ztp-Ed-ak6NoX_4Aeg_-1417608476")]
    [Description(@"Scheme code for BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana,

    /// <summary>
    /// Scheme code for PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as &quot;BSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_a6c5Z9p-Ed-ak6NoX_4Aeg_-1415764257")]
    [Description(@"Scheme code for PH (Philippines) - Philippines Payment System.")]
    Philippines,

    /// <summary>
    /// Scheme code for ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as &quot;EPM&quot;.
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_a6c5aNp-Ed-ak6NoX_4Aeg_-1414838892")]
    [Description(@"Scheme code for ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB,

    /// <summary>
    /// Scheme code for the US CHIPS-ACH.
    /// Encoded/decoded by serializers as &quot;EPN&quot;.
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_a6c5adp-Ed-ak6NoX_4Aeg_-1413914421")]
    [Description(@"Scheme code for the US CHIPS-ACH.")]
    USChipsACH,

    /// <summary>
    /// Scheme code for the US FED-ACH.
    /// Encoded/decoded by serializers as &quot;FDA&quot;.
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_a6mqYNp-Ed-ak6NoX_4Aeg_-1412069830")]
    [Description(@"Scheme code for the US FED-ACH.")]
    USFedACH,

    /// <summary>
    /// Scheme code for GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as &quot;GIS&quot;.
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_a6mqYdp-Ed-ak6NoX_4Aeg_-1411145785")]
    [Description(@"Scheme code for GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana,

    /// <summary>
    /// Scheme code for NL (Netherlands) - Netherlands Interpay CUG.
    /// Encoded/decoded by serializers as &quot;INC&quot;.
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_a6mqYtp-Ed-ak6NoX_4Aeg_-1410219814")]
    [Description(@"Scheme code for NL (Netherlands) - Netherlands Interpay CUG.")]
    NetherlandsIP,

    /// <summary>
    /// Scheme code for JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as &quot;JOD&quot;.
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_a6mqY9p-Ed-ak6NoX_4Aeg_-1401911405")]
    [Description(@"Scheme code for JO (Jordan) - Jordan RTGS.")]
    Jordan,

    /// <summary>
    /// Scheme code for KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as &quot;KPS&quot;.
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_a6mqZNp-Ed-ak6NoX_4Aeg_-1400064024")]
    [Description(@"Scheme code for KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya,

    /// <summary>
    /// Scheme code for LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as &quot;LKB&quot;.
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_a6mqZdp-Ed-ak6NoX_4Aeg_-1399138987")]
    [Description(@"Scheme code for LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka,

    /// <summary>
    /// Scheme code for SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as &quot;MEP&quot;.
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_a6mqZtp-Ed-ak6NoX_4Aeg_-1398214398")]
    [Description(@"Scheme code for SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore,

    /// <summary>
    /// Scheme code for MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;MRS&quot;.
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_a6mqZ9p-Ed-ak6NoX_4Aeg_-1388980442")]
    [Description(@"Scheme code for MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta,

    /// <summary>
    /// Scheme code for NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;NAM&quot;.
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_a6mqaNp-Ed-ak6NoX_4Aeg_-1388056333")]
    [Description(@"Scheme code for NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia,

    /// <summary>
    /// Scheme code for AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as &quot;PTR&quot;.
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_a6mqadp-Ed-ak6NoX_4Aeg_-1386211166")]
    [Description(@"Scheme code for AO (Angola) - Angola RTGS.")]
    Angola,

    /// <summary>
    /// Scheme code for RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as &quot;ROL&quot;.
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_a6mqatp-Ed-ak6NoX_4Aeg_-1385286190")]
    [Description(@"Scheme code for RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO,

    /// <summary>
    /// Scheme code for RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as &quot;ROS&quot;.
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_a6v0UNp-Ed-ak6NoX_4Aeg_2004692084")]
    [Description(@"Scheme code for RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS,

    /// <summary>
    /// Scheme code for CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;SCP&quot;.
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_a6v0Udp-Ed-ak6NoX_4Aeg_-1948571790")]
    [Description(@"Scheme code for CL (Chile) - Chilean Interbank Payment System.")]
    Chili,

    /// <summary>
    /// Scheme code for UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as &quot;STG&quot;.
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_a6v0Utp-Ed-ak6NoX_4Aeg_-1871238868")]
    [Description(@"Scheme code for UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP,

    /// <summary>
    /// Scheme code for TH (Thailand) - Thailand Payment System (Bahtnet/2).
    /// Encoded/decoded by serializers as &quot;THB&quot;.
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_a6v0U9p-Ed-ak6NoX_4Aeg_-1813057901")]
    [Description(@"Scheme code for TH (Thailand) - Thailand Payment System (Bahtnet/2).")]
    Thailand,

    /// <summary>
    /// Scheme code for TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as &quot;TIS&quot;.
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_a6v0VNp-Ed-ak6NoX_4Aeg_-1804743315")]
    [Description(@"Scheme code for TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania,

    /// <summary>
    /// Scheme code for TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as &quot;TTD&quot;.
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_a6v0Vdp-Ed-ak6NoX_4Aeg_-1802896503")]
    [Description(@"Scheme code for TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago,

    /// <summary>
    /// Scheme code for UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;UIS&quot;.
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_a6v0Vtp-Ed-ak6NoX_4Aeg_-1801051662")]
    [Description(@"Scheme code for UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda,

    /// <summary>
    /// Scheme code for ZW (Zimbabwe) - Zimbabwe Electronic Transfer &amp; Settlement System.
    /// Encoded/decoded by serializers as &quot;ZET&quot;.
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_a6v0V9p-Ed-ak6NoX_4Aeg_-1789969456")]
    [Description(
        @"Scheme code for ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System."
    )]
    Zimbabwe,

    /// <summary>
    /// Scheme code for ZM (Zambia) - Zambian Interbank Payment &amp;Settlement System.
    /// Encoded/decoded by serializers as &quot;ZIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_a6v0WNp-Ed-ak6NoX_4Aeg_-1786272862")]
    [Description(@"Scheme code for ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia,

    /// <summary>
    /// Scheme code for Columbia (CO) - Colombian ACH CENIT Central Bank Payment System.
    /// Encoded/decoded by serializers as &quot;COP&quot;.
    /// </summary>
    [EnumMember(Value = "COP")]
    [IsoId("_a6v0Wdp-Ed-ak6NoX_4Aeg_526070704")]
    [Description(
        @"Scheme code for Columbia (CO) - Colombian ACH CENIT Central Bank Payment System."
    )]
    Columbia,
}
