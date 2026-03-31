// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of service selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dWX-kYrAEeSgLpgNvMAP2g")]
[Description(@"Describes the type of service selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMServiceType5Code>))]
#endif
public enum ATMServiceType5Code
{
    /// <summary>
    /// Modification of the card PIN value.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_djyvg4rAEeSgLpgNvMAP2g")]
    [Description(@"Modification of the card PIN value.")]
    PINChange = ATMServiceTypeCode.PINChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resetting of a PIN.
    /// Encoded/decoded by serializers as &quot;PINR&quot;.
    /// </summary>
    [EnumMember(Value = "PINR")]
    [IsoId("_djyvhYrAEeSgLpgNvMAP2g")]
    [Description(@"Resetting of a PIN.")]
    PINRecovery = ATMServiceTypeCode.PINRecovery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unblock the PIN.
    /// Encoded/decoded by serializers as &quot;PINU&quot;.
    /// </summary>
    [EnumMember(Value = "PINU")]
    [IsoId("_djyvh4rAEeSgLpgNvMAP2g")]
    [Description(@"Unblock the PIN.")]
    PINUnblock = ATMServiceTypeCode.PINUnblock, // same ordinal as derivation source for type conversions
}
