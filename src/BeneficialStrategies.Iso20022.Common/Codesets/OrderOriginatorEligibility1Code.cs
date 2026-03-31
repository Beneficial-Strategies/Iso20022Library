// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aRBh5Np-Ed-ak6NoX_4Aeg_182318737")]
[Description(
    @"Specifies the type of the counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties."
)]
[DerivedFrom(typeof(OrderOriginatorEligibilityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OrderOriginatorEligibility1Code>))]
#endif
public enum OrderOriginatorEligibility1Code
{
    /// <summary>
    /// Eligible counterparty - MiFID classification of counterparty. Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules defined under MiFID.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_aRLS4Np-Ed-ak6NoX_4Aeg_668089351")]
    [Description(
        @"Eligible counterparty - MiFID classification of counterparty. Eligible customers are the most sophisticated level of investor, able to opt out of some the protections afforded by conduct of business rules defined under MiFID."
    )]
    Eligible = OrderOriginatorEligibilityCode.Eligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Retail client - MiFID classification of counterparty. Retail customers are the least sophisticated level of investor.
    /// Encoded/decoded by serializers as &quot;RETL&quot;.
    /// </summary>
    [EnumMember(Value = "RETL")]
    [IsoId("_aRLS4dp-Ed-ak6NoX_4Aeg_679171670")]
    [Description(
        @"Retail client - MiFID classification of counterparty. Retail customers are the least sophisticated level of investor."
    )]
    Retail = OrderOriginatorEligibilityCode.Retail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Professional client - MiFID classification of counterparty. Professional customers are, for example, investment firms, credit institutions, insurance companies.
    /// Encoded/decoded by serializers as &quot;PROF&quot;.
    /// </summary>
    [EnumMember(Value = "PROF")]
    [IsoId("_aRLS4tp-Ed-ak6NoX_4Aeg_709649144")]
    [Description(
        @"Professional client - MiFID classification of counterparty. Professional customers are, for example, investment firms, credit institutions, insurance companies."
    )]
    Professional = OrderOriginatorEligibilityCode.Professional, // same ordinal as derivation source for type conversions
}
