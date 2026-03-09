// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the reporting counterparty business activities. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WZwpASI5Ee2zWP9pqvmqdw")]
[Description(@"Specifies the nature of the reporting counterparty business activities. ")]
[DerivedFrom(typeof(FinancialPartySectorTypeCode))]
public enum FinancialPartySectorType3Code
{
    /// <summary>
    /// Alternative investment fund managed by an alternative investment fund manager (AIFM).
    /// Encoded/decoded by serializers as &quot;AIFD&quot;.
    /// </summary>
    [EnumMember(Value = "AIFD")]
    [IsoId("_WatrQSI5Ee2zWP9pqvmqdw")]
    [Description(@"Alternative investment fund managed by an alternative investment fund manager (AIFM).")]
    AlternativeInvestmentFund = FinancialPartySectorTypeCode.AlternativeInvestmentFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central securities depository.
    /// Encoded/decoded by serializers as &quot;CSDS&quot;.
    /// </summary>
    [EnumMember(Value = "CSDS")]
    [IsoId("_WatrQyI5Ee2zWP9pqvmqdw")]
    [Description(@"Central securities depository.")]
    CentralSecuritiesDepository = FinancialPartySectorTypeCode.CentralSecuritiesDepository, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Central counterparty.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_WatrRSI5Ee2zWP9pqvmqdw")]
    [Description(@"Central counterparty.")]
    CentralCounterparty = FinancialPartySectorTypeCode.CentralCounterparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.
    /// Encoded/decoded by serializers as &quot;CDTI&quot;.
    /// </summary>
    [EnumMember(Value = "CDTI")]
    [IsoId("_WatrRyI5Ee2zWP9pqvmqdw")]
    [Description(@"Credit institution that takes deposits or other repayable funds from the public and grants credits for its own account.|")]
    CreditInstitution = FinancialPartySectorTypeCode.CreditInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insurance undertaking.
    /// Encoded/decoded by serializers as &quot;INUN&quot;.
    /// </summary>
    [EnumMember(Value = "INUN")]
    [IsoId("_WatrSSI5Ee2zWP9pqvmqdw")]
    [Description(@"Insurance undertaking.")]
    InsuranceUndertaking = FinancialPartySectorTypeCode.InsuranceUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.
    /// Encoded/decoded by serializers as &quot;ORPI&quot;.
    /// </summary>
    [EnumMember(Value = "ORPI")]
    [IsoId("_WatrSyI5Ee2zWP9pqvmqdw")]
    [Description(@"Institution for occupational retirement provision established for the purpose of providing retirement benefits in the context of an occupational activity.")]
    OccupationalRetirementProvisionInstitution = FinancialPartySectorTypeCode.OccupationalRetirementProvisionInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Investment firm.
    /// Encoded/decoded by serializers as &quot;INVF&quot;.
    /// </summary>
    [EnumMember(Value = "INVF")]
    [IsoId("_WatrTSI5Ee2zWP9pqvmqdw")]
    [Description(@"Investment firm.|")]
    InvestmentFirm = FinancialPartySectorTypeCode.InvestmentFirm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.
    /// Encoded/decoded by serializers as &quot;REIN&quot;.
    /// </summary>
    [EnumMember(Value = "REIN")]
    [IsoId("_WatrTyI5Ee2zWP9pqvmqdw")]
    [Description(@"Reinsurance undertaking performing the activity of accepting risks ceded by an insurance undertaking or by another reinsurance undertaking.")]
    ReinsuranceUndertaking = FinancialPartySectorTypeCode.ReinsuranceUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Undertaking for collective investment in transferable securities (UCITS) and its management company.
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_WatrUSI5Ee2zWP9pqvmqdw")]
    [Description(@"Undertaking for collective investment in transferable securities (UCITS) and its management company.")]
    UCITSManagementCompany = FinancialPartySectorTypeCode.UCITSManagementCompany, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Assurance undertaking.
    /// Encoded/decoded by serializers as &quot;ASSU&quot;.
    /// </summary>
    [EnumMember(Value = "ASSU")]
    [IsoId("_XLlukSI5Ee2zWP9pqvmqdw")]
    [Description(@"Assurance undertaking.|")]
    AssuranceUndertaking = FinancialPartySectorTypeCode.AssuranceUndertaking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of financial institution.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_XS7ssSI5Ee2zWP9pqvmqdw")]
    [Description(@"Other type of financial institution.")]
    Other = FinancialPartySectorTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
