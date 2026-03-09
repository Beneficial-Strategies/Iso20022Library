// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRLS49p-Ed-ak6NoX_4Aeg_-105822202")]
[Description(@"Specifies the type of the counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.")]
[Derivations(typeof(OrderOriginatorEligibility1Code))]
public enum OrderOriginatorEligibilityCode
{
    /// <summary>
    /// Eligible counterparty - MiFID classification of counterparty. Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules defined under MiFID.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_aRLS5Np-Ed-ak6NoX_4Aeg_1243444376")]
    [Description(@"Eligible counterparty - MiFID classification of counterparty. Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules defined under MiFID.")]
    Eligible,
    
    /// <summary>
    /// Retail client - MiFID classification of counterparty. Retail customers are the least sophisticated level of investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_aRLS5dp-Ed-ak6NoX_4Aeg_1243444642")]
    [Description(@"Retail client - MiFID classification of counterparty. Retail customers are the least sophisticated level of investor.")]
    Retail,
    
    /// <summary>
    /// Professional client - MiFID classification of counterparty. Professional customers are, for example, investment firms, credit institutions, insurance companies.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_aRLS5tp-Ed-ak6NoX_4Aeg_1243444659")]
    [Description(@"Professional client - MiFID classification of counterparty. Professional customers are, for example, investment firms, credit institutions, insurance companies.")]
    Professional,
    
}
