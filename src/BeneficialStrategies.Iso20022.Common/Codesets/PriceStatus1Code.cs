// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the price of a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NtDrcOzYEeSBf_ghFpb9rQ")]
[Description(@"Specifies the status of the price of a financial instrument.")]
[DerivedFrom(typeof(PriceStatusCode))]
public enum PriceStatus1Code
{
    /// <summary>
    /// Price is pending.
    /// Encoded/decoded by serializers as &quot;PNDG&quot;.
    /// </summary>
    [EnumMember(Value = "PNDG")]
    [IsoId("_O0HaIezYEeSBf_ghFpb9rQ")]
    [Description(@"Price is pending.")]
    Pending = PriceStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No price for transaction (e.g. transfer between accounts).
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_Cc6kEI-TEeWtN7rsKJRs8Q")]
    [Description(@"No price for transaction (e.g. transfer between accounts).")]
    NotApplicable = PriceStatusCode.NotApplicable, // same ordinal as derivation source for type conversions
}
