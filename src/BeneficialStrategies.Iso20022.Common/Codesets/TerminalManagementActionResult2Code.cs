// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed command at the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tKHfIIr3EeSvuOJS0mmL0g")]
[Description(@"Final result of the processed command at the ATM.")]
[DerivedFrom(typeof(TerminalManagementActionResultCode))]
public enum TerminalManagementActionResult2Code
{
    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as &quot;CNTE&quot;.
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_wh7IcYr3EeSvuOJS0mmL0g")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError = TerminalManagementActionResultCode.ConnectionError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as &quot;FMTE&quot;.
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_ws0w44r3EeSvuOJS0mmL0g")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError = TerminalManagementActionResultCode.FormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Hardware error.
    /// Encoded/decoded by serializers as &quot;HRDW&quot;.
    /// </summary>
    [EnumMember(Value = "HRDW")]
    [IsoId("_w1T-g4r3EeSvuOJS0mmL0g")]
    [Description(@"Hardware error.")]
    Hardware = TerminalManagementActionResultCode.Hardware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_x7CQcor3EeSvuOJS0mmL0g")]
    [Description(@"Action is not supported.")]
    NotSupported = TerminalManagementActionResultCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security error.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_yF5co4r3EeSvuOJS0mmL0g")]
    [Description(@"Security error.")]
    Security = TerminalManagementActionResultCode.Security, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_yNUTQYr3EeSvuOJS0mmL0g")]
    [Description(@"Action was successfully performed.")]
    Success = TerminalManagementActionResultCode.Success, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as &quot;SYNE&quot;.
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_zAQME4r3EeSvuOJS0mmL0g")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError = TerminalManagementActionResultCode.SyntaxError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_zG0HE4r3EeSvuOJS0mmL0g")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout = TerminalManagementActionResultCode.Timeout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as &quot;UKRF&quot;.
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_zbnSY4r3EeSvuOJS0mmL0g")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference = TerminalManagementActionResultCode.UnknownKeyReference, // same ordinal as derivation source for type conversions
}
