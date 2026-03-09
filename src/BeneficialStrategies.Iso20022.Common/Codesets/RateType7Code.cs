// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZZmKpNp-Ed-ak6NoX_4Aeg_-218272633")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(InterestRateTypeCode))]
public enum RateType7Code
{
    /// <summary>
    /// Rate of the scheduled payment.
    /// Encoded/decoded by serializers as &quot;SCHD&quot;.
    /// </summary>
    [EnumMember(Value = "SCHD")]
    [IsoId("_ZZmKpdp-Ed-ak6NoX_4Aeg_-218272353")]
    [Description(@"Rate of the scheduled payment.")]
    Scheduled = InterestRateTypeCode.Scheduled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rate of the unscheduled payment.
    /// Encoded/decoded by serializers as &quot;USCD&quot;.
    /// </summary>
    [EnumMember(Value = "USCD")]
    [IsoId("_ZZmKptp-Ed-ak6NoX_4Aeg_-218272323")]
    [Description(@"Rate of the unscheduled payment.")]
    Unscheduled = InterestRateTypeCode.Unscheduled, // same ordinal as derivation source for type conversions
    
}
