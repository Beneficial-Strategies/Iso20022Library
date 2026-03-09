// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Final result of the processed terminal management action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTxmoX1DEeCF8NjrBemJWQ_448413939")]
[Description(@"Final result of the processed terminal management action.")]
[DerivedFrom(typeof(TerminalManagementActionResultCode))]
public enum TerminalManagementActionResult1Code
{
    /// <summary>
    /// Access is denied while performing the action.
    /// Encoded/decoded by serializers as &quot;ACCD&quot;.
    /// </summary>
    [EnumMember(Value = "ACCD")]
    [IsoId("_KTxmon1DEeCF8NjrBemJWQ_1998349503")]
    [Description(@"Access is denied while performing the action.")]
    AccessDenied = TerminalManagementActionResultCode.AccessDenied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Problem to connect while performing the action.
    /// Encoded/decoded by serializers as &quot;CNTE&quot;.
    /// </summary>
    [EnumMember(Value = "CNTE")]
    [IsoId("_KTxmo31DEeCF8NjrBemJWQ_-2004781439")]
    [Description(@"Problem to connect while performing the action.")]
    ConnectionError = TerminalManagementActionResultCode.ConnectionError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong format.
    /// Encoded/decoded by serializers as &quot;FMTE&quot;.
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_KTxmpH1DEeCF8NjrBemJWQ_258228783")]
    [Description(@"Data transferred has a wrong format.")]
    FormatError = TerminalManagementActionResultCode.FormatError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Content of the data is invalid.
    /// Encoded/decoded by serializers as &quot;INVC&quot;.
    /// </summary>
    [EnumMember(Value = "INVC")]
    [IsoId("_KTxmpX1DEeCF8NjrBemJWQ_84218319")]
    [Description(@"Content of the data is invalid.")]
    InvalidContent = TerminalManagementActionResultCode.InvalidContent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong length.
    /// Encoded/decoded by serializers as &quot;LENE&quot;.
    /// </summary>
    [EnumMember(Value = "LENE")]
    [IsoId("_KTxmpn1DEeCF8NjrBemJWQ_2107604522")]
    [Description(@"Data transferred has a wrong length.")]
    LengthError = TerminalManagementActionResultCode.LengthError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Memory to store the date exceeded.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_KTxmp31DEeCF8NjrBemJWQ_90247886")]
    [Description(@"Memory to store the date exceeded.")]
    MemoryOverflow = TerminalManagementActionResultCode.MemoryOverflow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data set to be maintained is missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_KTxmqH1DEeCF8NjrBemJWQ_2138138548")]
    [Description(@"Data set to be maintained is missing.")]
    MissingFile = TerminalManagementActionResultCode.MissingFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action is not supported.
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_KT7XoH1DEeCF8NjrBemJWQ_-1338636500")]
    [Description(@"Action is not supported.")]
    NotSupported = TerminalManagementActionResultCode.NotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong digital signature.
    /// Encoded/decoded by serializers as &quot;SIGE&quot;.
    /// </summary>
    [EnumMember(Value = "SIGE")]
    [IsoId("_KT7XoX1DEeCF8NjrBemJWQ_-1724818487")]
    [Description(@"Data transferred has a wrong digital signature.")]
    SignatureError = TerminalManagementActionResultCode.SignatureError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Action was successfully performed.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_KT7Xon1DEeCF8NjrBemJWQ_764235056")]
    [Description(@"Action was successfully performed.")]
    Success = TerminalManagementActionResultCode.Success, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data transferred has a wrong syntax.
    /// Encoded/decoded by serializers as &quot;SYNE&quot;.
    /// </summary>
    [EnumMember(Value = "SYNE")]
    [IsoId("_KT7Xo31DEeCF8NjrBemJWQ_1816440546")]
    [Description(@"Data transferred has a wrong syntax.")]
    SyntaxError = TerminalManagementActionResultCode.SyntaxError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout expired during the data transfer.
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_KT7XpH1DEeCF8NjrBemJWQ_1358492660")]
    [Description(@"Timeout expired during the data transfer.")]
    Timeout = TerminalManagementActionResultCode.Timeout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data set identification invalid.
    /// Encoded/decoded by serializers as &quot;UKDT&quot;.
    /// </summary>
    [EnumMember(Value = "UKDT")]
    [IsoId("_KT7XpX1DEeCF8NjrBemJWQ_939812179")]
    [Description(@"Data set identification invalid.")]
    UnknownData = TerminalManagementActionResultCode.UnknownData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cryptographic key reference used for the data signature is not valid.
    /// Encoded/decoded by serializers as &quot;UKRF&quot;.
    /// </summary>
    [EnumMember(Value = "UKRF")]
    [IsoId("_KT7Xpn1DEeCF8NjrBemJWQ_1526031104")]
    [Description(@"Cryptographic key reference used for the data signature is not valid.")]
    UnknownKeyReference = TerminalManagementActionResultCode.UnknownKeyReference, // same ordinal as derivation source for type conversions
    
}
