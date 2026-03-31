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
[IsoId("_8MlMg6MgEeCJ6YNENx4h-w_-216754992")]
[Description(
    @"Specifies the market infrastructure identification, as published in an external market infrastructure code list.|This is a synonym of the external cash clearing system code list, extended outside the pure cash domains.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalMarketInfrastructureCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalMarketInfrastructure1Code>))]
#endif
public enum ExternalMarketInfrastructure1Code
{
    /// <summary>
    /// EBA Euro1/Step1.
    /// Encoded/decoded by serializers as &quot;ABE&quot;.
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_uiNYOPRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1/Step1.")]
    EBAEuro1Step1 = ExternalMarketInfrastructureCode.EBAEuro1Step1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;ACH&quot;.
    /// </summary>
    [EnumMember(Value = "ACH")]
    [IsoId("_uiXJMvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis."
    )]
    ACH = ExternalMarketInfrastructureCode.ACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS)
    /// Encoded/decoded by serializers as &quot;ACS&quot;.
    /// </summary>
    [EnumMember(Value = "ACS")]
    [IsoId("_uiXJNfRYEeuLhpyIdtJzwg")]
    [Description(@"Canadian Dollar (CAD)  - Automated Clearing Settlement System (ACSS) ")]
    CanadaACSS = ExternalMarketInfrastructureCode.CanadaACSS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AL (Albania) -  Albania Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;AIP&quot;.
    /// </summary>
    [EnumMember(Value = "AIP")]
    [IsoId("_uigTIvRYEeuLhpyIdtJzwg")]
    [Description(@"AL (Albania) -  Albania Interbank Payment System.")]
    Albania = ExternalMarketInfrastructureCode.Albania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as &quot;ART&quot;.
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_uigTJfRYEeuLhpyIdtJzwg")]
    [Description(@"AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian = ExternalMarketInfrastructureCode.Austrian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as &quot;AVP&quot;.
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_uigTKPRYEeuLhpyIdtJzwg")]
    [Description(@"NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand = ExternalMarketInfrastructureCode.NewZealand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as &quot;AZM&quot;.
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_uigTK_RYEeuLhpyIdtJzwg")]
    [Description(@"AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan = ExternalMarketInfrastructureCode.Azerbaijan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as &quot;BAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_uiqEIvRYEeuLhpyIdtJzwg")]
    [Description(@"BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina = ExternalMarketInfrastructureCode.BosniaHerzegovina, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) - Sweden BGC Clearing CUG.
    /// Encoded/decoded by serializers as &quot;BCC&quot;.
    /// </summary>
    [EnumMember(Value = "BCC")]
    [IsoId("_uiqEJfRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Sweden BGC Clearing CUG.")]
    SwedenBGC = ExternalMarketInfrastructureCode.SwedenBGC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)
    /// Encoded/decoded by serializers as &quot;BCE&quot;.
    /// </summary>
    [EnumMember(Value = "BCE")]
    [IsoId("_uiz1IvRYEeuLhpyIdtJzwg")]
    [Description(
        @"EC (Ecuador) - Ecuadorian Central Payment System (Sistema Central de Pagos Ecuatoriano)"
    )]
    Ecuador = ExternalMarketInfrastructureCode.Ecuador, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BB (Barbados) - Barbados RTGS (CBRTGS).
    /// Encoded/decoded by serializers as &quot;BDS&quot;.
    /// </summary>
    [EnumMember(Value = "BDS")]
    [IsoId("_uiz1JfRYEeuLhpyIdtJzwg")]
    [Description(@"BB (Barbados) - Barbados RTGS (CBRTGS).")]
    Barbados = ExternalMarketInfrastructureCode.Barbados, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as &quot;BEL&quot;.
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_uiz1KPRYEeuLhpyIdtJzwg")]
    [Description(@"BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium = ExternalMarketInfrastructureCode.Belgium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BG (Bulgaria) - Bulgaria RTGS.
    /// Encoded/decoded by serializers as &quot;BGN&quot;.
    /// </summary>
    [EnumMember(Value = "BGN")]
    [IsoId("_ui8_EvRYEeuLhpyIdtJzwg")]
    [Description(@"BG (Bulgaria) - Bulgaria RTGS.")]
    Bulgaria = ExternalMarketInfrastructureCode.Bulgaria, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BS (Bahamas) - Bahamas RTGS.
    /// Encoded/decoded by serializers as &quot;BHS&quot;.
    /// </summary>
    [EnumMember(Value = "BHS")]
    [IsoId("_ui8_FfRYEeuLhpyIdtJzwg")]
    [Description(@"BS (Bahamas) - Bahamas RTGS.")]
    Bahamas = ExternalMarketInfrastructureCode.Bahamas, // same ordinal as derivation source for type conversions

    /// <summary>
    /// BW (Botswana) - Botswana Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;BIS&quot;.
    /// </summary>
    [EnumMember(Value = "BIS")]
    [IsoId("_ujGwEvRYEeuLhpyIdtJzwg")]
    [Description(@"BW (Botswana) - Botswana Interbank Settlement System.")]
    Botswana = ExternalMarketInfrastructureCode.Botswana, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as &quot;BOF&quot;.
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_ujGwFfRYEeuLhpyIdtJzwg")]
    [Description(@"FI (Finland) - RTGS (BOF).")]
    Finland = ExternalMarketInfrastructureCode.Finland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as &quot;BOJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_ujGwGPRYEeuLhpyIdtJzwg")]
    [Description(@"the Bank of Japan clearing system.")]
    BankOfJapanNet = ExternalMarketInfrastructureCode.BankOfJapanNet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as &quot;BRL&quot;.
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_ujGwG_RYEeuLhpyIdtJzwg")]
    [Description(@"IT (Italy) - Italy RTGS (BIREL).")]
    Italy = ExternalMarketInfrastructureCode.Italy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PH (Philippines) - Philippines Payment System.
    /// Encoded/decoded by serializers as &quot;BSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSP")]
    [IsoId("_ujP6AvRYEeuLhpyIdtJzwg")]
    [Description(@"PH (Philippines) - Philippines Payment System.")]
    Philippines = ExternalMarketInfrastructureCode.Philippines, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA (Canada) - Canadian Large Value Transfer System (LVTS)
    /// Encoded/decoded by serializers as &quot;CAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_ujP6BfRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Canadian Large Value Transfer System (LVTS)")]
    CanadaCAD = ExternalMarketInfrastructureCode.CanadaCAD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ES (Spain).
    /// Encoded/decoded by serializers as &quot;CAM&quot;.
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_ujZrAvRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain).")]
    SpainCAM = ExternalMarketInfrastructureCode.SpainCAM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AW (Aruba) - Central Bank of Aruba CSM
    /// Encoded/decoded by serializers as &quot;CBA&quot;.
    /// </summary>
    [EnumMember(Value = "CBA")]
    [IsoId("_ujZrBfRYEeuLhpyIdtJzwg")]
    [Description(@"AW (Aruba) - Central Bank of Aruba CSM")]
    CentralBankOfArubaCSM = ExternalMarketInfrastructureCode.CentralBankOfArubaCSM, // same ordinal as derivation source for type conversions

    /// <summary>
    /// IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as &quot;CBJ&quot;.
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_ujjcAvRYEeuLhpyIdtJzwg")]
    [Description(@"IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland = ExternalMarketInfrastructureCode.Ireland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US - The Clearing House CHIPS
    /// Encoded/decoded by serializers as &quot;CHI&quot;.
    /// </summary>
    [EnumMember(Value = "CHI")]
    [IsoId("_ujjcBfRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House CHIPS")]
    USTCHChips = ExternalMarketInfrastructureCode.USTCHChips, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as &quot;CHP&quot;.
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_ujjcCPRYEeuLhpyIdtJzwg")]
    [Description(@"GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom = ExternalMarketInfrastructureCode.UnitedKingdom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA.
    /// Encoded/decoded by serializers as &quot;CIS&quot;.
    /// </summary>
    [EnumMember(Value = "CIS")]
    [IsoId("_ujjcC_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Central Interoperability Service of the EACHA Clearing Cooperative, for exchanging SEPA payments between Automated Clearing Houses in the EEA."
    )]
    CentralInteroperabilityService =
        ExternalMarketInfrastructureCode.CentralInteroperabilityService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payments and cash management system that settles individual payments and cash transfers in central bank money.
    /// Encoded/decoded by serializers as &quot;CLM&quot;.
    /// </summary>
    [EnumMember(Value = "CLM")]
    [IsoId("_ujjcDvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payments and cash management system that settles individual payments and cash transfers in central bank money."
    )]
    CentralLiquidityManagement = ExternalMarketInfrastructureCode.CentralLiquidityManagement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques).
    /// Encoded/decoded by serializers as &quot;COE&quot;.
    /// </summary>
    [EnumMember(Value = "COE")]
    [IsoId("_ujsl8vRYEeuLhpyIdtJzwg")]
    [Description(
        @"CO (Columbia) - Colombian Electronic Cheque System named CEDEC (Compensación Electrónica De Cheques)."
    )]
    ColumbiaCEDEC = ExternalMarketInfrastructureCode.ColumbiaCEDEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria).
    /// Encoded/decoded by serializers as &quot;COI&quot;.
    /// </summary>
    [EnumMember(Value = "COI")]
    [IsoId("_ujsl9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"CO (Columbia) - Colombian Central Bank´s ACH named CENIT (Compensación Electrónica Nacional Interbancaria)."
    )]
    ColumbiaCENIT = ExternalMarketInfrastructureCode.ColumbiaCENIT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).
    /// Encoded/decoded by serializers as &quot;COU&quot;.
    /// </summary>
    [EnumMember(Value = "COU")]
    [IsoId("_uj2W8vRYEeuLhpyIdtJzwg")]
    [Description(@"CO (Columbia) - Colombian RTGS System named CUD (Cuentas de Depósito).")]
    ColumbiaRTGS = ExternalMarketInfrastructureCode.ColumbiaRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DK (Denmark) - Danish Krone RTGS (KRONOS)
    /// Encoded/decoded by serializers as &quot;DDK&quot;.
    /// </summary>
    [EnumMember(Value = "DDK")]
    [IsoId("_uj2W9fRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Krone RTGS (KRONOS)")]
    DenmarkDDK = ExternalMarketInfrastructureCode.DenmarkDDK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DK (Denmark) - Danish Euro RTGS (KRONOS)
    /// Encoded/decoded by serializers as &quot;DKC&quot;.
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_ukAH8vRYEeuLhpyIdtJzwg")]
    [Description(@"DK (Denmark) - Danish Euro RTGS (KRONOS)")]
    Denmark = ExternalMarketInfrastructureCode.Denmark, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA Euro1.
    /// Encoded/decoded by serializers as &quot;EBA&quot;.
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_ukAH9fRYEeuLhpyIdtJzwg")]
    [Description(@"EBA Euro1.")]
    EBAEuro1 = ExternalMarketInfrastructureCode.EBAEuro1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as &quot;ELS&quot;.
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_ukAH-PRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyELS = ExternalMarketInfrastructureCode.GermanyELS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Elektronischer Massenzahlungsverkehr (EMZ)
    /// Encoded/decoded by serializers as &quot;EMZ&quot;.
    /// </summary>
    [EnumMember(Value = "EMZ")]
    [IsoId("_ukAH-_RYEeuLhpyIdtJzwg")]
    [Description(@"Elektronischer Massenzahlungsverkehr (EMZ)")]
    Germany = ExternalMarketInfrastructureCode.Germany, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ECB (European Central Bank) - ECB Payment Mechanism.
    /// Encoded/decoded by serializers as &quot;EPM&quot;.
    /// </summary>
    [EnumMember(Value = "EPM")]
    [IsoId("_ukAH_vRYEeuLhpyIdtJzwg")]
    [Description(@"ECB (European Central Bank) - ECB Payment Mechanism.")]
    ECB = ExternalMarketInfrastructureCode.ECB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US - The Clearing House EPN
    /// Encoded/decoded by serializers as &quot;EPN&quot;.
    /// </summary>
    [EnumMember(Value = "EPN")]
    [IsoId("_ukJR4vRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House EPN")]
    USTCHEPN = ExternalMarketInfrastructureCode.USTCHEPN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA step 1 (members).
    /// Encoded/decoded by serializers as &quot;ERP&quot;.
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_ukJR5fRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 1 (members).")]
    EBAStep1 = ExternalMarketInfrastructureCode.EBAStep1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US (United States) - FED-ACH
    /// Encoded/decoded by serializers as &quot;FDA&quot;.
    /// </summary>
    [EnumMember(Value = "FDA")]
    [IsoId("_ukTC4vRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) - FED-ACH")]
    USFedACH = ExternalMarketInfrastructureCode.USFedACH, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FedNet is a link to a Federal Bank account via the internet.  FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc.
    /// Encoded/decoded by serializers as &quot;FDN&quot;.
    /// </summary>
    [EnumMember(Value = "FDN")]
    [IsoId("_ukTC5fRYEeuLhpyIdtJzwg")]
    [Description(
        @"FedNet is a link to a Federal Bank account via the internet.  FedNet enables checking of account balance, transactions, take print outs of account statement, transfer funds to third party accounts, E-shopping, BSNL Payments, Deposit opening, Deposit Renewal, Request for Demand Draft, Cheque Book etc."
    )]
    FedNet = ExternalMarketInfrastructureCode.FedNet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US (United States) – FEDWIRE
    /// Encoded/decoded by serializers as &quot;FDW&quot;.
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_ukTC6PRYEeuLhpyIdtJzwg")]
    [Description(@"US (United States) – FEDWIRE")]
    USFedwire = ExternalMarketInfrastructureCode.USFedwire, // same ordinal as derivation source for type conversions

    /// <summary>
    /// JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as &quot;FEY&quot;.
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_ukTC6_RYEeuLhpyIdtJzwg")]
    [Description(
        @"JP (Japan) the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank."
    )]
    ForeignExchangeYenClearing = ExternalMarketInfrastructureCode.ForeignExchangeYenClearing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GH (Ghana) - Ghana Interbank Settlement System (GISS).
    /// Encoded/decoded by serializers as &quot;GIS&quot;.
    /// </summary>
    [EnumMember(Value = "GIS")]
    [IsoId("_ukTC7vRYEeuLhpyIdtJzwg")]
    [Description(@"GH (Ghana) - Ghana Interbank Settlement System (GISS).")]
    Ghana = ExternalMarketInfrastructureCode.Ghana, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as &quot;HRK&quot;.
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_ukcz4vRYEeuLhpyIdtJzwg")]
    [Description(@"HR (Croatia) - HSVP.")]
    Croatia = ExternalMarketInfrastructureCode.Croatia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as &quot;HRM&quot;.
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_ukcz5fRYEeuLhpyIdtJzwg")]
    [Description(@"GR (Greece) - Greek RTGS (HERMES).")]
    Greece = ExternalMarketInfrastructureCode.Greece, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as &quot;HUF&quot;.
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_ukcz6PRYEeuLhpyIdtJzwg")]
    [Description(@"HU (Hungary) - VIBER.")]
    Hungary = ExternalMarketInfrastructureCode.Hungary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE and NL - Equens
    /// Encoded/decoded by serializers as &quot;INC&quot;.
    /// </summary>
    [EnumMember(Value = "INC")]
    [IsoId("_ukcz6_RYEeuLhpyIdtJzwg")]
    [Description(@"DE and NL - Equens ")]
    DEandNLEquens = ExternalMarketInfrastructureCode.DEandNLEquens, // same ordinal as derivation source for type conversions

    /// <summary>
    /// JO (Jordan) - Jordan RTGS.
    /// Encoded/decoded by serializers as &quot;JOD&quot;.
    /// </summary>
    [EnumMember(Value = "JOD")]
    [IsoId("_ukcz7vRYEeuLhpyIdtJzwg")]
    [Description(@"JO (Jordan) - Jordan RTGS.")]
    Jordan = ExternalMarketInfrastructureCode.Jordan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// KE (Kenya) - Kenyan Electronic Payment Settlement System.
    /// Encoded/decoded by serializers as &quot;KPS&quot;.
    /// </summary>
    [EnumMember(Value = "KPS")]
    [IsoId("_ukl90vRYEeuLhpyIdtJzwg")]
    [Description(@"KE (Kenya) - Kenyan Electronic Payment Settlement System.")]
    Kenya = ExternalMarketInfrastructureCode.Kenya, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as &quot;LGS&quot;.
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_ukl91fRYEeuLhpyIdtJzwg")]
    [Description(@"LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg = ExternalMarketInfrastructureCode.Luxemburg, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LK (Sri Lanka) - Sri Lanka (Lankasettle).
    /// Encoded/decoded by serializers as &quot;LKB&quot;.
    /// </summary>
    [EnumMember(Value = "LKB")]
    [IsoId("_ukvu0vRYEeuLhpyIdtJzwg")]
    [Description(@"LK (Sri Lanka) - Sri Lanka (Lankasettle).")]
    SriLanka = ExternalMarketInfrastructureCode.SriLanka, // same ordinal as derivation source for type conversions

    /// <summary>
    /// LV (Latvia).
    /// Encoded/decoded by serializers as &quot;LVL&quot;.
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_ukvu1fRYEeuLhpyIdtJzwg")]
    [Description(@"LV (Latvia).")]
    Latvia = ExternalMarketInfrastructureCode.Latvia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CA (Canada) - Large Value Transfer System (LVTS).  Replaces CAD.
    /// Encoded/decoded by serializers as &quot;LVT&quot;.
    /// </summary>
    [EnumMember(Value = "LVT")]
    [IsoId("_ukvu2PRYEeuLhpyIdtJzwg")]
    [Description(@"CA (Canada) - Large Value Transfer System (LVTS).  Replaces CAD.")]
    CanadaLVTS = ExternalMarketInfrastructureCode.CanadaLVTS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SG (Singapore) - Singapore RTGS (MEPS+).
    /// Encoded/decoded by serializers as &quot;MEP&quot;.
    /// </summary>
    [EnumMember(Value = "MEP")]
    [IsoId("_ukvu2_RYEeuLhpyIdtJzwg")]
    [Description(@"SG (Singapore) - Singapore RTGS (MEPS+).")]
    Singapore = ExternalMarketInfrastructureCode.Singapore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as &quot;MOS&quot;.
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_ukvu3vRYEeuLhpyIdtJzwg")]
    [Description(@"ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica = ExternalMarketInfrastructureCode.SouthAfrica, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MT (Malta) - Malta Realtime Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;MRS&quot;.
    /// </summary>
    [EnumMember(Value = "MRS")]
    [IsoId("_uk44wvRYEeuLhpyIdtJzwg")]
    [Description(@"MT (Malta) - Malta Realtime Interbank Settlement System.")]
    Malta = ExternalMarketInfrastructureCode.Malta, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MU (Mauritius).
    /// Encoded/decoded by serializers as &quot;MUP&quot;.
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_uk44xfRYEeuLhpyIdtJzwg")]
    [Description(@"MU (Mauritius).")]
    Mauritius = ExternalMarketInfrastructureCode.Mauritius, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NA (Namibian) - Namibian Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;NAM&quot;.
    /// </summary>
    [EnumMember(Value = "NAM")]
    [IsoId("_ulCpwvRYEeuLhpyIdtJzwg")]
    [Description(@"NA (Namibian) - Namibian Interbank Settlement System.")]
    Namibia = ExternalMarketInfrastructureCode.Namibia, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NO (Norway).
    /// Encoded/decoded by serializers as &quot;NOC&quot;.
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_ulCpxfRYEeuLhpyIdtJzwg")]
    [Description(@"NO (Norway).")]
    Norway = ExternalMarketInfrastructureCode.Norway, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AU (Australia) - New Payments Platform (NPP)
    /// Encoded/decoded by serializers as &quot;NPP&quot;.
    /// </summary>
    [EnumMember(Value = "NPP")]
    [IsoId("_ulLzsvRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia) - New Payments Platform (NPP)")]
    AustraliaNPP = ExternalMarketInfrastructureCode.AustraliaNPP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland).
    /// Encoded/decoded by serializers as &quot;PCH&quot;.
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_ulLztfRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland).")]
    Switzerland = ExternalMarketInfrastructureCode.Switzerland, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AU (Australia).
    /// Encoded/decoded by serializers as &quot;PDS&quot;.
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_ulLzuPRYEeuLhpyIdtJzwg")]
    [Description(@"AU (Australia).")]
    AustraliaPDS = ExternalMarketInfrastructureCode.AustraliaPDS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EG (Egypt).
    /// Encoded/decoded by serializers as &quot;PEG&quot;.
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_ulVksvRYEeuLhpyIdtJzwg")]
    [Description(@"EG (Egypt).")]
    Egypt = ExternalMarketInfrastructureCode.Egypt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FR (France).
    /// Encoded/decoded by serializers as &quot;PNS&quot;.
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_ulVktfRYEeuLhpyIdtJzwg")]
    [Description(@"FR (France).")]
    FrancePNS = ExternalMarketInfrastructureCode.FrancePNS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// AO (Angola) - Angola RTGS.
    /// Encoded/decoded by serializers as &quot;PTR&quot;.
    /// </summary>
    [EnumMember(Value = "PTR")]
    [IsoId("_ulVkuPRYEeuLhpyIdtJzwg")]
    [Description(@"AO (Angola) - Angola RTGS.")]
    Angola = ExternalMarketInfrastructureCode.Angola, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ve (Venezuela).
    /// Encoded/decoded by serializers as &quot;PVE&quot;.
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_ulVku_RYEeuLhpyIdtJzwg")]
    [Description(@"Ve (Venezuela).")]
    Venezuela = ExternalMarketInfrastructureCode.Venezuela, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RO (Romania) - Romanian Electronic Payment Operations RT.
    /// Encoded/decoded by serializers as &quot;ROL&quot;.
    /// </summary>
    [EnumMember(Value = "ROL")]
    [IsoId("_ulfVsvRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian Electronic Payment Operations RT.")]
    RomaniaEPO = ExternalMarketInfrastructureCode.RomaniaEPO, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RO (Romania) - Romanian GSRS.
    /// Encoded/decoded by serializers as &quot;ROS&quot;.
    /// </summary>
    [EnumMember(Value = "ROS")]
    [IsoId("_ulfVtfRYEeuLhpyIdtJzwg")]
    [Description(@"RO (Romania) - Romanian GSRS.")]
    RomaniaGSRS = ExternalMarketInfrastructureCode.RomaniaGSRS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as &quot;RTG&quot;.
    /// </summary>
    [EnumMember(Value = "RTG")]
    [IsoId("_ulfVuPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money."
    )]
    RTGS = ExternalMarketInfrastructureCode.RTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE (Germany).
    /// Encoded/decoded by serializers as &quot;RTP&quot;.
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_ulpGsvRYEeuLhpyIdtJzwg")]
    [Description(@"DE (Germany).")]
    GermanyRTGSPlus = ExternalMarketInfrastructureCode.GermanyRTGSPlus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank
    /// Encoded/decoded by serializers as &quot;SCL&quot;.
    /// </summary>
    [EnumMember(Value = "SCL")]
    [IsoId("_ulpGtfRYEeuLhpyIdtJzwg")]
    [Description(@"DE – SEPA-Clearer of the Retail Payment System operated by Deutsche Bundesbank")]
    RPSAndSEPAClearer = ExternalMarketInfrastructureCode.RPSAndSEPAClearer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CL (Chile) - Chilean Interbank Payment System.
    /// Encoded/decoded by serializers as &quot;SCP&quot;.
    /// </summary>
    [EnumMember(Value = "SCP")]
    [IsoId("_ulpGuPRYEeuLhpyIdtJzwg")]
    [Description(@"CL (Chile) - Chilean Interbank Payment System.")]
    Chili = ExternalMarketInfrastructureCode.Chili, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_ulpGu_RYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC = ExternalMarketInfrastructureCode.SwedenSEC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland) – Swiss EUR RTGS named euroSIC.
    /// Encoded/decoded by serializers as &quot;SEU&quot;.
    /// </summary>
    [EnumMember(Value = "SEU")]
    [IsoId("_ulyQovRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss EUR RTGS named euroSIC.")]
    euroSIC = ExternalMarketInfrastructureCode.euroSIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland) – Swiss CHF RTGS named SIC.
    /// Encoded/decoded by serializers as &quot;SIC&quot;.
    /// </summary>
    [EnumMember(Value = "SIC")]
    [IsoId("_ulyQpfRYEeuLhpyIdtJzwg")]
    [Description(@"CH (Switzerland) – Swiss CHF RTGS named SIC.")]
    SIC = ExternalMarketInfrastructureCode.SIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing.
    /// Encoded/decoded by serializers as &quot;SIP&quot;.
    /// </summary>
    [EnumMember(Value = "SIP")]
    [IsoId("_ulyQqPRYEeuLhpyIdtJzwg")]
    [Description(
        @"CH (Switzerland) – Swiss Instant Payment service in CHF operated by SIX Interbank Clearing."
    )]
    SICIP = ExternalMarketInfrastructureCode.SICIP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SI (Slovenia).
    /// Encoded/decoded by serializers as &quot;SIT&quot;.
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_ulyQq_RYEeuLhpyIdtJzwg")]
    [Description(@"SI (Slovenia).")]
    Slovania = ExternalMarketInfrastructureCode.Slovania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as &quot;SLB&quot;.
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_ul8BovRYEeuLhpyIdtJzwg")]
    [Description(@"ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES = ExternalMarketInfrastructureCode.SpainES, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as &quot;SPG&quot;.
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_ul8BpfRYEeuLhpyIdtJzwg")]
    [Description(@"PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal = ExternalMarketInfrastructureCode.Portugal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;SSK&quot;.
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_ul8BqPRYEeuLhpyIdtJzwg")]
    [Description(@"SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK = ExternalMarketInfrastructureCode.SwedenSSK, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA Clearing STEP 2.
    /// Encoded/decoded by serializers as &quot;ST2&quot;.
    /// </summary>
    [EnumMember(Value = "ST2")]
    [IsoId("_ul8Bq_RYEeuLhpyIdtJzwg")]
    [Description(@"EBA Clearing STEP 2.")]
    EBAClearingStep2 = ExternalMarketInfrastructureCode.EBAClearingStep2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UK (United Kingdom) - CHAPS Sterling RTGS.
    /// Encoded/decoded by serializers as &quot;STG&quot;.
    /// </summary>
    [EnumMember(Value = "STG")]
    [IsoId("_ul8BrvRYEeuLhpyIdtJzwg")]
    [Description(@"UK (United Kingdom) - CHAPS Sterling RTGS.")]
    UnitedKingdomGBP = ExternalMarketInfrastructureCode.UnitedKingdomGBP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// T2S.
    /// Encoded/decoded by serializers as &quot;T2S&quot;.
    /// </summary>
    [EnumMember(Value = "T2S")]
    [IsoId("_ul8BsfRYEeuLhpyIdtJzwg")]
    [Description(@"T2S.")]
    T2S = ExternalMarketInfrastructureCode.T2S, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as &quot;TBF&quot;.
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_umFLkvRYEeuLhpyIdtJzwg")]
    [Description(@"FR (France) - French RTGS (TBF).")]
    FranceFR = ExternalMarketInfrastructureCode.FranceFR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// US - The Clearing House Real-TimePayment System
    /// Encoded/decoded by serializers as &quot;TCH&quot;.
    /// </summary>
    [EnumMember(Value = "TCH")]
    [IsoId("_umFLlfRYEeuLhpyIdtJzwg")]
    [Description(@"US - The Clearing House Real-TimePayment System")]
    USTCHRealTime = ExternalMarketInfrastructureCode.USTCHRealTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Target.
    /// Encoded/decoded by serializers as &quot;TGT&quot;.
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_umO8kvRYEeuLhpyIdtJzwg")]
    [Description(@"Target.")]
    Target = ExternalMarketInfrastructureCode.Target, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TH (Thailand) - Thailand Payment System (BAHTNET).
    /// Encoded/decoded by serializers as &quot;THB&quot;.
    /// </summary>
    [EnumMember(Value = "THB")]
    [IsoId("_umO8lfRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - Thailand Payment System (BAHTNET).")]
    Thailand = ExternalMarketInfrastructureCode.Thailand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TH (Thailand) - National ITMX Payment System
    /// Encoded/decoded by serializers as &quot;THN&quot;.
    /// </summary>
    [EnumMember(Value = "THN")]
    [IsoId("_umO8mPRYEeuLhpyIdtJzwg")]
    [Description(@"TH (Thailand) - National ITMX Payment System")]
    ThailandNITMX = ExternalMarketInfrastructureCode.ThailandNITMX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).
    /// Encoded/decoded by serializers as &quot;TIS&quot;.
    /// </summary>
    [EnumMember(Value = "TIS")]
    [IsoId("_umO8m_RYEeuLhpyIdtJzwg")]
    [Description(@"TZ (Tanzania) - Tanzania Interbank Settlement System (TISS).")]
    Tanzania = ExternalMarketInfrastructureCode.Tanzania, // same ordinal as derivation source for type conversions

    /// <summary>
    /// NL (Netherlands) - Dutch RTGS (TOP)
    /// Encoded/decoded by serializers as &quot;TOP&quot;.
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_umO8nvRYEeuLhpyIdtJzwg")]
    [Description(@"NL (Netherlands) - Dutch RTGS (TOP) ")]
    Netherlands = ExternalMarketInfrastructureCode.Netherlands, // same ordinal as derivation source for type conversions

    /// <summary>
    /// TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.
    /// Encoded/decoded by serializers as &quot;TTD&quot;.
    /// </summary>
    [EnumMember(Value = "TTD")]
    [IsoId("_umYtkvRYEeuLhpyIdtJzwg")]
    [Description(@"TT (Trinidad and Tobago ) - Trinidad and Tobago SAFE-TT.")]
    TrinidadAndTobago = ExternalMarketInfrastructureCode.TrinidadAndTobago, // same ordinal as derivation source for type conversions

    /// <summary>
    /// United States Dollar  (USD)
    /// Encoded/decoded by serializers as &quot;UBE&quot;.
    /// </summary>
    [EnumMember(Value = "UBE")]
    [IsoId("_umYtlfRYEeuLhpyIdtJzwg")]
    [Description(@"United States Dollar  (USD)")]
    CanadaUSDUSBE = ExternalMarketInfrastructureCode.CanadaUSDUSBE, // same ordinal as derivation source for type conversions

    /// <summary>
    /// UG (Uganda) - Uganda National Interbank Settlement System.
    /// Encoded/decoded by serializers as &quot;UIS&quot;.
    /// </summary>
    [EnumMember(Value = "UIS")]
    [IsoId("_umYtmPRYEeuLhpyIdtJzwg")]
    [Description(@"UG (Uganda) - Uganda National Interbank Settlement System.")]
    Uganda = ExternalMarketInfrastructureCode.Uganda, // same ordinal as derivation source for type conversions

    /// <summary>
    /// VocaLink Clearing System
    /// Encoded/decoded by serializers as &quot;VCS&quot;.
    /// </summary>
    [EnumMember(Value = "VCS")]
    [IsoId("_umYtm_RYEeuLhpyIdtJzwg")]
    [Description(@"VocaLink Clearing System")]
    VocaLink = ExternalMarketInfrastructureCode.VocaLink, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBA step 2.
    /// Encoded/decoded by serializers as &quot;XCT&quot;.
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_umYtnvRYEeuLhpyIdtJzwg")]
    [Description(@"EBA step 2.")]
    EBAStep2XCT = ExternalMarketInfrastructureCode.EBAStep2XCT, // same ordinal as derivation source for type conversions

    /// <summary>
    /// JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as &quot;ZEN&quot;.
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_umh3gvRYEeuLhpyIdtJzwg")]
    [Description(
        @"JP (Japan) the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association."
    )]
    Zengin = ExternalMarketInfrastructureCode.Zengin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ZW (Zimbabwe) - Zimbabwe Electronic Transfer &amp; Settlement System.
    /// Encoded/decoded by serializers as &quot;ZET&quot;.
    /// </summary>
    [EnumMember(Value = "ZET")]
    [IsoId("_umh3hfRYEeuLhpyIdtJzwg")]
    [Description(@"ZW (Zimbabwe) - Zimbabwe Electronic Transfer & Settlement System.")]
    Zimbabwe = ExternalMarketInfrastructureCode.Zimbabwe, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ZM (Zambia) - Zambian Interbank Payment &amp;Settlement System.
    /// Encoded/decoded by serializers as &quot;ZIS&quot;.
    /// </summary>
    [EnumMember(Value = "ZIS")]
    [IsoId("_umh3iPRYEeuLhpyIdtJzwg")]
    [Description(@"ZM (Zambia) - Zambian Interbank Payment &Settlement System.")]
    Zambia = ExternalMarketInfrastructureCode.Zambia, // same ordinal as derivation source for type conversions
}
