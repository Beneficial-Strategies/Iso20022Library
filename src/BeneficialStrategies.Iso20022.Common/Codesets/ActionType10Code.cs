// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of additional action to be performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FgF8gE0uEeea0Mdu1TOzDQ")]
[Description(@"Type of additional action to be performed.")]
[DerivedFrom(typeof(ActionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ActionType10Code>))]
#endif
public enum ActionType10Code
{
    /// <summary>
    /// Activate device or service.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_MS5GAU0uEeea0Mdu1TOzDQ")]
    [Description(@"Activate device or service.")]
    Activate = ActionTypeCode.Activate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deactivate device or service.
    /// Encoded/decoded by serializers as &quot;DEAC&quot;.
    /// </summary>
    [EnumMember(Value = "DEAC")]
    [IsoId("_NWZxck0uEeea0Mdu1TOzDQ")]
    [Description(@"Deactivate device or service.")]
    Deactivate = ActionTypeCode.Deactivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message to display, print or log.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_OQieck0uEeea0Mdu1TOzDQ")]
    [Description(@"Message to display, print or log.")]
    DisplayMessage = ActionTypeCode.DisplayMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update a data file.
    /// Encoded/decoded by serializers as &quot;FUPD&quot;.
    /// </summary>
    [EnumMember(Value = "FUPD")]
    [IsoId("_PDBEQk0uEeea0Mdu1TOzDQ")]
    [Description(@"Update a data file.")]
    FileUpdate = ActionTypeCode.FileUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Print a message.
    /// Encoded/decoded by serializers as &quot;PRNT&quot;.
    /// </summary>
    [EnumMember(Value = "PRNT")]
    [IsoId("_QG8mck0uEeea0Mdu1TOzDQ")]
    [Description(@"Print a message.")]
    PrintMessage = ActionTypeCode.PrintMessage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Send a message.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_QxFvok0uEeea0Mdu1TOzDQ")]
    [Description(@"Send a message.")]
    SendMessage = ActionTypeCode.SendMessage, // same ordinal as derivation source for type conversions
}
