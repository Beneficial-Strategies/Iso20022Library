// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4BQVUdwmEeeKpa-yxjuKzQ")]
[Description(@"Final result of the processed terminal management action.")]
[DerivedFrom(typeof(TerminalManagementActionResultCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TerminalManagementActionResult4Code>))]
#endif
public enum TerminalManagementActionResult4Code
{
    /// <summary>
    /// Access is denied while performing the action.
    /// Encoded/decoded by serializers as &quot;ACCD&quot;.
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_4KCd4dwmEeeKpa-yxjuKzQ")]
    [Description(@"Access is denied while performing the action.")]
    AccessDenied = TerminalManagementActionResultCode.AccessDenied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as &quot;CNTE&quot;.
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_4KCd49wmEeeKpa-yxjuKzQ")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError = TerminalManagementActionResultCode.ConnectionError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as &quot;FMTE&quot;.
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_4KCd5dwmEeeKpa-yxjuKzQ")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError = TerminalManagementActionResultCode.FormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Content of the data is invalid.
    /// Encoded/decoded by serializers as &quot;INVC&quot;.
    /// </summary>
    [EnumMember(Value = "INVC")]
    [IsoId("_4KCd59wmEeeKpa-yxjuKzQ")]
    [Description(@"Content of the data is invalid.")]
    InvalidContent = TerminalManagementActionResultCode.InvalidContent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data transferred has a wrong length.
    /// Encoded/decoded by serializers as &quot;LENE&quot;.
    /// </summary>
    [EnumMember(Value = "LENE")]
    [IsoId("_4KCd6dwmEeeKpa-yxjuKzQ")]
    [Description(@"Data transferred has a wrong length.")]
    LengthError = TerminalManagementActionResultCode.LengthError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Memory to store the date exceeded.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_4KCd69wmEeeKpa-yxjuKzQ")]
    [Description(@"Memory to store the date exceeded.")]
    MemoryOverflow = TerminalManagementActionResultCode.MemoryOverflow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set to be maintained is missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_4KCd7dwmEeeKpa-yxjuKzQ")]
    [Description(@"Data set to be maintained is missing.")]
    MissingFile = TerminalManagementActionResultCode.MissingFile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_4KCd79wmEeeKpa-yxjuKzQ")]
    [Description(@"Action is not supported.")]
    NotSupported = TerminalManagementActionResultCode.NotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data transferred has a wrong digital signature.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_4KCd8dwmEeeKpa-yxjuKzQ")]
    [Description(@"Data transferred has a wrong digital signature.")]
    SignatureError = TerminalManagementActionResultCode.SignatureError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_4KCd89wmEeeKpa-yxjuKzQ")]
    [Description(@"Action was successfully performed.")]
    Success = TerminalManagementActionResultCode.Success, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as &quot;SYNE&quot;.
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_4KCd9dwmEeeKpa-yxjuKzQ")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError = TerminalManagementActionResultCode.SyntaxError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_4KCd99wmEeeKpa-yxjuKzQ")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout = TerminalManagementActionResultCode.Timeout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set identification invalid.
    /// Encoded/decoded by serializers as &quot;UKDT&quot;.
    /// </summary>
    [EnumMember(Value = "UKDT")]
    [IsoId("_4KCd-dwmEeeKpa-yxjuKzQ")]
    [Description(@"Data set identification invalid.")]
    UnknownData = TerminalManagementActionResultCode.UnknownData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as &quot;UKRF&quot;.
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_4KCd-9wmEeeKpa-yxjuKzQ")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference = TerminalManagementActionResultCode.UnknownKeyReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delegation Proof transmitted by the delegated TMS is not the one expected.
    /// Encoded/decoded by serializers as &quot;INDP&quot;.
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_4KCd_dwmEeeKpa-yxjuKzQ")]
    [Description(@"Delegation Proof transmitted by the delegated TMS is not the one expected.")]
    InvalidDelegationProof = TerminalManagementActionResultCode.InvalidDelegationProof, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.
    /// Encoded/decoded by serializers as &quot;IDMP&quot;.
    /// </summary>
    [EnumMember(Value = "IDMP")]
    [IsoId("_4KCd_9wmEeeKpa-yxjuKzQ")]
    [Description(
        @"One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation."
    )]
    InvalidDelegationInManagementPlan =
        TerminalManagementActionResultCode.InvalidDelegationInManagementPlan, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.
    /// Encoded/decoded by serializers as &quot;DPRU&quot;.
    /// </summary>
    [EnumMember(Value = "DPRU")]
    [IsoId("_4KCeAdwmEeeKpa-yxjuKzQ")]
    [Description(
        @"The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters."
    )]
    DelegationParametersReceivedUnauthorized =
        TerminalManagementActionResultCode.DelegationParametersReceivedUnauthorized, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This code value means all TerminalManagementActionResultCode except &quot;Any Error&quot; and &quot;Unlisted Error&quot;.
    /// Encoded/decoded by serializers as &quot;AERR&quot;.
    /// </summary>
    [EnumMember(Value = "AERR")]
    [IsoId("_5NYKMdwmEeeKpa-yxjuKzQ")]
    [Description(
        @"This code value means all TerminalManagementActionResultCode except ""Any Error"" and ""Unlisted Error""."
    )]
    AnyError = TerminalManagementActionResultCode.AnyError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error in communication once the connection has been established.
    /// Encoded/decoded by serializers as &quot;CMER&quot;.
    /// </summary>
    [EnumMember(Value = "CMER")]
    [IsoId("_5TMeUdwmEeeKpa-yxjuKzQ")]
    [Description(@"Error in communication once the connection has been established.")]
    CommunicationError = TerminalManagementActionResultCode.CommunicationError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any error that is not defined by a code value inside the TerminalManagementActionResultCode.
    /// Encoded/decoded by serializers as &quot;ULER&quot;.
    /// </summary>
    [EnumMember(Value = "ULER")]
    [IsoId("_55C9YdwmEeeKpa-yxjuKzQ")]
    [Description(
        @"Any error that is not defined by a code value inside the TerminalManagementActionResultCode."
    )]
    UnlistedError = TerminalManagementActionResultCode.UnlistedError, // same ordinal as derivation source for type conversions
}
