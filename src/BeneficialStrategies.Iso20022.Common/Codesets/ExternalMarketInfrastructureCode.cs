// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the market infrastructure identification, as published in an external market infrastructure code list.
/// This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MwrsIJ05Eeet_4BCDEBLdQ")]
[Description(
    @"Specifies the market infrastructure identification, as published in an external market infrastructure code list.|This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalMarketInfrastructure1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalMarketInfrastructureCode>))]
#endif
public enum ExternalMarketInfrastructureCode
{
    /// <summary>
    /// EBA Euro1/Step1.
    /// Encoded/decoded by serializers as &quot;ABE&quot;.
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_uiNYNvRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1/Step1.")]
    EBAEuro1Step1,

    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;ACH&quot;.
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_uiXJMPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis."
    )]
    ACH,

    /// <summary>
    /// Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS)
    /// Encoded/decoded by serializers as &quot;ACS&quot;.
    /// </summary>
    [EnumMember(Value = "ACS")]
    [IsoId("_uiXJM_RYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) ")]
    CanadaACSS,

    /// <summary>
    /// AL (Albania) -  Albania Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;AIP&quot;.
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_uigTIPRYEeuLhpyIdtJzwg")]
    [Description(@"AL (Albania) -  Albania Interbank Payment System.")]
    Albania,

    /// <summary>
    /// AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as &quot;ART&quot;.
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_uigTI_RYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian,

    /// <summary>
    /// NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as &quot;AVP&quot;.
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_uigTJvRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand,

    /// <summary>
    /// AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as &quot;AZM&quot;.
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_uigTKfRYEeuLhpyIdtJzwg")]
    [Description(@"AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan,

    /// <summary>
    /// BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as &quot;BAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_uiqEIPRYEeuLhpyIdtJzwg")]
    [Description(@"BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina,

    /// <summary>
    /// SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as &quot;BCC&quot;.
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_uiqEI_RYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC,

    /// <summary>
    /// EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)
    /// Encoded/decoded by serializers as &quot;BCE&quot;.
    /// </summary>
    [EnumMember(Value = "BCE")]
    [IsoId("_uiz1IPRYEeuLhpyIdtJzwg")]
    [Description(
        @"EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)"
    )]
    Ecuador,

    /// <summary>
    /// BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as &quot;BDS&quot;.
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_uiz1I_RYEeuLhpyIdtJzwg")]
    [Description(@"BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados,

    /// <summary>
    /// BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as &quot;BEL&quot;.
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_uiz1JvRYEeuLhpyIdtJzwg")]
    [Description(@"BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium,

    /// <summary>
    /// BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as &quot;BGN&quot;.
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_ui8_EPRYEeuLhpyIdtJzwg")]
    [Description(@"BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria,

    /// <summary>
    /// BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as &quot;BHS&quot;.
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_ui8_E_RYEeuLhpyIdtJzwg")]
    [Description(@"BS (Bahamas) - Bahamas RTGS.")]
    Bahamas,

    /// <summary>
    /// BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;BIS&quot;.
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_ujGwEPRYEeuLhpyIdtJzwg")]
    [Description(@"BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana,

    /// <summary>
    /// FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as &quot;BOF&quot;.
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_ujGwE_RYEeuLhpyIdtJzwg")]
    [Description(@"FI (Finland) - RTGS (BOF).")]
    Finland,

    /// <summary>
    /// the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as &quot;BOJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_ujGwFvRYEeuLhpyIdtJzwg")]
    [Description(@"the Bank of Japan clearing system.")]
    BankOfJapanNet,

    /// <summary>
    /// IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as &quot;BRL&quot;.
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_ujGwGfRYEeuLhpyIdtJzwg")]
    [Description(@"IT (Italy) - Italy RTGS (BIREL).")]
    Italy,

    /// <summary>
    /// PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as &quot;BSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_ujP6APRYEeuLhpyIdtJzwg")]
    [Description(@"PH (Philippines) - Philippines Payment System.")]
    Philippines,

    /// <summary>
    /// CA (Canada) - Canadian Large Value Transfer System (LVTS)
    /// Encoded/decoded by serializers as &quot;CAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_ujP6A_RYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Canadian Large Value Transfer System (LVTS)")]
    CanadaCAD,

    /// <summary>
    /// ES (Spain).
    /// Encoded/decoded by serializers as &quot;CAM&quot;.
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_ujZrAPRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain).")]
    SpainCAM,

    /// <summary>
    /// AW (Aruba) - Central Bank of Aruba CSM
    /// Encoded/decoded by serializers as &quot;CBA&quot;.
    /// </summary>
    [EnumMember(Value = "CBA")]
    [IsoId("_ujZrA_RYEeuLhpyIdtJzwg")]
    [Description(@"AW (Aruba) - Central Bank of Aruba CSM")]
    CentralBankOfArubaCSM,

    /// <summary>
    /// IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as &quot;CBJ&quot;.
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_ujjcAPRYEeuLhpyIdtJzwg")]
    [Description(@"IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland,

    /// <summary>
    /// US - The Clearing House CHIPS
    /// Encoded/decoded by serializers as &quot;CHI&quot;.
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_ujjcA_RYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House CHIPS")]
    USTCHChips,

    /// <summary>
    /// GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as &quot;CHP&quot;.
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_ujjcBvRYEeuLhpyIdtJzwg")]
    [Description(@"GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom,

    /// <summary>
    /// Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.
    /// Encoded/decoded by serializers as &quot;CIS&quot;.
    /// </summary>
    [EnumMember(Value = "CIS")]
    [IsoId("_ujjcCfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA."
    )]
    CentralInteroperabilityService,

    /// <summary>
    /// Payments and cash management system that settles individual payments and cash transfers in central bank money.
    /// Encoded/decoded by serializers as &quot;CLM&quot;.
    /// </summary>
    [EnumMember(Value = "CLM")]
    [IsoId("_ujjcDPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payments and cash management system that settles individual payments and cash transfers in central bank money."
    )]
    CentralLiquidityManagement,

    /// <summary>
    /// CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).
    /// Encoded/decoded by serializers as &quot;COE&quot;.
    /// </summary>
    [EnumMember(Value = "COE")]
    [IsoId("_ujsl8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques)."
    )]
    ColumbiaCEDEC,

    /// <summary>
    /// CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).
    /// Encoded/decoded by serializers as &quot;COI&quot;.
    /// </summary>
    [EnumMember(Value = "COI")]
    [IsoId("_ujsl8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria)."
    )]
    ColumbiaCENIT,

    /// <summary>
    /// CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).
    /// Encoded/decoded by serializers as &quot;COU&quot;.
    /// </summary>
    [EnumMember(Value = "COU")]
    [IsoId("_uj2W8PRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).")]
    ColumbiaRTGS,

    /// <summary>
    /// DK (Denmark) - Danish Krone RTGS (KRONOS)
    /// Encoded/decoded by serializers as &quot;DDK&quot;.
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_uj2W8_RYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Krone RTGS (KRONOS)")]
    DenmarkDDK,

    /// <summary>
    /// DK (Denmark) - Danish Euro RTGS (KRONOS)
    /// Encoded/decoded by serializers as &quot;DKC&quot;.
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_ukAH8PRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Euro RTGS (KRONOS)")]
    Denmark,

    /// <summary>
    /// EBA Euro1.
    /// Encoded/decoded by serializers as &quot;EBA&quot;.
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_ukAH8_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1.")]
    EBAEuro1,

    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as &quot;ELS&quot;.
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_ukAH9vRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyELS,

    /// <summary>
    /// Elektronischer Massenzahlungsverkehr (EMZ)
    /// Encoded/decoded by serializers as &quot;EMZ&quot;.
    /// </summary>
    [EnumMember(Value = "EMZ")]
    [IsoId("_ukAH-fRYEeuLhpyIdtJzwg")]
    [Description(@"Elektronischer Massenzahlungsverkehr (EMZ)")]
    Germany,

    /// <summary>
    /// ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as &quot;EPM&quot;.
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_ukAH_PRYEeuLhpyIdtJzwg")]
    [Description(@"ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB,

    /// <summary>
    /// US - The Clearing House EPN
    /// Encoded/decoded by serializers as &quot;EPN&quot;.
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_ukJR4PRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House EPN")]
    USTCHEPN,

    /// <summary>
    /// EBA step 1 (members).
    /// Encoded/decoded by serializers as &quot;ERP&quot;.
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_ukJR4_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 1 (members).")]
    EBAStep1,

    /// <summary>
    /// US (United States) - FED-ACH
    /// Encoded/decoded by serializers as &quot;FDA&quot;.
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_ukTC4PRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - FED-ACH")]
    USFedACH,

    /// <summary>
    /// FedNet is a link to a Federal Bank account via the internet.  FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc.
    /// Encoded/decoded by serializers as &quot;FDN&quot;.
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_ukTC4_RYEeuLhpyIdtJzwg")]
    [Description(
        @"FedNet is a link to a Federal Bank account via the internet.  FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc."
    )]
    FedNet,

    /// <summary>
    /// US (United States) – FEDWIRE
    /// Encoded/decoded by serializers as &quot;FDW&quot;.
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_ukTC5vRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) – FEDWIRE")]
    USFedwire,

    /// <summary>
    /// JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as &quot;FEY&quot;.
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_ukTC6fRYEeuLhpyIdtJzwg")]
    [Description(
        @"JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank."
    )]
    ForeignExchangeYenClearing,

    /// <summary>
    /// GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as &quot;GIS&quot;.
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_ukTC7PRYEeuLhpyIdtJzwg")]
    [Description(@"GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana,

    /// <summary>
    /// HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as &quot;HRK&quot;.
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_ukcz4PRYEeuLhpyIdtJzwg")]
    [Description(@"HR (Croatia) - HSVP.")]
    Croatia,

    /// <summary>
    /// GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as &quot;HRM&quot;.
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_ukcz4_RYEeuLhpyIdtJzwg")]
    [Description(@"GR (Greece) - Greek RTGS (HERMES).")]
    Greece,

    /// <summary>
    /// HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as &quot;HUF&quot;.
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_ukcz5vRYEeuLhpyIdtJzwg")]
    [Description(@"HU (Hungary) - VIBER.")]
    Hungary,

    /// <summary>
    /// DE and NL - Equens
    /// Encoded/decoded by serializers as &quot;INC&quot;.
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_ukcz6fRYEeuLhpyIdtJzwg")]
    [Description(@"DE and NL - Equens ")]
    DEandNLEquens,

    /// <summary>
    /// JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as &quot;JOD&quot;.
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_ukcz7PRYEeuLhpyIdtJzwg")]
    [Description(@"JO (Jordan) - Jordan RTGS.")]
    Jordan,

    /// <summary>
    /// KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as &quot;KPS&quot;.
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_ukl90PRYEeuLhpyIdtJzwg")]
    [Description(@"KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya,

    /// <summary>
    /// LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as &quot;LGS&quot;.
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_ukl90_RYEeuLhpyIdtJzwg")]
    [Description(@"LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg,

    /// <summary>
    /// LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as &quot;LKB&quot;.
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_ukvu0PRYEeuLhpyIdtJzwg")]
    [Description(@"LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka,

    /// <summary>
    /// LV (Latvia).
    /// Encoded/decoded by serializers as &quot;LVL&quot;.
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_ukvu0_RYEeuLhpyIdtJzwg")]
    [Description(@"LV (Latvia).")]
    Latvia,

    /// <summary>
    /// CA (Canada) - Large Value Transfer System (LVTS).  Replaces CAD.
    /// Encoded/decoded by serializers as &quot;LVT&quot;.
    /// </summary>
    [EnumMember(Value = "LVT")]
    [IsoId("_ukvu1vRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Large Value Transfer System (LVTS).  Replaces CAD.")]
    CanadaLVTS,

    /// <summary>
    /// SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as &quot;MEP&quot;.
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_ukvu2fRYEeuLhpyIdtJzwg")]
    [Description(@"SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore,

    /// <summary>
    /// ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as &quot;MOS&quot;.
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_ukvu3PRYEeuLhpyIdtJzwg")]
    [Description(@"ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica,

    /// <summary>
    /// MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;MRS&quot;.
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_uk44wPRYEeuLhpyIdtJzwg")]
    [Description(@"MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta,

    /// <summary>
    /// MU (Mauritius).
    /// Encoded/decoded by serializers as &quot;MUP&quot;.
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_uk44w_RYEeuLhpyIdtJzwg")]
    [Description(@"MU (Mauritius).")]
    Mauritius,

    /// <summary>
    /// NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;NAM&quot;.
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_ulCpwPRYEeuLhpyIdtJzwg")]
    [Description(@"NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia,

    /// <summary>
    /// NO (Norway).
    /// Encoded/decoded by serializers as &quot;NOC&quot;.
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_ulCpw_RYEeuLhpyIdtJzwg")]
    [Description(@"NO (Norway).")]
    Norway,

    /// <summary>
    /// AU (Australia) - New Payments Platform (NPP)
    /// Encoded/decoded by serializers as &quot;NPP&quot;.
    /// </summary>
    [EnumMember(Value = "NPP")]
    [IsoId("_ulLzsPRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia) - New Payments Platform (NPP)")]
    AustraliaNPP,

    /// <summary>
    /// CH (Switzerland).
    /// Encoded/decoded by serializers as &quot;PCH&quot;.
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_ulLzs_RYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland).")]
    Switzerland,

    /// <summary>
    /// AU (Australia).
    /// Encoded/decoded by serializers as &quot;PDS&quot;.
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_ulLztvRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia).")]
    AustraliaPDS,

    /// <summary>
    /// EG (Egypt).
    /// Encoded/decoded by serializers as &quot;PEG&quot;.
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_ulVksPRYEeuLhpyIdtJzwg")]
    [Description(@"EG (Egypt).")]
    Egypt,

    /// <summary>
    /// FR (France).
    /// Encoded/decoded by serializers as &quot;PNS&quot;.
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_ulVks_RYEeuLhpyIdtJzwg")]
    [Description(@"FR (France).")]
    FrancePNS,

    /// <summary>
    /// AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as &quot;PTR&quot;.
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_ulVktvRYEeuLhpyIdtJzwg")]
    [Description(@"AO (Angola) - Angola RTGS.")]
    Angola,

    /// <summary>
    /// Ve (Venezuela).
    /// Encoded/decoded by serializers as &quot;PVE&quot;.
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_ulVkufRYEeuLhpyIdtJzwg")]
    [Description(@"Ve (Venezuela).")]
    Venezuela,

    /// <summary>
    /// RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as &quot;ROL&quot;.
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_ulfVsPRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO,

    /// <summary>
    /// RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as &quot;ROS&quot;.
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_ulfVs_RYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS,

    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as &quot;RTG&quot;.
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_ulfVtvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money."
    )]
    RTGS,

    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as &quot;RTP&quot;.
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_ulpGsPRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyRTGSPlus,

    /// <summary>
    /// DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank
    /// Encoded/decoded by serializers as &quot;SCL&quot;.
    /// </summary>
    [EnumMember(Value = "SCL")]
    [IsoId("_ulpGs_RYEeuLhpyIdtJzwg")]
    [Description(@"DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank")]
    RPSAndSEPAClearer,

    /// <summary>
    /// CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;SCP&quot;.
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_ulpGtvRYEeuLhpyIdtJzwg")]
    [Description(@"CL (Chile) - Chilean Interbank Payment System.")]
    Chili,

    /// <summary>
    /// SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_ulpGufRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC,

    /// <summary>
    /// CH (Switzerland) – Swiss EUR RTGS named euroSIC.
    /// Encoded/decoded by serializers as &quot;SEU&quot;.
    /// </summary>
    [EnumMember(Value = "SEU")]
    [IsoId("_ulyQoPRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss EUR RTGS named euroSIC.")]
    euroSIC,

    /// <summary>
    /// CH (Switzerland) – Swiss CHF RTGS named SIC.
    /// Encoded/decoded by serializers as &quot;SIC&quot;.
    /// </summary>
    [EnumMember(Value = "SIC")]
    [IsoId("_ulyQo_RYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss CHF RTGS named SIC.")]
    SIC,

    /// <summary>
    /// CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.
    /// Encoded/decoded by serializers as &quot;SIP&quot;.
    /// </summary>
    [EnumMember(Value = "SIP")]
    [IsoId("_ulyQpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing."
    )]
    SICIP,

    /// <summary>
    /// SI (Slovenia).
    /// Encoded/decoded by serializers as &quot;SIT&quot;.
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_ulyQqfRYEeuLhpyIdtJzwg")]
    [Description(@"SI (Slovenia).")]
    Slovania,

    /// <summary>
    /// ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as &quot;SLB&quot;.
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_ul8BoPRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES,

    /// <summary>
    /// PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as &quot;SPG&quot;.
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_ul8Bo_RYEeuLhpyIdtJzwg")]
    [Description(@"PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal,

    /// <summary>
    /// SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;SSK&quot;.
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_ul8BpvRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK,

    /// <summary>
    /// EBA Clearing STEP 2.
    /// Encoded/decoded by serializers as &quot;ST2&quot;.
    /// </summary>
    [EnumMember(Value = "ST2")]
    [IsoId("_ul8BqfRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Clearing STEP 2.")]
    EBAClearingStep2,

    /// <summary>
    /// UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as &quot;STG&quot;.
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_ul8BrPRYEeuLhpyIdtJzwg")]
    [Description(@"UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP,

    /// <summary>
    /// T2S.
    /// Encoded/decoded by serializers as &quot;T2S&quot;.
    /// </summary>
    [EnumMember(Value = "T2S")]
    [IsoId("_ul8Br_RYEeuLhpyIdtJzwg")]
    [Description(@"T2S.")]
    T2S,

    /// <summary>
    /// FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as &quot;TBF&quot;.
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_umFLkPRYEeuLhpyIdtJzwg")]
    [Description(@"FR (France) - French RTGS (TBF).")]
    FranceFR,

    /// <summary>
    /// US - The Clearing House Real-TimePayment System
    /// Encoded/decoded by serializers as &quot;TCH&quot;.
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_umFLk_RYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House Real-TimePayment System")]
    USTCHRealTime,

    /// <summary>
    /// Target.
    /// Encoded/decoded by serializers as &quot;TGT&quot;.
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_umO8kPRYEeuLhpyIdtJzwg")]
    [Description(@"Target.")]
    Target,

    /// <summary>
    /// TH (Thailand) - Thailand Payment System (BAHTNET).
    /// Encoded/decoded by serializers as &quot;THB&quot;.
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_umO8k_RYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - Thailand Payment System (BAHTNET).")]
    Thailand,

    /// <summary>
    /// TH (Thailand) - National ITMX Payment System
    /// Encoded/decoded by serializers as &quot;THN&quot;.
    /// </summary>
    [EnumMember(Value = "THN")]
    [IsoId("_umO8lvRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - National ITMX Payment System")]
    ThailandNITMX,

    /// <summary>
    /// TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as &quot;TIS&quot;.
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_umO8mfRYEeuLhpyIdtJzwg")]
    [Description(@"TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania,

    /// <summary>
    /// NL (Netherlands) - Dutch RTGS (TOP)
    /// Encoded/decoded by serializers as &quot;TOP&quot;.
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_umO8nPRYEeuLhpyIdtJzwg")]
    [Description(@"NL (Netherlands) - Dutch RTGS (TOP) ")]
    Netherlands,

    /// <summary>
    /// TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as &quot;TTD&quot;.
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_umYtkPRYEeuLhpyIdtJzwg")]
    [Description(@"TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago,

    /// <summary>
    /// United States Dollar  (USD)
    /// Encoded/decoded by serializers as &quot;UBE&quot;.
    /// </summary>
    [EnumMember(Value = "UBE")]
    [IsoId("_umYtk_RYEeuLhpyIdtJzwg")]
    [Description(@"United States Dollar  (USD)")]
    CanadaUSDUSBE,

    /// <summary>
    /// UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;UIS&quot;.
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_umYtlvRYEeuLhpyIdtJzwg")]
    [Description(@"UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda,

    /// <summary>
    /// VocaLink Clearing System
    /// Encoded/decoded by serializers as &quot;VCS&quot;.
    /// </summary>
    [EnumMember(Value = "VCS")]
    [IsoId("_umYtmfRYEeuLhpyIdtJzwg")]
    [Description(@"VocaLink Clearing System")]
    VocaLink,

    /// <summary>
    /// EBA step 2.
    /// Encoded/decoded by serializers as &quot;XCT&quot;.
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_umYtnPRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 2.")]
    EBAStep2XCT,

    /// <summary>
    /// JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as &quot;ZEN&quot;.
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_umh3gPRYEeuLhpyIdtJzwg")]
    [Description(
        @"JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association."
    )]
    Zengin,

    /// <summary>
    /// ZW (Zimbabwe) - Zimbabwe Electronic Transfer &amp; Settlement System.
    /// Encoded/decoded by serializers as &quot;ZET&quot;.
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_umh3g_RYEeuLhpyIdtJzwg")]
    [Description(@"ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.")]
    Zimbabwe,

    /// <summary>
    /// ZM (Zambia) - Zambian Interbank Payment &amp;Settlement System.
    /// Encoded/decoded by serializers as &quot;ZIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_umh3hvRYEeuLhpyIdtJzwg")]
    [Description(@"ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia,
}
