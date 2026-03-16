// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of investor. The rules that apply to each type of client are different.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahHzZNp-Ed-ak6NoX_4Aeg_-1375297258")]
[Description(
    @"Identifies the type of investor. The rules that apply to each type of client are different."
)]
[DerivedFrom(typeof(EligibilityCode))]
public enum Eligibility1Code
{
    /// <summary>
    /// Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ahHzZdp-Ed-ak6NoX_4Aeg_-1307879388")]
    [Description(
        @"Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules."
    )]
    EligibleCounterparty = EligibilityCode.EligibleCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retail customers are the least sophisticated level of investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_ahHzZtp-Ed-ak6NoX_4Aeg_-1307879371")]
    [Description(@"Retail customers are the least sophisticated level of investor.")]
    RetailClient = EligibilityCode.RetailClient, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Professional customers are, for example, investment firms, credit institutions, insurance companies.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_ahHzZ9p-Ed-ak6NoX_4Aeg_-1307879327")]
    [Description(
        @"Professional customers are, for example, investment firms, credit institutions, insurance companies."
    )]
    ProfessionalClient = EligibilityCode.ProfessionalClient, // same ordinal as derivation source for type conversions
}
