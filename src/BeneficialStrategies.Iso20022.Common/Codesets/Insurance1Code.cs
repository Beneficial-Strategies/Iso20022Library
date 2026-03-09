// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of insurance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BURwYBQbEeKebsB9eKJSkA")]
[Description(@"Specifies the type of insurance.")]
[DerivedFrom(typeof(InsuranceCode))]
public enum Insurance1Code
{
    /// <summary>
    /// Life insurance.
    /// Encoded/decoded by serializers as &quot;LIFE&quot;.
    /// </summary>
    [EnumMember(Value = "LIFE")]
    [IsoId("_OdMHYRQbEeKebsB9eKJSkA")]
    [Description(@"Life insurance.")]
    LifeInsurance = InsuranceCode.LifeInsurance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Permanent disability insurance.
    /// Encoded/decoded by serializers as &quot;PDIS&quot;.
    /// </summary>
    [EnumMember(Value = "PDIS")]
    [IsoId("_Ombi8RQbEeKebsB9eKJSkA")]
    [Description(@"Permanent disability insurance.")]
    PermanentDisabilityInsurance = InsuranceCode.PermanentDisabilityInsurance, // same ordinal as derivation source for type conversions
    
}
