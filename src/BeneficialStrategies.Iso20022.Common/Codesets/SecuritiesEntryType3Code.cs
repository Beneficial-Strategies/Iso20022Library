// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities entry on an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AJfyYDUFEe2tRf29bleifQ")]
[Description(@"Specifies the type of securities entry on an account.")]
[DerivedFrom(typeof(SecuritiesEntryTypeCode))]
public enum SecuritiesEntryType3Code
{
    /// <summary>
    /// Total number of securities eligible for this event.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_RmChwTUFEe2tRf29bleifQ")]
    [Description(@"Total number of securities eligible for this event.")]
    Eligible = SecuritiesEntryTypeCode.Eligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNBA&quot;.
    /// </summary>
    [EnumMember(Value = "UNBA")]
    [IsoId("_SBw0cTUFEe2tRf29bleifQ")]
    [Description(@"Balance of uninstructed position.")]
    UninstructedBalance = SecuritiesEntryTypeCode.UninstructedBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_SrfG4TUFEe2tRf29bleifQ")]
    [Description(@"Balance of instructed position.")]
    InstructedBalance = SecuritiesEntryTypeCode.InstructedBalance, // same ordinal as derivation source for type conversions
}
