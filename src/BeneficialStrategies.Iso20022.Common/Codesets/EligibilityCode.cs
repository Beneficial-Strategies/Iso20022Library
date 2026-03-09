// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of investor. The rules that apply to each type of client are different.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ahQ9UNp-Ed-ak6NoX_4Aeg_2052483881")]
[Description(@"Identifies the type of investor. The rules that apply to each type of client are different.")]
[Derivations(typeof(Eligibility1Code))]
public enum EligibilityCode
{
    /// <summary>
    /// Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ahQ9Udp-Ed-ak6NoX_4Aeg_-1964501346")]
    [Description(@"Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules.")]
    EligibleCounterparty,
    
    /// <summary>
    /// Retail customers are the least sophisticated level of investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_ahQ9Utp-Ed-ak6NoX_4Aeg_-1568310716")]
    [Description(@"Retail customers are the least sophisticated level of investor.")]
    RetailClient,
    
    /// <summary>
    /// Professional customers are, for example, investment firms, credit institutions, insurance companies.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_ahQ9U9p-Ed-ak6NoX_4Aeg_-1480577305")]
    [Description(@"Professional customers are, for example, investment firms, credit institutions, insurance companies.")]
    ProfessionalClient,
    
}
