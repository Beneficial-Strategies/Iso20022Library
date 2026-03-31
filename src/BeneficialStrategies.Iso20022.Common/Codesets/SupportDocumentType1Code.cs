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
[IsoId("_MSMgcNnTEeS--7IJLPC9lw")]
[Description(@"Specifies a type of supporting document.")]
[DerivedFrom(typeof(SupportDocumentTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SupportDocumentType1Code>))]
#endif
public enum SupportDocumentType1Code
{
    /// <summary>
    /// Document is a letter from the bank.
    /// Encoded/decoded by serializers as &quot;LFBK&quot;.
    /// </summary>
    [EnumMember(Value = "LFBK")]
    [IsoId("_NckB0dnTEeS--7IJLPC9lw")]
    [Description(@"Document is a letter from the bank.")]
    LetterFromBank = SupportDocumentTypeCode.LetterFromBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a letter to the bank.
    /// Encoded/decoded by serializers as &quot;LTBK&quot;.
    /// </summary>
    [EnumMember(Value = "LTBK")]
    [IsoId("_NmYsM9nTEeS--7IJLPC9lw")]
    [Description(@"Document is a letter to the bank.")]
    LetterToBank = SupportDocumentTypeCode.LetterToBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a supporting document.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_NsetI9nTEeS--7IJLPC9lw")]
    [Description(@"Document is a supporting document.")]
    SupportingDocument = SupportDocumentTypeCode.SupportingDocument, // same ordinal as derivation source for type conversions
}
