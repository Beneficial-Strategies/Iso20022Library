// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of supporting document.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3DrUQNnSEeS--7IJLPC9lw")]
[Description(@"Specifies a type of supporting document.")]
[Derivations(typeof(SupportDocumentType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SupportDocumentTypeCode>))]
#endif
public enum SupportDocumentTypeCode
{
    /// <summary>
    /// Document is a supporting document.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_5BhhANnSEeS--7IJLPC9lw")]
    [Description(@"Document is a supporting document.")]
    SupportingDocument,

    /// <summary>
    /// Document is a letter from the bank.
    /// Encoded/decoded by serializers as &quot;LFBK&quot;.
    /// </summary>
    [EnumMember(Value = "LFBK")]
    [IsoId("_-KQVYNnSEeS--7IJLPC9lw")]
    [Description(@"Document is a letter from the bank.")]
    LetterFromBank,

    /// <summary>
    /// Document is a letter to the bank.
    /// Encoded/decoded by serializers as &quot;LTBK&quot;.
    /// </summary>
    [EnumMember(Value = "LTBK")]
    [IsoId("_C6ACAdnTEeS--7IJLPC9lw")]
    [Description(@"Document is a letter to the bank.")]
    LetterToBank,
}
