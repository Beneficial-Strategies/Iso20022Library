// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3OO64bC1EeamYaqfhG1ZuA")]
[Description(@"Final result of the processed terminal management action.")]
[DerivedFrom(typeof(TerminalManagementActionResultCode))]
public enum TerminalManagementActionResult3Code
{
    /// <summary>
    /// Access is denied while performing the action.
    /// Encoded/decoded by serializers as &quot;ACCD&quot;.
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_3duIYbC1EeamYaqfhG1ZuA")]
    [Description(@"Access is denied while performing the action.")]
    AccessDenied = TerminalManagementActionResultCode.AccessDenied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as &quot;CNTE&quot;.
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_3duIY7C1EeamYaqfhG1ZuA")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError = TerminalManagementActionResultCode.ConnectionError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as &quot;FMTE&quot;.
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_3duIZbC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError = TerminalManagementActionResultCode.FormatError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Content of the data is invalid.
    /// Encoded/decoded by serializers as &quot;INVC&quot;.
    /// </summary>
    [EnumMember(Value = "INVC")]
    [IsoId("_3duIZ7C1EeamYaqfhG1ZuA")]
    [Description(@"Content of the data is invalid.")]
    InvalidContent = TerminalManagementActionResultCode.InvalidContent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong length.
    /// Encoded/decoded by serializers as &quot;LENE&quot;.
    /// </summary>
    [EnumMember(Value = "LENE")]
    [IsoId("_3duIabC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong length.")]
    LengthError = TerminalManagementActionResultCode.LengthError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Memory to store the date exceeded.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_3duIa7C1EeamYaqfhG1ZuA")]
    [Description(@"Memory to store the date exceeded.")]
    MemoryOverflow = TerminalManagementActionResultCode.MemoryOverflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data set to be maintained is missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_3duIbbC1EeamYaqfhG1ZuA")]
    [Description(@"Data set to be maintained is missing.")]
    MissingFile = TerminalManagementActionResultCode.MissingFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_3duIb7C1EeamYaqfhG1ZuA")]
    [Description(@"Action is not supported.")]
    NotSupported = TerminalManagementActionResultCode.NotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong digital signature.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_3duIcbC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong digital signature.")]
    SignatureError = TerminalManagementActionResultCode.SignatureError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_3duIc7C1EeamYaqfhG1ZuA")]
    [Description(@"Action was successfully performed.")]
    Success = TerminalManagementActionResultCode.Success, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as &quot;SYNE&quot;.
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_3duIdbC1EeamYaqfhG1ZuA")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError = TerminalManagementActionResultCode.SyntaxError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_3duId7C1EeamYaqfhG1ZuA")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout = TerminalManagementActionResultCode.Timeout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data set identification invalid.
    /// Encoded/decoded by serializers as &quot;UKDT&quot;.
    /// </summary>
    [EnumMember(Value = "UKDT")]
    [IsoId("_3duIebC1EeamYaqfhG1ZuA")]
    [Description(@"Data set identification invalid.")]
    UnknownData = TerminalManagementActionResultCode.UnknownData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as &quot;UKRF&quot;.
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_3duIe7C1EeamYaqfhG1ZuA")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference = TerminalManagementActionResultCode.UnknownKeyReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Delegation Proof transmitted by the delegated TMS is not the one expected.
    /// Encoded/decoded by serializers as &quot;INDP&quot;.
    /// </summary>
    [EnumMember(Value = "INDP")]
    [IsoId("_wgTYYbC3EeamYaqfhG1ZuA")]
    [Description(@"Delegation Proof transmitted by the delegated TMS is not the one expected.")]
    InvalidDelegationProof = TerminalManagementActionResultCode.InvalidDelegationProof, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.
    /// Encoded/decoded by serializers as &quot;IDMP&quot;.
    /// </summary>
    [EnumMember(Value = "IDMP")]
    [IsoId("_wuOfobC3EeamYaqfhG1ZuA")]
    [Description(@"One action of the AcceptorManagementPlan refers to an update unauthorized by the delegation.")]
    InvalidDelegationInManagementPlan = TerminalManagementActionResultCode.InvalidDelegationInManagementPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.
    /// Encoded/decoded by serializers as &quot;DPRU&quot;.
    /// </summary>
    [EnumMember(Value = "DPRU")]
    [IsoId("_w_M64bC3EeamYaqfhG1ZuA")]
    [Description(@"The content analysis of the AcceptorConfigurationUpdate reveals unexpected parameters.")]
    DelegationParametersReceivedUnauthorized = TerminalManagementActionResultCode.DelegationParametersReceivedUnauthorized, // same ordinal as derivation source for type conversions
    
}
