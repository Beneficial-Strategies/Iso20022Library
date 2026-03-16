// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of action concerning registration information.
/// The default value is OPEN.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OTgzMjc5-AOSNFX-8224496")]
[Description(
    @"Specifies the type of action concerning registration information.|The default value is OPEN."
)]
[DerivedFrom(typeof(AgreementItemActionCode))]
public enum AgreementItemAction1Code
{
    /// <summary>
    /// Deactivate agreement item.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_OTMxOTY3-AOSNFX-0262741")]
    [Description(@"Deactivate agreement item.")]
    Deactivate = AgreementItemActionCode.Deactivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hold the agreement item.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_OTMxOTY2-AOSNFX-0262741")]
    [Description(@"Hold the agreement item.")]
    Hold = AgreementItemActionCode.Hold, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modify agreement item information.
    /// Encoded/decoded by serializers as &quot;MDFY&quot;.
    /// </summary>
    [EnumMember(Value = "MDFY")]
    [IsoId("_OTMxOTY1-AOSNFX-0262740")]
    [Description(@"Modify agreement item information.")]
    Modify = AgreementItemActionCode.Modify, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reactivate agreement item.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_OTMxOTY4-AOSNFX-0262741")]
    [Description(@"Reactivate agreement item.")]
    Reactivate = AgreementItemActionCode.Reactivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Register item as new agreement.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_OTMxOTY0-AOSNFX-0262740")]
    [Description(@"Register item as new agreement.")]
    Register = AgreementItemActionCode.Register, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Send status with full agreement information details.
    /// Encoded/decoded by serializers as &quot;SYNC&quot;.
    /// </summary>
    [EnumMember(Value = "SYNC")]
    [IsoId("_OTMxOTcw-AOSNFX-0262741")]
    [Description(@"Send status with full agreement information details.")]
    Synchronize = AgreementItemActionCode.Synchronize, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verify agreement item information.
    /// Encoded/decoded by serializers as &quot;VRFY&quot;.
    /// </summary>
    [EnumMember(Value = "VRFY")]
    [IsoId("_OTMxOTY5-AOSNFX-0262741")]
    [Description(@"Verify agreement item information.")]
    Verify = AgreementItemActionCode.Verify, // same ordinal as derivation source for type conversions
}
