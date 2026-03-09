// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that there is no reason available.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNmad9p-Ed-ak6NoX_4Aeg_1937897714")]
[Description(@"Specifies that there is no reason available.")]
[DerivedFrom(typeof(SpecialPurposeCode))]
public enum NoReasonCode
{
    /// <summary>
    /// No reason to report or no reason available to report.
    /// Encoded/decoded by serializers as &quot;NORE&quot;.
    /// </summary>
    [EnumMember(Value = "NORE")]
    [IsoId("_aNmaeNp-Ed-ak6NoX_4Aeg_1957291337")]
    [Description(@"No reason to report or no reason available to report.")]
    NoReason = SpecialPurposeCode.NoReason, // same ordinal as derivation source for type conversions
    
}
