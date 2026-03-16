// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qC1AgJm_Eeao_Z127E9uYg")]
[Description(
    @"Specifies the external mandate status code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalMandateStatusCode))]
public enum ExternalMandateStatus1Code
{
    /// <summary>
    /// The mandate is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_uYrBtfRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is active.")]
    Active = ExternalMandateStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The mandate is cancelled.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_uYrBuPRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is cancelled.")]
    Cancelled = ExternalMandateStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The mandate has passed the end date.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_uYrBu_RYEeuLhpyIdtJzwg")]
    [Description(@"The mandate has passed the end date.")]
    Expired = ExternalMandateStatusCode.Expired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The mandate is put on hold.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_uY0ysvRYEeuLhpyIdtJzwg")]
    [Description(@"The mandate is put on hold.")]
    Suspended = ExternalMandateStatusCode.Suspended, // same ordinal as derivation source for type conversions
}
