// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the taxinomy type of a financial party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G3EfsBQXEeWSI-Fz8Zwg6g")]
[Description(@"Specifies the taxinomy type of a financial party.")]
[Derivations(
    typeof(FinancialPartySectorType1Code),
    typeof(FinancialPartySectorType2Code),
    typeof(FinancialPartySectorType3Code)
)]
public enum FinancialPartySectorTypeCode
{
    /// <summary>
    /// Assurance undertaking.
    /// Encoded/decoded by serializers as &quot;ASSU&quot;.
    /// </summary>
    [EnumMember(Value = "ASSU")]
    [IsoId("_QvpuYBQXEeWSI-Fz8Zwg6g")]
    [Description(@"Assurance undertaking.|")]
    AssuranceUndertaking,

    /// <summary>
    /// Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.
    /// Encoded/decoded by serializers as &quot;CDTI&quot;.
    /// </summary>
    [EnumMember(Value = "CDTI")]
    [IsoId("_SQvGoBQXEeWSI-Fz8Zwg6g")]
    [Description(
        @"Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.|"
    )]
    CreditInstitution,

    /// <summary>
    /// Investment firm.
    /// Encoded/decoded by serializers as &quot;INVF&quot;.
    /// </summary>
    [EnumMember(Value = "INVF")]
    [IsoId("_TimXIBQXEeWSI-Fz8Zwg6g")]
    [Description(@"Investment firm.|")]
    InvestmentFirm,

    /// <summary>
    /// Insurance undertaking.
    /// Encoded/decoded by serializers as &quot;INUN&quot;.
    /// </summary>
    [EnumMember(Value = "INUN")]
    [IsoId("_Utv7oBQXEeWSI-Fz8Zwg6g")]
    [Description(@"Insurance undertaking.")]
    InsuranceUndertaking,

    /// <summary>
    /// Alternative investment fund managed by an alternative investment fund manager (AIFM).
    /// Encoded/decoded by serializers as &quot;AIFD&quot;.
    /// </summary>
    [EnumMember(Value = "AIFD")]
    [IsoId("_WAPeQBQXEeWSI-Fz8Zwg6g")]
    [Description(
        @"Alternative investment fund managed by an alternative investment fund manager (AIFM)."
    )]
    AlternativeInvestmentFund,

    /// <summary>
    /// Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.
    /// Encoded/decoded by serializers as &quot;ORPI&quot;.
    /// </summary>
    [EnumMember(Value = "ORPI")]
    [IsoId("_XEhlwBQXEeWSI-Fz8Zwg6g")]
    [Description(
        @"Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity."
    )]
    OccupationalRetirementProvisionInstitution,

    /// <summary>
    /// Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_YiRWIBQXEeWSI-Fz8Zwg6g")]
    [Description(
        @"Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking."
    )]
    ReinsuranceUndertaking,

    /// <summary>
    /// Undertaking for collective investment in transferable securities (UCITS) and its management company.
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_Z4lo0BQXEeWSI-Fz8Zwg6g")]
    [Description(
        @"Undertaking for collective investment in transferable securities (UCITS) and its management company."
    )]
    UCITSManagementCompany,

    /// <summary>
    /// Other type of financial institution.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9zKLkAFdEeaDfK-zDSyB6A")]
    [Description(@"Other type of financial institution.")]
    Other,

    /// <summary>
    /// Central counterparty.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_zl8_YAb9EeamHPKpTHjX5Q")]
    [Description(@"Central counterparty.")]
    CentralCounterparty,

    /// <summary>
    /// Central securities depository.
    /// Encoded/decoded by serializers as &quot;CSDS&quot;.
    /// </summary>
    [EnumMember(Value = "CSDS")]
    [IsoId("_3QpIcAb9EeamHPKpTHjX5Q")]
    [Description(@"Central securities depository.")]
    CentralSecuritiesDepository,
}
