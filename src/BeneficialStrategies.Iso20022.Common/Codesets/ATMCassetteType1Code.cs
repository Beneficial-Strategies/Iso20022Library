// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cassette.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sGm7sIqfEeS4a4abTJTSSw")]
[Description(@"Type of cassette.")]
[DerivedFrom(typeof(ATMCassetteTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMCassetteType1Code>))]
#endif
public enum ATMCassetteType1Code
{
    /// <summary>
    /// Cassette for deposits.
    /// Encoded/decoded by serializers as &quot;DPST&quot;.
    /// </summary>
    [EnumMember(Value = "DPST")]
    [IsoId("_783pwYqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for deposits.")]
    In = ATMCassetteTypeCode.In, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cassette for dispense.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_8CFg8YqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for dispense.")]
    Out = ATMCassetteTypeCode.Out, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cassette for recycling.
    /// Encoded/decoded by serializers as &quot;RCYC&quot;.
    /// </summary>
    [EnumMember(Value = "RCYC")]
    [IsoId("_8HvdAYqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for recycling.")]
    Recycling = ATMCassetteTypeCode.Recycling, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cassette for reject.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_8NQ2MYqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for reject.")]
    Reject = ATMCassetteTypeCode.Reject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cassette for replenishment.
    /// Encoded/decoded by serializers as &quot;RPLT&quot;.
    /// </summary>
    [EnumMember(Value = "RPLT")]
    [IsoId("_8Sn3UYqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for replenishment.")]
    Replenishment = ATMCassetteTypeCode.Replenishment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cassette for retract.
    /// Encoded/decoded by serializers as &quot;RTRC&quot;.
    /// </summary>
    [EnumMember(Value = "RTRC")]
    [IsoId("_8X_fgYqfEeS4a4abTJTSSw")]
    [Description(@"Cassette for retract.")]
    Retract = ATMCassetteTypeCode.Retract, // same ordinal as derivation source for type conversions
}
