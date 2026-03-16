// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing system identification code, as published in an external clearing system identification code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mjIcEIKWEeeCI5iKR7LsYQ")]
[Description(
    @"Specifies the clearing system identification code, as published in an external clearing system identification code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalClearingSystemIdentification1Code))]
public enum ExternalClearingSystemIdentificationCode
{
    /// <summary>
    /// Bank Branch code used in Austria
    /// Encoded/decoded by serializers as &quot;ATBLZ&quot;.
    /// </summary>
    [EnumMember(Value = "ATBLZ")]
    [IsoId("_tlQnw_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Austria")]
    AustrianBankleitzahl,

    /// <summary>
    /// Bank Branch code used in Australia
    /// Encoded/decoded by serializers as &quot;AUBSB&quot;.
    /// </summary>
    [EnumMember(Value = "AUBSB")]
    [IsoId("_tlQnxvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Australia")]
    AustralianBankStateBranchCodeBSB,

    /// <summary>
    /// Bank Branch code used in Canada
    /// Encoded/decoded by serializers as &quot;CACPA&quot;.
    /// </summary>
    [EnumMember(Value = "CACPA")]
    [IsoId("_tlQnyfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Canada")]
    CanadianPaymentsAssociationPaymentRoutingNumber,

    /// <summary>
    /// Financial Institution Identification (IID) used in Switzerland, without check digit
    /// Encoded/decoded by serializers as &quot;CHBCC&quot;.
    /// </summary>
    [EnumMember(Value = "CHBCC")]
    [IsoId("_tlQnzPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Financial Institution Identification (IID) used in Switzerland, without check digit"
    )]
    SwissFinancialInstitutionIdentificationShort,

    /// <summary>
    /// Financial Institution Identification (IID) used in Switzerland, including check digit
    /// Encoded/decoded by serializers as &quot;CHSIC&quot;.
    /// </summary>
    [EnumMember(Value = "CHSIC")]
    [IsoId("_tlQnz_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Financial Institution Identification (IID) used in Switzerland, including check digit"
    )]
    SwissFinancialInstitutionIdentificationLong,

    /// <summary>
    /// Bank Branch code used in China
    /// Encoded/decoded by serializers as &quot;CNAPS&quot;.
    /// </summary>
    [EnumMember(Value = "CNAPS")]
    [IsoId("_tlaYwPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in China")]
    CNAPSIdentifier,

    /// <summary>
    /// Bank Branch code used in Germany
    /// Encoded/decoded by serializers as &quot;DEBLZ&quot;.
    /// </summary>
    [EnumMember(Value = "DEBLZ")]
    [IsoId("_tlaYw_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Germany")]
    GermanBankleitzahl,

    /// <summary>
    /// Bank Branch code used in Spain
    /// Encoded/decoded by serializers as &quot;ESNCC&quot;.
    /// </summary>
    [EnumMember(Value = "ESNCC")]
    [IsoId("_tlaYxvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Spain")]
    SpanishDomesticInterbankingCode,

    /// <summary>
    /// Bank Branch code used in the UK
    /// Encoded/decoded by serializers as &quot;GBDSC&quot;.
    /// </summary>
    [EnumMember(Value = "GBDSC")]
    [IsoId("_tlaYyfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in the UK")]
    UKDomesticSortCode,

    /// <summary>
    /// Bank Branch code used in Greece
    /// Encoded/decoded by serializers as &quot;GRBIC&quot;.
    /// </summary>
    [EnumMember(Value = "GRBIC")]
    [IsoId("_tlkJwPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Greece")]
    HelenicBankIdentificationCode,

    /// <summary>
    /// Bank Branch code used in Hong Kong
    /// Encoded/decoded by serializers as &quot;HKNCC&quot;.
    /// </summary>
    [EnumMember(Value = "HKNCC")]
    [IsoId("_tlkJw_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Hong Kong")]
    HongKongBankCode,

    /// <summary>
    /// Bank Branch code used in Ireland
    /// Encoded/decoded by serializers as &quot;IENCC&quot;.
    /// </summary>
    [EnumMember(Value = "IENCC")]
    [IsoId("_tlkJxvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Ireland")]
    IrishNationalClearingCode,

    /// <summary>
    /// Bank Branch code used in India
    /// Encoded/decoded by serializers as &quot;INFSC&quot;.
    /// </summary>
    [EnumMember(Value = "INFSC")]
    [IsoId("_tlkJyfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in India")]
    IndianFinancialSystemCode,

    /// <summary>
    /// Bank Branch code used in Italy
    /// Encoded/decoded by serializers as &quot;ITNCC&quot;.
    /// </summary>
    [EnumMember(Value = "ITNCC")]
    [IsoId("_tlkJzPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Italy")]
    ItalianDomesticIdentificationCode,

    /// <summary>
    /// Bank Branch code used in Japan
    /// Encoded/decoded by serializers as &quot;JPZGN&quot;.
    /// </summary>
    [EnumMember(Value = "JPZGN")]
    [IsoId("_tltTsPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Japan")]
    JapanZenginClearingCode,

    /// <summary>
    /// Bank Branch code used in New Zealand
    /// Encoded/decoded by serializers as &quot;NZNCC&quot;.
    /// </summary>
    [EnumMember(Value = "NZNCC")]
    [IsoId("_tltTs_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in New Zealand")]
    NewZealandNationalClearingCode,

    /// <summary>
    /// Bank Branch code used in Poland
    /// Encoded/decoded by serializers as &quot;PLKNR&quot;.
    /// </summary>
    [EnumMember(Value = "PLKNR")]
    [IsoId("_tltTtvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Poland")]
    PolishNationalClearingCode,

    /// <summary>
    /// Bank Branch code used in Portugal
    /// Encoded/decoded by serializers as &quot;PTNCC&quot;.
    /// </summary>
    [EnumMember(Value = "PTNCC")]
    [IsoId("_tltTufRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Portugal")]
    PortugueseNationalClearingCode,

    /// <summary>
    /// Bank Branch code used in Russia
    /// Encoded/decoded by serializers as &quot;RUCBC&quot;.
    /// </summary>
    [EnumMember(Value = "RUCBC")]
    [IsoId("_tltTvPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Russia")]
    RussianCentralBankIdentificationCode,

    /// <summary>
    /// Bank Branch code used in Sweden
    /// Encoded/decoded by serializers as &quot;SESBA&quot;.
    /// </summary>
    [EnumMember(Value = "SESBA")]
    [IsoId("_tl3EsPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Sweden")]
    SwedenBankgiroClearingCode,

    /// <summary>
    /// Bank Branch code used in Singapore
    /// Encoded/decoded by serializers as &quot;SGIBG&quot;.
    /// </summary>
    [EnumMember(Value = "SGIBG")]
    [IsoId("_tl3Es_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Singapore")]
    IBGSortCode,

    /// <summary>
    /// Bank Identification code used in Thailand
    /// Encoded/decoded by serializers as &quot;THCBC&quot;.
    /// </summary>
    [EnumMember(Value = "THCBC")]
    [IsoId("_tl3EtvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Identification code used in Thailand")]
    ThaiCentralBankIdentificationCode,

    /// <summary>
    /// Bank Branch code used in Taiwan
    /// Encoded/decoded by serializers as &quot;TWNCC&quot;.
    /// </summary>
    [EnumMember(Value = "TWNCC")]
    [IsoId("_tl3EufRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in Taiwan")]
    FinancialInstitutionCode,

    /// <summary>
    /// Routing Transit number assigned by the ABA for US financial institutons
    /// Encoded/decoded by serializers as &quot;USABA&quot;.
    /// </summary>
    [EnumMember(Value = "USABA")]
    [IsoId("_tl3EvPRYEeuLhpyIdtJzwg")]
    [Description(@"Routing Transit number assigned by the ABA for US financial institutons")]
    UnitedStatesRoutingNumberFedwireNACHA,

    /// <summary>
    /// Bank identifier used by CHIPs in the US
    /// Encoded/decoded by serializers as &quot;USPID&quot;.
    /// </summary>
    [EnumMember(Value = "USPID")]
    [IsoId("_tmA1sPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank identifier used by CHIPs in the US")]
    CHIPSParticipantIdentifier,

    /// <summary>
    /// Bank Branch code used in South Africa
    /// Encoded/decoded by serializers as &quot;ZANCC&quot;.
    /// </summary>
    [EnumMember(Value = "ZANCC")]
    [IsoId("_tmA1s_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Branch code used in South Africa")]
    SouthAfricanNationalClearingCode,

    /// <summary>
    /// RTGS settlement account used in New Zealand.
    /// Encoded/decoded by serializers as &quot;NZRSA&quot;.
    /// </summary>
    [EnumMember(Value = "NZRSA")]
    [IsoId("_Mv3JMATZEey95qpfbNuEwg")]
    [Description(@"RTGS settlement account used in New Zealand.")]
    NewZealandRTGSClearingCode,

    /// <summary>
    /// Banco de Mocambique RTGS system.
    /// Encoded/decoded by serializers as &quot;MZBMO&quot;.
    /// </summary>
    [EnumMember(Value = "MZBMO")]
    [IsoId("_v84qEGvcEe2F6NrIyOmXcA")]
    [Description(@"Banco de Mocambique RTGS system.")]
    BancoDeMocambiqueRTGS,

    /// <summary>
    /// Chinese Cross-border Interbank Payment System (CIPS) Identifier.
    /// Encoded/decoded by serializers as &quot;CNCIP&quot;.
    /// </summary>
    [EnumMember(Value = "CNCIP")]
    [IsoId("_LNkXkGveEe2F6NrIyOmXcA")]
    [Description(@"Chinese Cross-border Interbank Payment System (CIPS) Identifier.")]
    CrossBorderInterbankPaymentSystem,

    /// <summary>
    /// Participant Institution code used by BOK-Wire+ in South Korea.
    /// Encoded/decoded by serializers as &quot;KRBOK&quot;.
    /// </summary>
    [EnumMember(Value = "KRBOK")]
    [IsoId("_BwCmYP7MEe2ORYPQEd-Clg")]
    [Description(@"Participant Institution code used by BOK-Wire+ in South Korea.")]
    SouthKoreaCentralBankIdentificationCode,
}
