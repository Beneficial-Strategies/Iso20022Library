// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Rule to apply for the presence of a message item.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_axD3cXC8Ee2bmOA3bkVsMg")]
[Description(@"Rule to apply for the presence of a message item.")]
[DerivedFrom(typeof(MessageItemConditionCode))]
public enum MessageItemCondition2Code
{
    /// <summary>
    /// Message item must be present.
    /// Encoded/decoded by serializers as &quot;MNDT&quot;.
    /// </summary>
    [EnumMember(Value = "MNDT")]
    [IsoId("_a4Tu8XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item must be present.")]
    Mandatory = MessageItemConditionCode.Mandatory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item must be present with the configured value.
    /// Encoded/decoded by serializers as &quot;CFVL&quot;.
    /// </summary>
    [EnumMember(Value = "CFVL")]
    [IsoId("_a4Tu83C8Ee2bmOA3bkVsMg")]
    [Description(@"Message item must be present with the configured value.")]
    ConfiguredValue = MessageItemConditionCode.ConfiguredValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item has the configured value if the item is absent.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_a4Tu9XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item has the configured value if the item is absent.")]
    DefaultValue = MessageItemConditionCode.DefaultValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item must have one of the configured values.
    /// Encoded/decoded by serializers as &quot;ALWV&quot;.
    /// </summary>
    [EnumMember(Value = "ALWV")]
    [IsoId("_a4Tu93C8Ee2bmOA3bkVsMg")]
    [Description(@"Message item must have one of the configured values.")]
    AllowedValues = MessageItemConditionCode.AllowedValues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item has to be present if available.
    /// Encoded/decoded by serializers as &quot;IFAV&quot;.
    /// </summary>
    [EnumMember(Value = "IFAV")]
    [IsoId("_a4Tu-XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item has to be present if available.")]
    IfAvailable = MessageItemConditionCode.IfAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item is present if it was present in a previous related message with the same value.
    /// Encoded/decoded by serializers as &quot;COPY&quot;.
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_a4Tu-3C8Ee2bmOA3bkVsMg")]
    [Description(
        @"Message item is present if it was present in a previous related message with the same value."
    )]
    Copy = MessageItemConditionCode.Copy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item is not supported and has to be absent.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_a4Tu_XC8Ee2bmOA3bkVsMg")]
    [Description(@"Message item is not supported and has to be absent.")]
    NotSupported = MessageItemConditionCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minimum set of values to use in messages.
    /// Encoded/decoded by serializers as &quot;LMNV&quot;.
    /// </summary>
    [EnumMember(Value = "LMNV")]
    [IsoId("_ediJMXC8Ee2bmOA3bkVsMg")]
    [Description(@"Minimum set of values to use in messages.")]
    ListMinimumValues = MessageItemConditionCode.ListMinimumValues, // same ordinal as derivation source for type conversions
}
