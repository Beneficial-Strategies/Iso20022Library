// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing system identification code, as published in an external clearing system identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amVqlNp-Ed-ak6NoX_4Aeg_319823369")]
[Description(
    @"Specifies the clearing system identification code, as published in an external clearing system identification code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalClearingSystemIdentificationCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalClearingSystemIdentification1Code>))]
public enum ExternalClearingSystemIdentification1Code
{
    /// <summary>
    /// Bank Branch code used in Austria
    /// Encoded/decoded by serializers as &quot;ATBLZ&quot;.
    /// </summary>
    [EnumMember(Value = "ATBLZ")]
    [IsoId("_tlQnxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Austria")]
    AustrianBankleitzahl = ExternalClearingSystemIdentificationCode.AustrianBankleitzahl, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Australia
    /// Encoded/decoded by serializers as &quot;AUBSB&quot;.
    /// </summary>
    [EnumMember(Value = "AUBSB")]
    [IsoId("_tlQnyPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Australia")]
    AustralianBankStateBranchCodeBSB =
        ExternalClearingSystemIdentificationCode.AustralianBankStateBranchCodeBSB, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Canada
    /// Encoded/decoded by serializers as &quot;CACPA&quot;.
    /// </summary>
    [EnumMember(Value = "CACPA")]
    [IsoId("_tlQny_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Canada")]
    CanadianPaymentsAssociationPaymentRoutingNumber =
        ExternalClearingSystemIdentificationCode.CanadianPaymentsAssociationPaymentRoutingNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Institution Identification (IID) used in Switzerland, without check digit
    /// Encoded/decoded by serializers as &quot;CHBCC&quot;.
    /// </summary>
    [EnumMember(Value = "CHBCC")]
    [IsoId("_tlQnzvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Financial Institution Identification (IID) used in Switzerland, without check digit"
    )]
    SwissFinancialInstitutionIdentificationShort =
        ExternalClearingSystemIdentificationCode.SwissFinancialInstitutionIdentificationShort, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial Institution Identification (IID) used in Switzerland, including check digit
    /// Encoded/decoded by serializers as &quot;CHSIC&quot;.
    /// </summary>
    [EnumMember(Value = "CHSIC")]
    [IsoId("_tlQn0fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Financial Institution Identification (IID) used in Switzerland, including check digit"
    )]
    SwissFinancialInstitutionIdentificationLong =
        ExternalClearingSystemIdentificationCode.SwissFinancialInstitutionIdentificationLong, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in China
    /// Encoded/decoded by serializers as &quot;CNAPS&quot;.
    /// </summary>
    [EnumMember(Value = "CNAPS")]
    [IsoId("_tlaYwvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in China")]
    CNAPSIdentifier = ExternalClearingSystemIdentificationCode.CNAPSIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Germany
    /// Encoded/decoded by serializers as &quot;DEBLZ&quot;.
    /// </summary>
    [EnumMember(Value = "DEBLZ")]
    [IsoId("_tlaYxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Germany")]
    GermanBankleitzahl = ExternalClearingSystemIdentificationCode.GermanBankleitzahl, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Spain
    /// Encoded/decoded by serializers as &quot;ESNCC&quot;.
    /// </summary>
    [EnumMember(Value = "ESNCC")]
    [IsoId("_tlaYyPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Spain")]
    SpanishDomesticInterbankingCode =
        ExternalClearingSystemIdentificationCode.SpanishDomesticInterbankingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in the UK
    /// Encoded/decoded by serializers as &quot;GBDSC&quot;.
    /// </summary>
    [EnumMember(Value = "GBDSC")]
    [IsoId("_tlaYy_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in the UK")]
    UKDomesticSortCode = ExternalClearingSystemIdentificationCode.UKDomesticSortCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Greece
    /// Encoded/decoded by serializers as &quot;GRBIC&quot;.
    /// </summary>
    [EnumMember(Value = "GRBIC")]
    [IsoId("_tlkJwvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Greece")]
    HelenicBankIdentificationCode =
        ExternalClearingSystemIdentificationCode.HelenicBankIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Hong Kong
    /// Encoded/decoded by serializers as &quot;HKNCC&quot;.
    /// </summary>
    [EnumMember(Value = "HKNCC")]
    [IsoId("_tlkJxfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Hong Kong")]
    HongKongBankCode = ExternalClearingSystemIdentificationCode.HongKongBankCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Ireland
    /// Encoded/decoded by serializers as &quot;IENCC&quot;.
    /// </summary>
    [EnumMember(Value = "IENCC")]
    [IsoId("_tlkJyPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Ireland")]
    IrishNationalClearingCode = ExternalClearingSystemIdentificationCode.IrishNationalClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in India
    /// Encoded/decoded by serializers as &quot;INFSC&quot;.
    /// </summary>
    [EnumMember(Value = "INFSC")]
    [IsoId("_tlkJy_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in India")]
    IndianFinancialSystemCode = ExternalClearingSystemIdentificationCode.IndianFinancialSystemCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Italy
    /// Encoded/decoded by serializers as &quot;ITNCC&quot;.
    /// </summary>
    [EnumMember(Value = "ITNCC")]
    [IsoId("_tlkJzvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Italy")]
    ItalianDomesticIdentificationCode =
        ExternalClearingSystemIdentificationCode.ItalianDomesticIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Japan
    /// Encoded/decoded by serializers as &quot;JPZGN&quot;.
    /// </summary>
    [EnumMember(Value = "JPZGN")]
    [IsoId("_tltTsvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Japan")]
    JapanZenginClearingCode = ExternalClearingSystemIdentificationCode.JapanZenginClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in New Zealand
    /// Encoded/decoded by serializers as &quot;NZNCC&quot;.
    /// </summary>
    [EnumMember(Value = "NZNCC")]
    [IsoId("_tltTtfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in New Zealand")]
    NewZealandNationalClearingCode =
        ExternalClearingSystemIdentificationCode.NewZealandNationalClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Poland
    /// Encoded/decoded by serializers as &quot;PLKNR&quot;.
    /// </summary>
    [EnumMember(Value = "PLKNR")]
    [IsoId("_tltTuPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Poland")]
    PolishNationalClearingCode =
        ExternalClearingSystemIdentificationCode.PolishNationalClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Portugal
    /// Encoded/decoded by serializers as &quot;PTNCC&quot;.
    /// </summary>
    [EnumMember(Value = "PTNCC")]
    [IsoId("_tltTu_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Portugal")]
    PortugueseNationalClearingCode =
        ExternalClearingSystemIdentificationCode.PortugueseNationalClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Russia
    /// Encoded/decoded by serializers as &quot;RUCBC&quot;.
    /// </summary>
    [EnumMember(Value = "RUCBC")]
    [IsoId("_tltTvvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Russia")]
    RussianCentralBankIdentificationCode =
        ExternalClearingSystemIdentificationCode.RussianCentralBankIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Sweden
    /// Encoded/decoded by serializers as &quot;SESBA&quot;.
    /// </summary>
    [EnumMember(Value = "SESBA")]
    [IsoId("_tl3EsvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Sweden")]
    SwedenBankgiroClearingCode =
        ExternalClearingSystemIdentificationCode.SwedenBankgiroClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Singapore
    /// Encoded/decoded by serializers as &quot;SGIBG&quot;.
    /// </summary>
    [EnumMember(Value = "SGIBG")]
    [IsoId("_tl3EtfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Singapore")]
    IBGSortCode = ExternalClearingSystemIdentificationCode.IBGSortCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Identification code used in Thailand
    /// Encoded/decoded by serializers as &quot;THCBC&quot;.
    /// </summary>
    [EnumMember(Value = "THCBC")]
    [IsoId("_tl3EuPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Identification code used in Thailand")]
    ThaiCentralBankIdentificationCode =
        ExternalClearingSystemIdentificationCode.ThaiCentralBankIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in Taiwan
    /// Encoded/decoded by serializers as &quot;TWNCC&quot;.
    /// </summary>
    [EnumMember(Value = "TWNCC")]
    [IsoId("_tl3Eu_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Taiwan")]
    FinancialInstitutionCode = ExternalClearingSystemIdentificationCode.FinancialInstitutionCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Routing Transit number assigned by the ABA for US financial institutons
    /// Encoded/decoded by serializers as &quot;USABA&quot;.
    /// </summary>
    [EnumMember(Value = "USABA")]
    [IsoId("_tl3EvvRYEeuLhpyIdtJzwg")]
    [Description(@"Routing Transit number assigned by the ABA for US financial institutons")]
    UnitedStatesRoutingNumberFedwireNACHA =
        ExternalClearingSystemIdentificationCode.UnitedStatesRoutingNumberFedwireNACHA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank identifier used by CHIPs in the US
    /// Encoded/decoded by serializers as &quot;USPID&quot;.
    /// </summary>
    [EnumMember(Value = "USPID")]
    [IsoId("_tmA1svRYEeuLhpyIdtJzwg")]
    [Description(@"Bank identifier used by CHIPs in the US")]
    CHIPSParticipantIdentifier =
        ExternalClearingSystemIdentificationCode.CHIPSParticipantIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Branch code used in South Africa
    /// Encoded/decoded by serializers as &quot;ZANCC&quot;.
    /// </summary>
    [EnumMember(Value = "ZANCC")]
    [IsoId("_tmA1tfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in South Africa")]
    SouthAfricanNationalClearingCode =
        ExternalClearingSystemIdentificationCode.SouthAfricanNationalClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RTGS settlement account used in New Zealand.
    /// Encoded/decoded by serializers as &quot;NZRSA&quot;.
    /// </summary>
    [EnumMember(Value = "NZRSA")]
    [IsoId("_c_XdsQTZEey95qpfbNuEwg")]
    [Description(@"RTGS settlement account used in New Zealand.")]
    NewZealandRTGSClearingCode =
        ExternalClearingSystemIdentificationCode.NewZealandRTGSClearingCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Banco de Mocambique RTGS system.
    /// Encoded/decoded by serializers as &quot;MZBMO&quot;.
    /// </summary>
    [EnumMember(Value = "MZBMO")]
    [IsoId("_v84qEmvcEe2F6NrIyOmXcA")]
    [Description(@"Banco de Mocambique RTGS system.")]
    BancoDeMocambiqueRTGS = ExternalClearingSystemIdentificationCode.BancoDeMocambiqueRTGS, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Chinese Cross-border Interbank Payment System (CIPS) Identifier.
    /// Encoded/decoded by serializers as &quot;CNCIP&quot;.
    /// </summary>
    [EnumMember(Value = "CNCIP")]
    [IsoId("_LNkXkmveEe2F6NrIyOmXcA")]
    [Description(@"Chinese Cross-border Interbank Payment System (CIPS) Identifier.")]
    CrossBorderInterbankPaymentSystem =
        ExternalClearingSystemIdentificationCode.CrossBorderInterbankPaymentSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participant Institution code used by BOK-Wire+ in South Korea.
    /// Encoded/decoded by serializers as &quot;KRBOK&quot;.
    /// </summary>
    [EnumMember(Value = "KRBOK")]
    [IsoId("_BwCmYv7MEe2ORYPQEd-Clg")]
    [Description(@"Participant Institution code used by BOK-Wire+ in South Korea.")]
    SouthKoreaCentralBankIdentificationCode =
        ExternalClearingSystemIdentificationCode.SouthKoreaCentralBankIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REPSS (regional cross-border payment and settlement platform designed to facilitate efficient and secure intra-regional trade payments within COMESA member states) settlement account.
    /// Encoded/decoded by serializers as &quot;CBHAC&quot;.
    /// </summary>
    [EnumMember(Value = "CBHAC")]
    [IsoId("_uApLwsntEfCY0M4eFzOwyQ")]
    [Description(@"REPSS (regional cross-border payment and settlement platform designed to facilitate efficient and secure intra-regional trade payments within COMESA member states) settlement account.")]
    COMESAREPSSAccountIdentificationCode = ExternalClearingSystemIdentificationCode.COMESAREPSSAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// REPSS (Regional cross-border payment and settlement platform designed to facilitate efficient and secure intra-regional trade payments within COMESA member states) participant identification code.
    /// Encoded/decoded by serializers as &quot;CBHPA&quot;.
    /// </summary>
    [EnumMember(Value = "CBHPA")]
    [IsoId("_afb18sntEfCY0M4eFzOwyQ")]
    [Description(@"REPSS (Regional cross-border payment and settlement platform designed to facilitate efficient and secure intra-regional trade payments within COMESA member states) participant identification code.")]
    COMESAREPSSParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.COMESAREPSSParticipantIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// COMESA SS settlement account.
    /// Encoded/decoded by serializers as &quot;CBPAC&quot;.
    /// </summary>
    [EnumMember(Value = "CBPAC")]
    [IsoId("_aTiSgcnuEfCY0M4eFzOwyQ")]
    [Description(@"COMESA SS settlement account.")]
    COMESASSAccountIdentificationCode = ExternalClearingSystemIdentificationCode.COMESASSAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// COMESA SS participant identification code.
    /// Encoded/decoded by serializers as &quot;CBPPA&quot;.
    /// </summary>
    [EnumMember(Value = "CBPPA")]
    [IsoId("_MLMe0snuEfCY0M4eFzOwyQ")]
    [Description(@"COMESA SS participant identification code.")]
    COMESASSParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.COMESASSParticipantIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Of Central African States (BEAC) Participant Account Identification Code – Financial Institution Identification used in BEAC's SYGMA system for settlement between participants accounts in Cameroon, Central Africa Republic, Chad, Equatorial Guinea, Gabon and Republic of the Congo. In this case, it is particular to the form of electronic payment of Real Time Gross Settlement.
    /// Encoded/decoded by serializers as &quot;CEAAC&quot;.
    /// </summary>
    [EnumMember(Value = "CEAAC")]
    [IsoId("_VYB-4YJ-EfCff8wf3dEAMw")]
    [Description(@"Bank Of Central African States (BEAC) Participant Account Identification Code – Financial Institution Identification used in BEAC's SYGMA system for settlement between participants accounts in Cameroon, Central Africa Republic, Chad, Equatorial Guinea, Gabon and Republic of the Congo. In this case, it is particular to the form of electronic payment of Real Time Gross Settlement.")]
    BankOfCentralAfricanStateParticipantAccountIdentificationCode = ExternalClearingSystemIdentificationCode.BankOfCentralAfricanStateParticipantAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Of Central African States (BEAC) Participant Identification Code – Financial Institution Identification used in BEAC's SYGMA system for settlement between participants in Cameroon, Central Africa Republic, Chad, Equatorial Guinea, Gabon and Republic of the Congo. In this case, it is particular to the form of electronic payment of Real Time Gross Settlement.
    /// Encoded/decoded by serializers as &quot;CEAPA&quot;.
    /// </summary>
    [EnumMember(Value = "CEAPA")]
    [IsoId("_Yt4V0YJ9EfCff8wf3dEAMw")]
    [Description(@"Bank Of Central African States (BEAC) Participant Identification Code – Financial Institution Identification used in BEAC's SYGMA system for settlement between participants in Cameroon, Central Africa Republic, Chad, Equatorial Guinea, Gabon and Republic of the Congo. In this case, it is particular to the form of electronic payment of Real Time Gross Settlement.")]
    BankOfCentralAfricanStateParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.BankOfCentralAfricanStateParticipantIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account identification code used in the RTGS system of Algeria.
    /// Encoded/decoded by serializers as &quot;DZRAC&quot;.
    /// </summary>
    [EnumMember(Value = "DZRAC")]
    [IsoId("_xyOxksnuEfCY0M4eFzOwyQ")]
    [Description(@"Account identification code used in the RTGS system of Algeria.")]
    AlgeriaAccountIdentificationCode = ExternalClearingSystemIdentificationCode.AlgeriaAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent identification code used in the RTGS system of Algeria.
    /// Encoded/decoded by serializers as &quot;DZRPA&quot;.
    /// </summary>
    [EnumMember(Value = "DZRPA")]
    [IsoId("_nhs88cnuEfCY0M4eFzOwyQ")]
    [Description(@"Agent identification code used in the RTGS system of Algeria.")]
    AlgeriaAgentIdentificationCode = ExternalClearingSystemIdentificationCode.AlgeriaAgentIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MACSS settlement account used in Mauritius.
    /// Encoded/decoded by serializers as &quot;MUPAC&quot;.
    /// </summary>
    [EnumMember(Value = "MUPAC")]
    [IsoId("_DP9eosntEfCY0M4eFzOwyQ")]
    [Description(@"MACSS settlement account used in Mauritius.")]
    MauritiusRTGSAccountIdentificationCode = ExternalClearingSystemIdentificationCode.MauritiusRTGSAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MACSS participant identification code used in Mauritus.
    /// Encoded/decoded by serializers as &quot;MUPPA&quot;.
    /// </summary>
    [EnumMember(Value = "MUPPA")]
    [IsoId("_01Ty8cnsEfCY0M4eFzOwyQ")]
    [Description(@"MACSS participant identification code used in Mauritus.")]
    MauritiusRTGSParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.MauritiusRTGSParticipantIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RTGS account identification code used in the Republic of Serbia.
    /// Encoded/decoded by serializers as &quot;RSDAC&quot;.
    /// </summary>
    [EnumMember(Value = "RSDAC")]
    [IsoId("_VIf70oKDEfCff8wf3dEAMw")]
    [Description(@"RTGS account identification code used in the Republic of Serbia.")]
    SerbiaRTGSAccountIdentificationCode = ExternalClearingSystemIdentificationCode.SerbiaRTGSAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RTGS participant identification code used in the Republic of Serbia.
    /// Encoded/decoded by serializers as &quot;RSDPA&quot;.
    /// </summary>
    [EnumMember(Value = "RSDPA")]
    [IsoId("_BaUhAoKDEfCff8wf3dEAMw")]
    [Description(@"RTGS participant identification code used in the Republic of Serbia.")]
    SerbiaRTGSParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.SerbiaRTGSParticipantIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interbank and International Clearing of FX Payments account identification code used in the Republic of Serbia.
    /// Encoded/decoded by serializers as &quot;RSEAC&quot;.
    /// </summary>
    [EnumMember(Value = "RSEAC")]
    [IsoId("_1Qnu0YKDEfCff8wf3dEAMw")]
    [Description(@"Interbank and International Clearing of FX Payments account identification code used in the Republic of Serbia.")]
    SerbiaNationalClearingAccountIdentificationCode = ExternalClearingSystemIdentificationCode.SerbiaNationalClearingAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interbank and International Clearing of FX Payments System participant identification code used in the Republic of Serbia.
    /// Encoded/decoded by serializers as &quot;RSEPA&quot;.
    /// </summary>
    [EnumMember(Value = "RSEPA")]
    [IsoId("_oMl30YKDEfCff8wf3dEAMw")]
    [Description(@"Interbank and International Clearing of FX Payments System participant identification code used in the Republic of Serbia.")]
    SerbiaNationalClearingParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.SerbiaNationalClearingParticipantIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    ///  RTGS account identification code used in the Republic of Uganda.
    /// Encoded/decoded by serializers as &quot;UGDAC&quot;.
    /// </summary>
    [EnumMember(Value = "UGDAC")]
    [IsoId("_iGT7MRDPEfGq-eDWPqCtlw")]
    [Description(@" RTGS account identification code used in the Republic of Uganda.")]
    UgandaRTGSAccountIdentificationCode = ExternalClearingSystemIdentificationCode.UgandaRTGSAccountIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RTGS participant identification code used in the Republic of Uganda.
    /// Encoded/decoded by serializers as &quot;UGDPA&quot;.
    /// </summary>
    [EnumMember(Value = "UGDPA")]
    [IsoId("_Ut0QERDPEfGq-eDWPqCtlw")]
    [Description(@"RTGS participant identification code used in the Republic of Uganda.")]
    UgandaRTGSParticipantIdentificationCode = ExternalClearingSystemIdentificationCode.UgandaRTGSParticipantIdentificationCode, // same ordinal as derivation source for type conversions
}
