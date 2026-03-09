// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MOeEW7iEeKo25nLKvGr8w_1230837438")]
[Description(@"Specifies the external date frequency code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDateFrequencyCode))]
public enum ExternalDateFrequency1Code
{
    /// <summary>
    /// Frequency is monthly.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_uO_hRfRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is monthly.")]
    Monthly = ExternalDateFrequencyCode.Monthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is quarterly (every three months).
    /// Encoded/decoded by serializers as &quot;QUTR&quot;.
    /// </summary>
    [EnumMember(Value = "QUTR")]
    [IsoId("_uO_hSPRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is quarterly (every three months).")]
    Quarterly = ExternalDateFrequencyCode.Quarterly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is semi-annual (every six months).
    /// Encoded/decoded by serializers as &quot;SEMI&quot;.
    /// </summary>
    [EnumMember(Value = "SEMI")]
    [IsoId("_uO_hS_RYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is semi-annual (every six months).")]
    SemiAnnual = ExternalDateFrequencyCode.SemiAnnual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is two-monthly (every two months).
    /// Encoded/decoded by serializers as &quot;TOMN&quot;.
    /// </summary>
    [EnumMember(Value = "TOMN")]
    [IsoId("_uO_hTvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is two-monthly (every two months).")]
    TwoMonthly = ExternalDateFrequencyCode.TwoMonthly, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Frequency is annual.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_uPIrMvRYEeuLhpyIdtJzwg")]
    [Description(@"Frequency is annual.")]
    Annual = ExternalDateFrequencyCode.Annual, // same ordinal as derivation source for type conversions
    
}
