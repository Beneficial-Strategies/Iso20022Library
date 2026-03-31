// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash clearing system, as published in an external cash clearing system code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amVqktp-Ed-ak6NoX_4Aeg_1632765855")]
[Description(
    @"Specifies the cash clearing system, as published in an external cash clearing system code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalCashClearingSystemCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCashClearingSystem1Code>))]
#endif
public enum ExternalCashClearingSystem1Code
{
    /// <summary>
    /// EBA Euro1/Step1.
    /// Encoded/decoded by serializers as &quot;ABE&quot;.
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_tfmrsvRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1/Step1.")]
    EBAEuro1Step1 = ExternalCashClearingSystemCode.EBAEuro1Step1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;ACH&quot;.
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_tfmrtfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis."
    )]
    ACH = ExternalCashClearingSystemCode.ACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS)
    /// Encoded/decoded by serializers as &quot;ACS&quot;.
    /// </summary>
    [EnumMember(Value = "ACS")]
    [IsoId("_tfmruPRYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) ")]
    CanadaACSS = ExternalCashClearingSystemCode.CanadaACSS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AL (Albania) -  Albania Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;AIP&quot;.
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_tfv1ovRYEeuLhpyIdtJzwg")]
    [Description(@"AL (Albania) -  Albania Interbank Payment System.")]
    Albania = ExternalCashClearingSystemCode.Albania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AT (Austria) - Austrian RTGS.
    /// Encoded/decoded by serializers as &quot;ART&quot;.
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_tfv1pfRYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) - Austrian RTGS.")]
    Austrian = ExternalCashClearingSystemCode.Austrian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as &quot;AVP&quot;.
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_tfv1qPRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand = ExternalCashClearingSystemCode.NewZealand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as &quot;AZM&quot;.
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_tfv1q_RYEeuLhpyIdtJzwg")]
    [Description(@"AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan = ExternalCashClearingSystemCode.Azerbaijan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as &quot;BAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_tfv1rvRYEeuLhpyIdtJzwg")]
    [Description(@"BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina = ExternalCashClearingSystemCode.BosniaHerzegovina, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as &quot;BCC&quot;.
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_tf5movRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC = ExternalCashClearingSystemCode.SwedenBGC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)
    /// Encoded/decoded by serializers as &quot;BCE&quot;.
    /// </summary>
    [EnumMember(Value = "BCE")]
    [IsoId("_tf5mpfRYEeuLhpyIdtJzwg")]
    [Description(
        @"EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)"
    )]
    Ecuador = ExternalCashClearingSystemCode.Ecuador, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as &quot;BDS&quot;.
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_tgDXovRYEeuLhpyIdtJzwg")]
    [Description(@"BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados = ExternalCashClearingSystemCode.Barbados, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as &quot;BEL&quot;.
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_tgDXpfRYEeuLhpyIdtJzwg")]
    [Description(@"BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium = ExternalCashClearingSystemCode.Belgium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as &quot;BGN&quot;.
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_tgDXqPRYEeuLhpyIdtJzwg")]
    [Description(@"BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria = ExternalCashClearingSystemCode.Bulgaria, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as &quot;BHS&quot;.
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_tgMhkvRYEeuLhpyIdtJzwg")]
    [Description(@"BS (Bahamas) - Bahamas RTGS.")]
    Bahamas = ExternalCashClearingSystemCode.Bahamas, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;BIS&quot;.
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_tgMhlfRYEeuLhpyIdtJzwg")]
    [Description(@"BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana = ExternalCashClearingSystemCode.Botswana, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as &quot;BOF&quot;.
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_tgMhmPRYEeuLhpyIdtJzwg")]
    [Description(@"FI (Finland) - RTGS (BOF).")]
    Finland = ExternalCashClearingSystemCode.Finland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as &quot;BOJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_tgWSkvRYEeuLhpyIdtJzwg")]
    [Description(@"the Bank of Japan clearing system.")]
    BankOfJapanNet = ExternalCashClearingSystemCode.BankOfJapanNet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as &quot;BRL&quot;.
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_tgWSlfRYEeuLhpyIdtJzwg")]
    [Description(@"IT (Italy) - Italy RTGS (BIREL).")]
    Italy = ExternalCashClearingSystemCode.Italy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as &quot;BSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_tgWSmPRYEeuLhpyIdtJzwg")]
    [Description(@"PH (Philippines) - Philippines Payment System.")]
    Philippines = ExternalCashClearingSystemCode.Philippines, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA (Canada) - Canadian Large Value Transfer System (LVTS)
    /// Encoded/decoded by serializers as &quot;CAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_tgfcgvRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Canadian Large Value Transfer System (LVTS)")]
    CanadaCAD = ExternalCashClearingSystemCode.CanadaCAD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ES (Spain).
    /// Encoded/decoded by serializers as &quot;CAM&quot;.
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_tgfchfRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain).")]
    SpainCAM = ExternalCashClearingSystemCode.SpainCAM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AW (Aruba) - Central Bank of Aruba CSM
    /// Encoded/decoded by serializers as &quot;CBA&quot;.
    /// </summary>
    [EnumMember(Value = "CBA")]
    [IsoId("_tgpNgvRYEeuLhpyIdtJzwg")]
    [Description(@"AW (Aruba) - Central Bank of Aruba CSM")]
    CentralBankOfArubaCSM = ExternalCashClearingSystemCode.CentralBankOfArubaCSM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CW (Curaçao), SX (Sint Maarten) Central Bank of Curaçao and Sint    Maarten CSM
    /// Encoded/decoded by serializers as &quot;CBC&quot;.
    /// </summary>
    [EnumMember(Value = "CBC")]
    [IsoId("_tgpNhfRYEeuLhpyIdtJzwg")]
    [Description(
        @"CW (Curaçao), SX (Sint Maarten) Central Bank of Curaçao and Sint    Maarten CSM"
    )]
    CentraleBankVanCuraçaoEnSintMaartenCSM =
        ExternalCashClearingSystemCode.CentraleBankVanCuraçaoEnSintMaartenCSM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as &quot;CBJ&quot;.
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_tgpNiPRYEeuLhpyIdtJzwg")]
    [Description(@"IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland = ExternalCashClearingSystemCode.Ireland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Real-Time Payment System Peru
    /// Encoded/decoded by serializers as &quot;CCE&quot;.
    /// </summary>
    [EnumMember(Value = "CCE")]
    [IsoId("_tgpNi_RYEeuLhpyIdtJzwg")]
    [Description(@"Real-Time Payment System Peru")]
    Peru = ExternalCashClearingSystemCode.Peru, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US - The Clearing House CHIPS
    /// Encoded/decoded by serializers as &quot;CHI&quot;.
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_tgpNjvRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House CHIPS")]
    USTCHChips = ExternalCashClearingSystemCode.USTCHChips, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as &quot;CHP&quot;.
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_tgy-gvRYEeuLhpyIdtJzwg")]
    [Description(@"GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom = ExternalCashClearingSystemCode.UnitedKingdom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cross-border Interbank Payment System (CIPS)
    /// Encoded/decoded by serializers as &quot;CIP&quot;.
    /// </summary>
    [EnumMember(Value = "CIP")]
    [IsoId("_tgy-hfRYEeuLhpyIdtJzwg")]
    [Description(@"Cross-border Interbank Payment System (CIPS) ")]
    China = ExternalCashClearingSystemCode.China, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.
    /// Encoded/decoded by serializers as &quot;CIS&quot;.
    /// </summary>
    [EnumMember(Value = "CIS")]
    [IsoId("_tgy-iPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA."
    )]
    CentralInteroperabilityService = ExternalCashClearingSystemCode.CentralInteroperabilityService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).
    /// Encoded/decoded by serializers as &quot;COE&quot;.
    /// </summary>
    [EnumMember(Value = "COE")]
    [IsoId("_tgy-i_RYEeuLhpyIdtJzwg")]
    [Description(
        @"CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques)."
    )]
    ColumbiaCEDEC = ExternalCashClearingSystemCode.ColumbiaCEDEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).
    /// Encoded/decoded by serializers as &quot;COI&quot;.
    /// </summary>
    [EnumMember(Value = "COI")]
    [IsoId("_tgy-jvRYEeuLhpyIdtJzwg")]
    [Description(
        @"CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria)."
    )]
    ColumbiaCENIT = ExternalCashClearingSystemCode.ColumbiaCENIT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).
    /// Encoded/decoded by serializers as &quot;COU&quot;.
    /// </summary>
    [EnumMember(Value = "COU")]
    [IsoId("_tg8IcvRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).")]
    ColumbiaCUD = ExternalCashClearingSystemCode.ColumbiaCUD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DK (Denmark) - Danish Krone RTGS (KRONOS)
    /// Encoded/decoded by serializers as &quot;DDK&quot;.
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_tg8IdfRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Krone RTGS (KRONOS)")]
    DenmarkDDK = ExternalCashClearingSystemCode.DenmarkDDK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DK (Denmark) - Danish Euro RTGS (KRONOS)
    /// Encoded/decoded by serializers as &quot;DKC&quot;.
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_tg8IePRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Euro RTGS (KRONOS)")]
    Denmark = ExternalCashClearingSystemCode.Denmark, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA Euro1.
    /// Encoded/decoded by serializers as &quot;EBA&quot;.
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_tg8Ie_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1.")]
    EBAEuro1 = ExternalCashClearingSystemCode.EBAEuro1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as &quot;ELS&quot;.
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_tg8IfvRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyELS = ExternalCashClearingSystemCode.GermanyELS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Elektronischer Massenzahlungsverkehr (EMZ)|DE (Germany) – retail payment system operated by the Deutsche Bundesbank
    /// Encoded/decoded by serializers as &quot;EMZ&quot;.
    /// </summary>
    [EnumMember(Value = "EMZ")]
    [IsoId("_thF5cvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Elektronischer Massenzahlungsverkehr (EMZ)|DE (Germany) – retail payment system operated by the Deutsche Bundesbank "
    )]
    Germany = ExternalCashClearingSystemCode.Germany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as &quot;EPM&quot;.
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_thF5dfRYEeuLhpyIdtJzwg")]
    [Description(@"ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB = ExternalCashClearingSystemCode.ECB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US - The Clearing House EPN
    /// Encoded/decoded by serializers as &quot;EPN&quot;.
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_thF5ePRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House EPN")]
    USTCHEPN = ExternalCashClearingSystemCode.USTCHEPN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA step 1 (members).
    /// Encoded/decoded by serializers as &quot;ERP&quot;.
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_thPqcvRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 1 (members).")]
    EBAStep1 = ExternalCashClearingSystemCode.EBAStep1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US (United States) - Federal Reserve Banks Automated Clearing House Service.
    /// Encoded/decoded by serializers as &quot;FDA&quot;.
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_thPqdfRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks Automated Clearing House Service.")]
    USFedACH = ExternalCashClearingSystemCode.USFedACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US (United States) - Federal Reserve Banks FedNow Service.
    /// Encoded/decoded by serializers as &quot;FDN&quot;.
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_thPqePRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks FedNow Service.")]
    USFedNow = ExternalCashClearingSystemCode.USFedNow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US (United States) - Federal Reserve Banks Fedwire Funds  Service.
    /// Encoded/decoded by serializers as &quot;FDW&quot;.
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_thPqe_RYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks Fedwire Funds  Service.")]
    USFedwireFunds = ExternalCashClearingSystemCode.USFedwireFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as &quot;FEY&quot;.
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_thPqfvRYEeuLhpyIdtJzwg")]
    [Description(
        @"JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank."
    )]
    ForeignExchangeYenClearing = ExternalCashClearingSystemCode.ForeignExchangeYenClearing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Faster Payments Service in UK.
    /// Encoded/decoded by serializers as &quot;FPS&quot;.
    /// </summary>
    [EnumMember(Value = "FPS")]
    [IsoId("_thY0YvRYEeuLhpyIdtJzwg")]
    [Description(@"Faster Payments Service in UK.")]
    FasterPaymentsServices = ExternalCashClearingSystemCode.FasterPaymentsServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as &quot;GIS&quot;.
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_thY0ZfRYEeuLhpyIdtJzwg")]
    [Description(@"GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana = ExternalCashClearingSystemCode.Ghana, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hong Kong Clearing House Automated Transfer System (CHATS).
    /// Encoded/decoded by serializers as &quot;HKL&quot;.
    /// </summary>
    [EnumMember(Value = "HKL")]
    [IsoId("_thY0aPRYEeuLhpyIdtJzwg")]
    [Description(@"Hong Kong Clearing House Automated Transfer System (CHATS).")]
    HongKongCHATS = ExternalCashClearingSystemCode.HongKongCHATS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hong Kong Faster Payment System or FPS. A system owned and operated by the HKICL, to provide instant clearing and settlement payment services.
    /// Encoded/decoded by serializers as &quot;HKS&quot;.
    /// </summary>
    [EnumMember(Value = "HKS")]
    [IsoId("_thY0a_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Hong Kong Faster Payment System or FPS. A system owned and operated by the HKICL, to provide instant clearing and settlement payment services."
    )]
    HongKongFPS = ExternalCashClearingSystemCode.HongKongFPS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as &quot;HRK&quot;.
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_thY0bvRYEeuLhpyIdtJzwg")]
    [Description(@"HR (Croatia) - HSVP.")]
    Croatia = ExternalCashClearingSystemCode.Croatia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as &quot;HRM&quot;.
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_thilYvRYEeuLhpyIdtJzwg")]
    [Description(@"GR (Greece) - Greek RTGS (HERMES).")]
    Greece = ExternalCashClearingSystemCode.Greece, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as &quot;HUF&quot;.
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_thilZfRYEeuLhpyIdtJzwg")]
    [Description(@"HU (Hungary) - VIBER.")]
    Hungary = ExternalCashClearingSystemCode.Hungary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ES - Spain - Iberpay Instant Payments
    /// Encoded/decoded by serializers as &quot;IBP&quot;.
    /// </summary>
    [EnumMember(Value = "IBP")]
    [IsoId("_thilaPRYEeuLhpyIdtJzwg")]
    [Description(@"ES - Spain - Iberpay Instant Payments")]
    SpainIberpayInstantPayments = ExternalCashClearingSystemCode.SpainIberpayInstantPayments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE and NL - Equens
    /// Encoded/decoded by serializers as &quot;INC&quot;.
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_thrvUvRYEeuLhpyIdtJzwg")]
    [Description(@"DE and NL - Equens ")]
    DEandNLEquens = ExternalCashClearingSystemCode.DEandNLEquens, // same ordinal as derivation source for type conversions

    /// <summary>
    /// India Immediate Payment Service
    /// Encoded/decoded by serializers as &quot;IMP&quot;.
    /// </summary>
    [EnumMember(Value = "IMP")]
    [IsoId("_thrvVfRYEeuLhpyIdtJzwg")]
    [Description(@"India Immediate Payment Service")]
    IndiaImmediatePaymentService = ExternalCashClearingSystemCode.IndiaImmediatePaymentService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as &quot;JOD&quot;.
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_thrvWPRYEeuLhpyIdtJzwg")]
    [Description(@"JO (Jordan) - Jordan RTGS.")]
    Jordan = ExternalCashClearingSystemCode.Jordan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as &quot;KPS&quot;.
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_thrvW_RYEeuLhpyIdtJzwg")]
    [Description(@"KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya = ExternalCashClearingSystemCode.Kenya, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as &quot;LGS&quot;.
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_th1gUvRYEeuLhpyIdtJzwg")]
    [Description(@"LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg = ExternalCashClearingSystemCode.Luxemburg, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as &quot;LKB&quot;.
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_th1gVfRYEeuLhpyIdtJzwg")]
    [Description(@"LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka = ExternalCashClearingSystemCode.SriLanka, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LV (Latvia).
    /// Encoded/decoded by serializers as &quot;LVL&quot;.
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_th1gWPRYEeuLhpyIdtJzwg")]
    [Description(@"LV (Latvia).")]
    Latvia = ExternalCashClearingSystemCode.Latvia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA (Canada) - Large Value Transfer System (LVTS).
    /// Encoded/decoded by serializers as &quot;LVT&quot;.
    /// </summary>
    [EnumMember(Value = "LVT")]
    [IsoId("_th_RUvRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Large Value Transfer System (LVTS).")]
    CanadaLVTS = ExternalCashClearingSystemCode.CanadaLVTS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA (Canada) Lynx High Value Payment System.
    /// Encoded/decoded by serializers as &quot;LYX&quot;.
    /// </summary>
    [EnumMember(Value = "LYX")]
    [IsoId("_th_RVfRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) Lynx High Value Payment System.")]
    LynxCanada = ExternalCashClearingSystemCode.LynxCanada, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as &quot;MEP&quot;.
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_th_RWPRYEeuLhpyIdtJzwg")]
    [Description(@"SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore = ExternalCashClearingSystemCode.Singapore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as &quot;MOS&quot;.
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_th_RW_RYEeuLhpyIdtJzwg")]
    [Description(@"ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica = ExternalCashClearingSystemCode.SouthAfrica, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Macao Real Time Gross Settlement System
    /// Encoded/decoded by serializers as &quot;MQQ&quot;.
    /// </summary>
    [EnumMember(Value = "MQQ")]
    [IsoId("_th_RXvRYEeuLhpyIdtJzwg")]
    [Description(@"Macao Real Time Gross Settlement System")]
    MacaoRTGS = ExternalCashClearingSystemCode.MacaoRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;MRS&quot;.
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_tiIbQvRYEeuLhpyIdtJzwg")]
    [Description(@"MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta = ExternalCashClearingSystemCode.Malta, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MU (Mauritius).
    /// Encoded/decoded by serializers as &quot;MUP&quot;.
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_tiIbRfRYEeuLhpyIdtJzwg")]
    [Description(@"MU (Mauritius).")]
    Mauritius = ExternalCashClearingSystemCode.Mauritius, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;NAM&quot;.
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_tiIbSPRYEeuLhpyIdtJzwg")]
    [Description(@"NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia = ExternalCashClearingSystemCode.Namibia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NO (Norway).
    /// Encoded/decoded by serializers as &quot;NOC&quot;.
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_tiIbS_RYEeuLhpyIdtJzwg")]
    [Description(@"NO (Norway).")]
    Norway = ExternalCashClearingSystemCode.Norway, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NICS Real (Norway)
    /// Encoded/decoded by serializers as &quot;NOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOR")]
    [IsoId("_tiIbTvRYEeuLhpyIdtJzwg")]
    [Description(@"NICS Real (Norway)")]
    NorwayNICSReal = ExternalCashClearingSystemCode.NorwayNICSReal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AU (Australia) - New Payments Platform (NPP).
    /// Encoded/decoded by serializers as &quot;NPP&quot;.
    /// </summary>
    [EnumMember(Value = "NPP")]
    [IsoId("_tiSMQvRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia) - New Payments Platform (NPP).")]
    AustraliaNPP = ExternalCashClearingSystemCode.AustraliaNPP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US (United States) - Federal Reserve Banks National Settlement Service.
    /// Encoded/decoded by serializers as &quot;NSS&quot;.
    /// </summary>
    [EnumMember(Value = "NSS")]
    [IsoId("_tiSMRfRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - Federal Reserve Banks National Settlement Service.")]
    USNSS = ExternalCashClearingSystemCode.USNSS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NZ (New Zealand) – New Zealand Dollar RTGS (ESAS)
    /// Encoded/decoded by serializers as &quot;NZE&quot;.
    /// </summary>
    [EnumMember(Value = "NZE")]
    [IsoId("_tiSMSPRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) – New Zealand Dollar RTGS (ESAS)")]
    NewZealandRTGS = ExternalCashClearingSystemCode.NewZealandRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland).
    /// Encoded/decoded by serializers as &quot;PCH&quot;.
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_tiSMS_RYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland).")]
    Switzerland = ExternalCashClearingSystemCode.Switzerland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AU (Australia).
    /// Encoded/decoded by serializers as &quot;PDS&quot;.
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_tiSMTvRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia).")]
    AustraliaPDS = ExternalCashClearingSystemCode.AustraliaPDS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EG (Egypt).
    /// Encoded/decoded by serializers as &quot;PEG&quot;.
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_tib9QvRYEeuLhpyIdtJzwg")]
    [Description(@"EG (Egypt).")]
    Egypt = ExternalCashClearingSystemCode.Egypt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FR (France).
    /// Encoded/decoded by serializers as &quot;PNS&quot;.
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_tib9RfRYEeuLhpyIdtJzwg")]
    [Description(@"FR (France).")]
    FrancePNS = ExternalCashClearingSystemCode.FrancePNS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AT (Austria) – Austrian CSM.
    /// Encoded/decoded by serializers as &quot;PSA&quot;.
    /// </summary>
    [EnumMember(Value = "PSA")]
    [IsoId("_tib9SPRYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) – Austrian CSM.")]
    AustrianCSM = ExternalCashClearingSystemCode.AustrianCSM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as &quot;PTR&quot;.
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_tib9S_RYEeuLhpyIdtJzwg")]
    [Description(@"AO (Angola) - Angola RTGS.")]
    Angola = ExternalCashClearingSystemCode.Angola, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ve (Venezuela).
    /// Encoded/decoded by serializers as &quot;PVE&quot;.
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_tib9TvRYEeuLhpyIdtJzwg")]
    [Description(@"Ve (Venezuela).")]
    Venezuela = ExternalCashClearingSystemCode.Venezuela, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as &quot;ROL&quot;.
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_tilHMvRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO = ExternalCashClearingSystemCode.RomaniaEPO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as &quot;ROS&quot;.
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_tilHNfRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS = ExternalCashClearingSystemCode.RomaniaGSRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as &quot;RTG&quot;.
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_tilHOPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money."
    )]
    RTGS = ExternalCashClearingSystemCode.RTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as &quot;RTP&quot;.
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_tilHO_RYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyRTGSPlus = ExternalCashClearingSystemCode.GermanyRTGSPlus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA (Canada) Real Time Rail Payment System.
    /// Encoded/decoded by serializers as &quot;RTR&quot;.
    /// </summary>
    [EnumMember(Value = "RTR")]
    [IsoId("_tilHPvRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) Real Time Rail Payment System.")]
    RTRCanada = ExternalCashClearingSystemCode.RTRCanada, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank
    /// Encoded/decoded by serializers as &quot;SCL&quot;.
    /// </summary>
    [EnumMember(Value = "SCL")]
    [IsoId("_tiu4MvRYEeuLhpyIdtJzwg")]
    [Description(@"DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank")]
    RPSAndSEPAClearer = ExternalCashClearingSystemCode.RPSAndSEPAClearer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;SCP&quot;.
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_tiu4NfRYEeuLhpyIdtJzwg")]
    [Description(@"CL (Chile) - Chilean Interbank Payment System.")]
    Chili = ExternalCashClearingSystemCode.Chili, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_tiu4OPRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC = ExternalCashClearingSystemCode.SwedenSEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland) – Swiss EUR RTGS named euroSIC.
    /// Encoded/decoded by serializers as &quot;SEU&quot;.
    /// </summary>
    [EnumMember(Value = "SEU")]
    [IsoId("_tiu4O_RYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss EUR RTGS named euroSIC.")]
    euroSIC = ExternalCashClearingSystemCode.euroSIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland) – Swiss CHF RTGS named SIC.
    /// Encoded/decoded by serializers as &quot;SIC&quot;.
    /// </summary>
    [EnumMember(Value = "SIC")]
    [IsoId("_tiu4PvRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss CHF RTGS named SIC.")]
    SIC = ExternalCashClearingSystemCode.SIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.
    /// Encoded/decoded by serializers as &quot;SIP&quot;.
    /// </summary>
    [EnumMember(Value = "SIP")]
    [IsoId("_ti4CIvRYEeuLhpyIdtJzwg")]
    [Description(
        @"CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing."
    )]
    SICIP = ExternalCashClearingSystemCode.SICIP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SI (Slovenia).
    /// Encoded/decoded by serializers as &quot;SIT&quot;.
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_ti4CJfRYEeuLhpyIdtJzwg")]
    [Description(@"SI (Slovenia).")]
    Slovania = ExternalCashClearingSystemCode.Slovania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as &quot;SLB&quot;.
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_tjBzIvRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES = ExternalCashClearingSystemCode.SpainES, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as &quot;SPG&quot;.
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_tjBzJfRYEeuLhpyIdtJzwg")]
    [Description(@"PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal = ExternalCashClearingSystemCode.Portugal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;SSK&quot;.
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_tjBzKPRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK = ExternalCashClearingSystemCode.SwedenSSK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA Clearing STEP 2.
    /// Encoded/decoded by serializers as &quot;ST2&quot;.
    /// </summary>
    [EnumMember(Value = "ST2")]
    [IsoId("_tjBzK_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA Clearing STEP 2.")]
    EBAClearingSTEP2 = ExternalCashClearingSystemCode.EBAClearingSTEP2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as &quot;STG&quot;.
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_tjLkIvRYEeuLhpyIdtJzwg")]
    [Description(@"UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP = ExternalCashClearingSystemCode.UnitedKingdomGBP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as &quot;TBF&quot;.
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_tjLkJfRYEeuLhpyIdtJzwg")]
    [Description(@"FR (France) - French RTGS (TBF).")]
    FranceFR = ExternalCashClearingSystemCode.FranceFR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US - The Clearing House Real-TimePayment System
    /// Encoded/decoded by serializers as &quot;TCH&quot;.
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_tjLkKPRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House Real-TimePayment System")]
    USTCHRealTime = ExternalCashClearingSystemCode.USTCHRealTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Target.
    /// Encoded/decoded by serializers as &quot;TGT&quot;.
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_tjLkK_RYEeuLhpyIdtJzwg")]
    [Description(@"Target.")]
    Target = ExternalCashClearingSystemCode.Target, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TH (Thailand) - Thailand Payment System (BAHTNET).
    /// Encoded/decoded by serializers as &quot;THB&quot;.
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_tjLkLvRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - Thailand Payment System (BAHTNET).")]
    Thailand = ExternalCashClearingSystemCode.Thailand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TH (Thailand) - National ITMX Payment System
    /// Encoded/decoded by serializers as &quot;THN&quot;.
    /// </summary>
    [EnumMember(Value = "THN")]
    [IsoId("_tjUuEvRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - National ITMX Payment System")]
    Thailand_NITMX = ExternalCashClearingSystemCode.Thailand_NITMX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as &quot;TIS&quot;.
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_tjUuFfRYEeuLhpyIdtJzwg")]
    [Description(@"TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania = ExternalCashClearingSystemCode.Tanzania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NL (Netherlands) - Dutch RTGS (TOP)
    /// Encoded/decoded by serializers as &quot;TOP&quot;.
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_tjUuGPRYEeuLhpyIdtJzwg")]
    [Description(@"NL (Netherlands) - Dutch RTGS (TOP) ")]
    Netherlands = ExternalCashClearingSystemCode.Netherlands, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as &quot;TTD&quot;.
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_tjUuG_RYEeuLhpyIdtJzwg")]
    [Description(@"TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago = ExternalCashClearingSystemCode.TrinidadAndTobago, // same ordinal as derivation source for type conversions

    /// <summary>
    /// United States Dollar  (USD) – US Bulk Exchange Clearing System (USBE)
    /// Encoded/decoded by serializers as &quot;UBE&quot;.
    /// </summary>
    [EnumMember(Value = "UBE")]
    [IsoId("_tjUuHvRYEeuLhpyIdtJzwg")]
    [Description(@"United States Dollar  (USD) – US Bulk Exchange Clearing System (USBE)")]
    CanadaUSBE = ExternalCashClearingSystemCode.CanadaUSBE, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;UIS&quot;.
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_tjefEvRYEeuLhpyIdtJzwg")]
    [Description(@"UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda = ExternalCashClearingSystemCode.Uganda, // same ordinal as derivation source for type conversions

    /// <summary>
    /// India Unified Payments Interface.
    /// Encoded/decoded by serializers as &quot;UPI&quot;.
    /// </summary>
    [EnumMember(Value = "UPI")]
    [IsoId("_tjefFfRYEeuLhpyIdtJzwg")]
    [Description(@"India Unified Payments Interface.")]
    IndiaUnifiedPaymentsInterface = ExternalCashClearingSystemCode.IndiaUnifiedPaymentsInterface, // same ordinal as derivation source for type conversions

    /// <summary>
    /// VocaLink Clearing System
    /// Encoded/decoded by serializers as &quot;VCS&quot;.
    /// </summary>
    [EnumMember(Value = "VCS")]
    [IsoId("_tjefGPRYEeuLhpyIdtJzwg")]
    [Description(@"VocaLink Clearing System")]
    VocaLink = ExternalCashClearingSystemCode.VocaLink, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA step 2.
    /// Encoded/decoded by serializers as &quot;XCT&quot;.
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_tjefG_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 2.")]
    EBASTEP2XCT = ExternalCashClearingSystemCode.EBASTEP2XCT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as &quot;ZEN&quot;.
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_tjoQEvRYEeuLhpyIdtJzwg")]
    [Description(
        @"JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association."
    )]
    Zengin = ExternalCashClearingSystemCode.Zengin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ZW (Zimbabwe) - Zimbabwe Electronic Transfer &amp; Settlement System.
    /// Encoded/decoded by serializers as &quot;ZET&quot;.
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_tjoQFfRYEeuLhpyIdtJzwg")]
    [Description(@"ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.")]
    Zimbabwe = ExternalCashClearingSystemCode.Zimbabwe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ZM (Zambia) - Zambian Interbank Payment &amp;Settlement System.
    /// Encoded/decoded by serializers as &quot;ZIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_tjoQGPRYEeuLhpyIdtJzwg")]
    [Description(@"ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia = ExternalCashClearingSystemCode.Zambia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// IS (Iceland) – Icelandic krona RTGS (MBK).
    /// Encoded/decoded by serializers as &quot;ISG&quot;.
    /// </summary>
    [EnumMember(Value = "ISG")]
    [IsoId("_QIdhIQQzEey95qpfbNuEwg")]
    [Description(@"IS (Iceland) – Icelandic krona RTGS (MBK).")]
    Iceland = ExternalCashClearingSystemCode.Iceland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NO - Norway NOK RTGS Norges Bank
    /// Encoded/decoded by serializers as &quot;NBO&quot;.
    /// </summary>
    [EnumMember(Value = "NBO")]
    [IsoId("_264WwQTUEey95qpfbNuEwg")]
    [Description(@"NO - Norway NOK RTGS Norges Bank")]
    NorwayRTGS = ExternalCashClearingSystemCode.NorwayRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NG (Nigeria) - Interswitch.
    /// Encoded/decoded by serializers as &quot;ISW&quot;.
    /// </summary>
    [EnumMember(Value = "ISW")]
    [IsoId("_1qYB0VErEey6cYDbEubNXg")]
    [Description(@"NG (Nigeria) - Interswitch.")]
    NGInterswitch = ExternalCashClearingSystemCode.NGInterswitch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// P27 Clearing – Instant Payment Platform.
    /// Encoded/decoded by serializers as &quot;I27&quot;.
    /// </summary>
    [EnumMember(Value = "I27")]
    [IsoId("_ny7BcY5CEeyANo-d7JlQ1A")]
    [Description(@"P27 Clearing – Instant Payment Platform.")]
    P27RealTime = ExternalCashClearingSystemCode.P27RealTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// P27 Clearing – Batch Payment Platform.
    /// Encoded/decoded by serializers as &quot;B27&quot;.
    /// </summary>
    [EnumMember(Value = "B27")]
    [IsoId("_ogX9UY5CEeyANo-d7JlQ1A")]
    [Description(@"P27 Clearing – Batch Payment Platform.")]
    P27 = ExternalCashClearingSystemCode.P27, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UK (United Kingdom) – Pay.UK Sterling Domestic.
    /// Encoded/decoded by serializers as &quot;UKD&quot;.
    /// </summary>
    [EnumMember(Value = "UKD")]
    [IsoId("_58H7IY5FEeyANo-d7JlQ1A")]
    [Description(@"UK (United Kingdom) – Pay.UK Sterling Domestic.")]
    UnitedKingdomUKD = ExternalCashClearingSystemCode.UnitedKingdomUKD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SG (Singapore) - Singapore RTGS (SCRIPS).
    /// Encoded/decoded by serializers as &quot;SCR&quot;.
    /// </summary>
    [EnumMember(Value = "SCR")]
    [IsoId("_N8qPweAgEey0k8vo1GQhqQ")]
    [Description(@"SG (Singapore) - Singapore RTGS (SCRIPS).")]
    SingaporeSCRIPS = ExternalCashClearingSystemCode.SingaporeSCRIPS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) – SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;RIX&quot;.
    /// </summary>
    [EnumMember(Value = "RIX")]
    [IsoId("_O-hVYeAgEey0k8vo1GQhqQ")]
    [Description(@"SE (Sweden) – SEK RTGS (RIX).")]
    RIXRTGSSverigesRiksbank = ExternalCashClearingSystemCode.RIXRTGSSverigesRiksbank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Banco de Mocambique RTGS system.
    /// Encoded/decoded by serializers as &quot;MOC&quot;.
    /// </summary>
    [EnumMember(Value = "MOC")]
    [IsoId("_z88_gmvXEe2F6NrIyOmXcA")]
    [Description(@"Banco de Mocambique RTGS system.")]
    BancoDeMocambiqueRTGS = ExternalCashClearingSystemCode.BancoDeMocambiqueRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// KR (South Korea) – Korean Won RTGS (BOK-Wire+).
    /// Encoded/decoded by serializers as &quot;BOK&quot;.
    /// </summary>
    [EnumMember(Value = "BOK")]
    [IsoId("_eNhwIv7LEe2ORYPQEd-Clg")]
    [Description(@"KR (South Korea) – Korean Won RTGS (BOK-Wire+).")]
    KoreaBOKWire = ExternalCashClearingSystemCode.KoreaBOKWire, // same ordinal as derivation source for type conversions
}
