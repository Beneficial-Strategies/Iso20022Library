// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the letter type as published in an external letter type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DhrL0LTLEeuzjuBeu7kFjQ")]
[Description(
    @"Specifies the letter type as published in an external letter type code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalLetterType1Code))]
public enum ExternalLetterTypeCode
{
    /// <summary>
    /// Document is a letter from the bank.
    /// Encoded/decoded by serializers as &quot;LFBK&quot;.
    /// </summary>
    [EnumMember(Value = "LFBK")]
    [IsoId("_BdblcyqmEeyXnMF3dld6dw")]
    [Description(@"Document is a letter from the bank.")]
    LetterFromBank,

    /// <summary>
    /// Document is a letter to the bank.
    /// Encoded/decoded by serializers as &quot;LTBK&quot;.
    /// </summary>
    [EnumMember(Value = "LTBK")]
    [IsoId("_BdbldCqmEeyXnMF3dld6dw")]
    [Description(@"Document is a letter to the bank.")]
    LetterToBank,

    /// <summary>
    /// Document is a supporting document.
    /// Encoded/decoded by serializers as &quot;SUPP&quot;.
    /// </summary>
    [EnumMember(Value = "SUPP")]
    [IsoId("_BdbldSqmEeyXnMF3dld6dw")]
    [Description(@"Document is a supporting document.")]
    SupportingDocument,
}
