// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Rule to apply for the presence of a message item.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KS410H1DEeCF8NjrBemJWQ_1422822358")]
[Description(@"Rule to apply for the presence of a message item.")]
[DerivedFrom(typeof(MessageItemConditionCode))]
public enum MessageItemCondition1Code
{
    /// <summary>
    /// Message item must be present.
    /// Encoded/decoded by serializers as &quot;MNDT&quot;.
    /// </summary>
    [EnumMember(Value = "MNDT")]
    [IsoId("_KS410X1DEeCF8NjrBemJWQ_-1674698087")]
    [Description(@"Message item must be present.")]
    Mandatory = MessageItemConditionCode.Mandatory, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item must be present with the configured value.
    /// Encoded/decoded by serializers as &quot;CFVL&quot;.
    /// </summary>
    [EnumMember(Value = "CFVL")]
    [IsoId("_KS410n1DEeCF8NjrBemJWQ_-1280588997")]
    [Description(@"Message item must be present with the configured value.")]
    ConfiguredValue = MessageItemConditionCode.ConfiguredValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item has the configured value if the item is absent.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_KS41031DEeCF8NjrBemJWQ_-510773471")]
    [Description(@"Message item has the configured value if the item is absent.")]
    DefaultValue = MessageItemConditionCode.DefaultValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item must have one of the configured values.
    /// Encoded/decoded by serializers as &quot;ALWV&quot;.
    /// </summary>
    [EnumMember(Value = "ALWV")]
    [IsoId("_KS411H1DEeCF8NjrBemJWQ_1799018238")]
    [Description(@"Message item must have one of the configured values.")]
    AllowedValues = MessageItemConditionCode.AllowedValues, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item has to be present if available.
    /// Encoded/decoded by serializers as &quot;IFAV&quot;.
    /// </summary>
    [EnumMember(Value = "IFAV")]
    [IsoId("_KS411X1DEeCF8NjrBemJWQ_-1781360870")]
    [Description(@"Message item has to be present if available.")]
    IfAvailable = MessageItemConditionCode.IfAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item is present if it was present in a previous related message with the same value.
    /// Encoded/decoded by serializers as &quot;COPY&quot;.
    /// </summary>
    [EnumMember(Value = "COPY")]
    [IsoId("_KS411n1DEeCF8NjrBemJWQ_-1229199954")]
    [Description(
        @"Message item is present if it was present in a previous related message with the same value."
    )]
    Copy = MessageItemConditionCode.Copy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message item is not supported and has to be absent.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_KS41131DEeCF8NjrBemJWQ_1780165628")]
    [Description(@"Message item is not supported and has to be absent.")]
    NotSupported = MessageItemConditionCode.NotSupported, // same ordinal as derivation source for type conversions
}
