// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// User interface used in case of chargebacks.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LHtH8FDhEee94_dUz-hvgw")]
[Description(@"User interface used in case of chargebacks.")]
[DerivedFrom(typeof(UserInterfaceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UserInterface8Code>))]
#endif
public enum UserInterface8Code
{
    /// <summary>
    /// Interface used in case of disputes or chargebacks.
    /// Encoded/decoded by serializers as &quot;DSPU&quot;.
    /// </summary>
    [EnumMember(Value = "DSPU")]
    [IsoId("_sHJJoX0mEemfrNOe0zHQyg")]
    [Description(@"Interface used in case of disputes or chargebacks.")]
    Dispute = UserInterfaceCode.Dispute, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File used to store the message.
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_sHJJo30mEemfrNOe0zHQyg")]
    [Description(@"File used to store the message.")]
    File = UserInterfaceCode.File, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information dedicated to a log file.
    /// Encoded/decoded by serializers as &quot;LOGF&quot;.
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_sHJJpX0mEemfrNOe0zHQyg")]
    [Description(@"Information dedicated to a log file.")]
    Log = UserInterfaceCode.Log, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of interface defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_sHJJp30mEemfrNOe0zHQyg")]
    [Description(@"Other type of interface defined at private level.")]
    OtherPrivate = UserInterfaceCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of interface defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_sHJJqX0mEemfrNOe0zHQyg")]
    [Description(@"Other type of interface defined at national level.")]
    OtherNational = UserInterfaceCode.OtherNational, // same ordinal as derivation source for type conversions
}
