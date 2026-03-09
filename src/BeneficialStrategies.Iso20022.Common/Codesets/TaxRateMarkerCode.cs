// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rate of tax levied.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwYvUQ2XEeStB9HSJRk0Qw")]
[Description(@"Specifies the rate of tax levied.")]
[Derivations(typeof(TaxRateMarker1Code))]
public enum TaxRateMarkerCode
{
    /// <summary>
    /// Specifies an amount before the deduction of tax.
    /// Encoded/decoded by serializers as &quot;GRSS&quot;.
    /// </summary>
    [EnumMember(Value = "GRSS")]
    [IsoId("_bBcL8A2XEeStB9HSJRk0Qw")]
    [Description(@"Specifies an amount before the deduction of tax.")]
    GrossAmount,
    
    /// <summary>
    /// Specifies the amount quoted less standard rate income tax.
    /// Encoded/decoded by serializers as &quot;ALIT&quot;.
    /// </summary>
    [EnumMember(Value = "ALIT")]
    [IsoId("_c7SpgA2XEeStB9HSJRk0Qw")]
    [Description(@"Specifies the amount quoted less standard rate income tax.")]
    AmountQuotedLessStandardRate,
    
    /// <summary>
    /// Specifies the amount quoted less life assurance premium rate income tax.
    /// Encoded/decoded by serializers as &quot;ALPR&quot;.
    /// </summary>
    [EnumMember(Value = "ALPR")]
    [IsoId("_exjnkA2XEeStB9HSJRk0Qw")]
    [Description(@"Specifies the amount quoted less life assurance premium rate income tax.")]
    AmountQuotedLessLifeAssurance,
    
}
