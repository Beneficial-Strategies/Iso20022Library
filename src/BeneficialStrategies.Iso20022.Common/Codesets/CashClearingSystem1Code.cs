// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a3xY1tp-Ed-ak6NoX_4Aeg_1357735843")]
[Description(@"Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.")]
[DerivedFrom(typeof(CashClearingSystemCode))]
public enum CashClearingSystem1Code
{
    /// <summary>
    /// Scheme code for EBA Euro1/Step1.
    /// Encoded/decoded by serializers as &quot;ABE&quot;.
    /// </summary>
    [EnumMember(Value = "ABE")]
    [IsoId("_a3xY19p-Ed-ak6NoX_4Aeg_1357735860")]
    [Description(@"Scheme code for EBA Euro1/Step1.")]
    EBAEuro1Step1 = CashClearingSystemCode.EBAEuro1Step1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for AT (Austria) - Austrian RTGS (ARTIS).
    /// Encoded/decoded by serializers as &quot;ART&quot;.
    /// </summary>
    [EnumMember(Value = "ART")]
    [IsoId("_a36iwNp-Ed-ak6NoX_4Aeg_1357735861")]
    [Description(@"Scheme code for AT (Austria) - Austrian RTGS (ARTIS).")]
    Austrian = CashClearingSystemCode.Austrian, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.
    /// Encoded/decoded by serializers as &quot;AVP&quot;.
    /// </summary>
    [EnumMember(Value = "AVP")]
    [IsoId("_a36iwdp-Ed-ak6NoX_4Aeg_1357736095")]
    [Description(@"Scheme code for NZ (New Zealand) - New Zealand Assured Value Payments.")]
    NewZealand = CashClearingSystemCode.NewZealand, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).
    /// Encoded/decoded by serializers as &quot;AZM&quot;.
    /// </summary>
    [EnumMember(Value = "AZM")]
    [IsoId("_a36iwtp-Ed-ak6NoX_4Aeg_1357736112")]
    [Description(@"Scheme code for AZ (Azerbaijan) - Azerbaijan Interbank Payment System (AZIPS).")]
    Azerbaijan = CashClearingSystemCode.Azerbaijan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for BA (Bosnia and Herzegovina).
    /// Encoded/decoded by serializers as &quot;BAP&quot;.
    /// </summary>
    [EnumMember(Value = "BAP")]
    [IsoId("_a36iw9p-Ed-ak6NoX_4Aeg_1357736121")]
    [Description(@"Scheme code for BA (Bosnia and Herzegovina).")]
    BosniaHerzegovina = CashClearingSystemCode.BosniaHerzegovina, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).
    /// Encoded/decoded by serializers as &quot;BEL&quot;.
    /// </summary>
    [EnumMember(Value = "BEL")]
    [IsoId("_a36ixNp-Ed-ak6NoX_4Aeg_1357736122")]
    [Description(@"Scheme code for BE (Belgium) - Belgium RTGS (ELLIPS).")]
    Belgium = CashClearingSystemCode.Belgium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for FI (Finland) - RTGS (BOF).
    /// Encoded/decoded by serializers as &quot;BOF&quot;.
    /// </summary>
    [EnumMember(Value = "BOF")]
    [IsoId("_a36ixdp-Ed-ak6NoX_4Aeg_1357736190")]
    [Description(@"Scheme code for FI (Finland) - RTGS (BOF).")]
    Finland = CashClearingSystemCode.Finland, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for IT (Italy) - Italy RTGS (BIREL).
    /// Encoded/decoded by serializers as &quot;BRL&quot;.
    /// </summary>
    [EnumMember(Value = "BRL")]
    [IsoId("_a36ixtp-Ed-ak6NoX_4Aeg_1357736191")]
    [Description(@"Scheme code for IT (Italy) - Italy RTGS (BIREL).")]
    Italy = CashClearingSystemCode.Italy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).
    /// Encoded/decoded by serializers as &quot;CAD&quot;.
    /// </summary>
    [EnumMember(Value = "CAD")]
    [IsoId("_a36ix9p-Ed-ak6NoX_4Aeg_1357736192")]
    [Description(@"Scheme code for CA (Canada) - Canadian Large Value Transfer System (LVTS).")]
    Canada = CashClearingSystemCode.Canada, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for ES (Spain).
    /// Encoded/decoded by serializers as &quot;CAM&quot;.
    /// </summary>
    [EnumMember(Value = "CAM")]
    [IsoId("_a36iyNp-Ed-ak6NoX_4Aeg_1357736215")]
    [Description(@"Scheme code for ES (Spain).")]
    SpainCAM = CashClearingSystemCode.SpainCAM, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for IE (Ireland) - Irish RTGS (IRIS).
    /// Encoded/decoded by serializers as &quot;CBJ&quot;.
    /// </summary>
    [EnumMember(Value = "CBJ")]
    [IsoId("_a36iydp-Ed-ak6NoX_4Aeg_1357736232")]
    [Description(@"Scheme code for IE (Ireland) - Irish RTGS (IRIS).")]
    Ireland = CashClearingSystemCode.Ireland, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for GB (UK) - British Euro RTGS (CHAPS).
    /// Encoded/decoded by serializers as &quot;CHP&quot;.
    /// </summary>
    [EnumMember(Value = "CHP")]
    [IsoId("_a4ETwNp-Ed-ak6NoX_4Aeg_1357736558")]
    [Description(@"Scheme code for GB (UK) - British Euro RTGS (CHAPS).")]
    UnitedKingdom = CashClearingSystemCode.UnitedKingdom, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).
    /// Encoded/decoded by serializers as &quot;DKC&quot;.
    /// </summary>
    [EnumMember(Value = "DKC")]
    [IsoId("_a4ETwdp-Ed-ak6NoX_4Aeg_1357736559")]
    [Description(@"Scheme code for DK (Denmark) - Danish Euro RTGS (KRONOS).")]
    Denmark = CashClearingSystemCode.Denmark, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as &quot;RTP&quot;.
    /// </summary>
    [EnumMember(Value = "RTP")]
    [IsoId("_a4ETwtp-Ed-ak6NoX_4Aeg_1357736560")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyRTGSPlus = CashClearingSystemCode.GermanyRTGSPlus, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for EBA Euro1.
    /// Encoded/decoded by serializers as &quot;EBA&quot;.
    /// </summary>
    [EnumMember(Value = "EBA")]
    [IsoId("_a4ETw9p-Ed-ak6NoX_4Aeg_1357736593")]
    [Description(@"Scheme code for EBA Euro1.")]
    EBAEuro1 = CashClearingSystemCode.EBAEuro1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for DE (Germany).
    /// Encoded/decoded by serializers as &quot;ELS&quot;.
    /// </summary>
    [EnumMember(Value = "ELS")]
    [IsoId("_a4ETxNp-Ed-ak6NoX_4Aeg_1357736618")]
    [Description(@"Scheme code for DE (Germany).")]
    GermanyELS = CashClearingSystemCode.GermanyELS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for EBA step 1 (members).
    /// Encoded/decoded by serializers as &quot;ERP&quot;.
    /// </summary>
    [EnumMember(Value = "ERP")]
    [IsoId("_a4ETxdp-Ed-ak6NoX_4Aeg_1357736619")]
    [Description(@"Scheme code for EBA step 1 (members).")]
    EBAStep1 = CashClearingSystemCode.EBAStep1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for EBA step 2.
    /// Encoded/decoded by serializers as &quot;XCT&quot;.
    /// </summary>
    [EnumMember(Value = "XCT")]
    [IsoId("_a4ETxtp-Ed-ak6NoX_4Aeg_1357736620")]
    [Description(@"Scheme code for EBA step 2.")]
    EBAStep2 = CashClearingSystemCode.EBAStep2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for HR (Croatia) - HSVP.
    /// Encoded/decoded by serializers as &quot;HRK&quot;.
    /// </summary>
    [EnumMember(Value = "HRK")]
    [IsoId("_a4ETx9p-Ed-ak6NoX_4Aeg_1357736621")]
    [Description(@"Scheme code for HR (Croatia) - HSVP.")]
    Croatia = CashClearingSystemCode.Croatia, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for GR (Greece) - Greek RTGS (HERMES).
    /// Encoded/decoded by serializers as &quot;HRM&quot;.
    /// </summary>
    [EnumMember(Value = "HRM")]
    [IsoId("_a4ETyNp-Ed-ak6NoX_4Aeg_1357736622")]
    [Description(@"Scheme code for GR (Greece) - Greek RTGS (HERMES).")]
    Greece = CashClearingSystemCode.Greece, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for HU (Hungary) - VIBER.
    /// Encoded/decoded by serializers as &quot;HUF&quot;.
    /// </summary>
    [EnumMember(Value = "HUF")]
    [IsoId("_a4ETydp-Ed-ak6NoX_4Aeg_1357736623")]
    [Description(@"Scheme code for HU (Hungary) - VIBER.")]
    Hungary = CashClearingSystemCode.Hungary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).
    /// Encoded/decoded by serializers as &quot;LGS&quot;.
    /// </summary>
    [EnumMember(Value = "LGS")]
    [IsoId("_a4OEwNp-Ed-ak6NoX_4Aeg_1357736653")]
    [Description(@"Scheme code for LU (Luxemburg) - Luxembourg RTGS (LIPS).")]
    Luxemburg = CashClearingSystemCode.Luxemburg, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for LV (Latvia).
    /// Encoded/decoded by serializers as &quot;LVL&quot;.
    /// </summary>
    [EnumMember(Value = "LVL")]
    [IsoId("_a4OEwdp-Ed-ak6NoX_4Aeg_1357736654")]
    [Description(@"Scheme code for LV (Latvia).")]
    Latvia = CashClearingSystemCode.Latvia, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.
    /// Encoded/decoded by serializers as &quot;MOS&quot;.
    /// </summary>
    [EnumMember(Value = "MOS")]
    [IsoId("_a4OEwtp-Ed-ak6NoX_4Aeg_1357736655")]
    [Description(@"Scheme code for ZA (South Africa) - South-African Multiple Option Settlement.")]
    SouthAfrica = CashClearingSystemCode.SouthAfrica, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for MU (Mauritius).
    /// Encoded/decoded by serializers as &quot;MUP&quot;.
    /// </summary>
    [EnumMember(Value = "MUP")]
    [IsoId("_a4OEw9p-Ed-ak6NoX_4Aeg_1357736656")]
    [Description(@"Scheme code for MU (Mauritius).")]
    Mauritius = CashClearingSystemCode.Mauritius, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for NO (Norway).
    /// Encoded/decoded by serializers as &quot;NOC&quot;.
    /// </summary>
    [EnumMember(Value = "NOC")]
    [IsoId("_a4OExNp-Ed-ak6NoX_4Aeg_1357736670")]
    [Description(@"Scheme code for NO (Norway).")]
    Norway = CashClearingSystemCode.Norway, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for CH (Switzerland).
    /// Encoded/decoded by serializers as &quot;PCH&quot;.
    /// </summary>
    [EnumMember(Value = "PCH")]
    [IsoId("_a4OExdp-Ed-ak6NoX_4Aeg_1357736688")]
    [Description(@"Scheme code for CH (Switzerland).")]
    Switzerland = CashClearingSystemCode.Switzerland, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for AU (Australia).
    /// Encoded/decoded by serializers as &quot;PDS&quot;.
    /// </summary>
    [EnumMember(Value = "PDS")]
    [IsoId("_a4OExtp-Ed-ak6NoX_4Aeg_1357736696")]
    [Description(@"Scheme code for AU (Australia).")]
    Australia = CashClearingSystemCode.Australia, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for EG (Egypt).
    /// Encoded/decoded by serializers as &quot;PEG&quot;.
    /// </summary>
    [EnumMember(Value = "PEG")]
    [IsoId("_a4OEx9p-Ed-ak6NoX_4Aeg_1357736697")]
    [Description(@"Scheme code for EG (Egypt).")]
    Egypt = CashClearingSystemCode.Egypt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for FR (France).
    /// Encoded/decoded by serializers as &quot;PNS&quot;.
    /// </summary>
    [EnumMember(Value = "PNS")]
    [IsoId("_a4OEyNp-Ed-ak6NoX_4Aeg_1357736730")]
    [Description(@"Scheme code for FR (France).")]
    FrancePNS = CashClearingSystemCode.FrancePNS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for Ve (Venezuela).
    /// Encoded/decoded by serializers as &quot;PVE&quot;.
    /// </summary>
    [EnumMember(Value = "PVE")]
    [IsoId("_a4OEydp-Ed-ak6NoX_4Aeg_1357737120")]
    [Description(@"Scheme code for Ve (Venezuela).")]
    Venezuela = CashClearingSystemCode.Venezuela, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).
    /// Encoded/decoded by serializers as &quot;SEC&quot;.
    /// </summary>
    [EnumMember(Value = "SEC")]
    [IsoId("_a4XOsNp-Ed-ak6NoX_4Aeg_1357737121")]
    [Description(@"Scheme code for SE (Sweden) - Swedish Euro RTGS (SEC).")]
    SwedenSEC = CashClearingSystemCode.SwedenSEC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for SI (Slovenia).
    /// Encoded/decoded by serializers as &quot;SIT&quot;.
    /// </summary>
    [EnumMember(Value = "SIT")]
    [IsoId("_a4XOsdp-Ed-ak6NoX_4Aeg_1357737122")]
    [Description(@"Scheme code for SI (Slovenia).")]
    Slovania = CashClearingSystemCode.Slovania, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for ES (Spain) - Spanish RTGS (SLBE).
    /// Encoded/decoded by serializers as &quot;SLB&quot;.
    /// </summary>
    [EnumMember(Value = "SLB")]
    [IsoId("_a4XOstp-Ed-ak6NoX_4Aeg_1357737130")]
    [Description(@"Scheme code for ES (Spain) - Spanish RTGS (SLBE).")]
    SpainES = CashClearingSystemCode.SpainES, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).
    /// Encoded/decoded by serializers as &quot;SPG&quot;.
    /// </summary>
    [EnumMember(Value = "SPG")]
    [IsoId("_a4XOs9p-Ed-ak6NoX_4Aeg_1357737131")]
    [Description(@"Scheme code for PT (Portugal) - Portuguese RTGS (SPGT).")]
    Portugal = CashClearingSystemCode.Portugal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for SE (Sweden) - SEK RTGS (RIX).
    /// Encoded/decoded by serializers as &quot;SSK&quot;.
    /// </summary>
    [EnumMember(Value = "SSK")]
    [IsoId("_a4XOtNp-Ed-ak6NoX_4Aeg_1357737132")]
    [Description(@"Scheme code for SE (Sweden) - SEK RTGS (RIX).")]
    SwedenSSK = CashClearingSystemCode.SwedenSSK, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for FR (France) - French RTGS (TBF).
    /// Encoded/decoded by serializers as &quot;TBF&quot;.
    /// </summary>
    [EnumMember(Value = "TBF")]
    [IsoId("_a4XOtdp-Ed-ak6NoX_4Aeg_1357737133")]
    [Description(@"Scheme code for FR (France) - French RTGS (TBF).")]
    FranceFR = CashClearingSystemCode.FranceFR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for Target.
    /// Encoded/decoded by serializers as &quot;TGT&quot;.
    /// </summary>
    [EnumMember(Value = "TGT")]
    [IsoId("_a4XOttp-Ed-ak6NoX_4Aeg_1357737162")]
    [Description(@"Scheme code for Target.")]
    Target = CashClearingSystemCode.Target, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for NL (Netherlands) - Dutch RTGS (TOP).
    /// Encoded/decoded by serializers as &quot;TOP&quot;.
    /// </summary>
    [EnumMember(Value = "TOP")]
    [IsoId("_a4XOt9p-Ed-ak6NoX_4Aeg_1357737163")]
    [Description(@"Scheme code for NL (Netherlands) - Dutch RTGS (TOP).")]
    Netherlands = CashClearingSystemCode.Netherlands, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for the US national real time gross settlement system.
    /// Encoded/decoded by serializers as &quot;FDW&quot;.
    /// </summary>
    [EnumMember(Value = "FDW")]
    [IsoId("_a4XOuNp-Ed-ak6NoX_4Aeg_1357737180")]
    [Description(@"Scheme code for the US national real time gross settlement system.")]
    Fedwire = CashClearingSystemCode.Fedwire, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for the Bank of Japan clearing system.
    /// Encoded/decoded by serializers as &quot;BOJ&quot;.
    /// </summary>
    [EnumMember(Value = "BOJ")]
    [IsoId("_a4XOudp-Ed-ak6NoX_4Aeg_1357737181")]
    [Description(@"Scheme code for the Bank of Japan clearing system.")]
    BankOfJapanNet = CashClearingSystemCode.BankOfJapanNet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.
    /// Encoded/decoded by serializers as &quot;FEY&quot;.
    /// </summary>
    [EnumMember(Value = "FEY")]
    [IsoId("_a4XOutp-Ed-ak6NoX_4Aeg_1357737182")]
    [Description(@"Scheme code for the Foreign Exchange Yen Clearing system (FEYCS). It is the Japanese electronic interbank system for sending guaranteed and unconditional yen payments of FX deals for same day settlement from one settlement bank, on behalf of itself or its customers, to another settlement bank.")]
    ForeignExchangeYenClearing = CashClearingSystemCode.ForeignExchangeYenClearing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.
    /// Encoded/decoded by serializers as &quot;ZEN&quot;.
    /// </summary>
    [EnumMember(Value = "ZEN")]
    [IsoId("_a4g_sNp-Ed-ak6NoX_4Aeg_1357737183")]
    [Description(@"Scheme code for the Zengin system. The electronic payment system for domestic third party transfers managed by the Tokyo Bankers Association.")]
    Zengin = CashClearingSystemCode.Zengin, // same ordinal as derivation source for type conversions
    
}
