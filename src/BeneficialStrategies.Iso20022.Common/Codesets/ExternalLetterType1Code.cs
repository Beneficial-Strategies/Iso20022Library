// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the letter type as published in an external letter type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_REvvQLTLEeuzjuBeu7kFjQ")]
[Description(
    @"Specifies the letter type as published in an external letter type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalLetterTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalLetterType1Code>))]
#endif
public enum ExternalLetterType1Code
{
    /// <summary>
    /// Document is a letter from the bank.
    /// Encoded/decoded by serializers as &quot;LFBK&quot;.
    /// </summary>
    [EnumMember(Value = "LFBK")]
    [IsoId("_T0320SqmEeyXnMF3dld6dw")]
    [Description(@"Document is a letter from the bank.")]
    LetterFromBank = ExternalLetterTypeCode.LetterFromBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a letter to the bank.
    /// Encoded/decoded by serializers as &quot;LTBK&quot;.
    /// </summary>
    [EnumMember(Value = "LTBK")]
    [IsoId("_T63xISqmEeyXnMF3dld6dw")]
    [Description(@"Document is a letter to the bank.")]
    LetterToBank = ExternalLetterTypeCode.LetterToBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Document is a supporting document.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_UDEq4SqmEeyXnMF3dld6dw")]
    [Description(@"Document is a supporting document.")]
    SupportingDocument = ExternalLetterTypeCode.SupportingDocument, // same ordinal as derivation source for type conversions
}
