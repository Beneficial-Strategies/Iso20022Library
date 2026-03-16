// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the origin of the signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-s3AAMnAEeWI4cSIO9foRA")]
[Description(@"Specifies the origin of the signature.")]
[DerivedFrom(typeof(SignatureOriginTypeCode))]
public enum SignatureOriginType1Code
{
    /// <summary>
    /// Signature is provided for the value validation of the file.
    /// Encoded/decoded by serializers as &quot;VLUE&quot;.
    /// </summary>
    [EnumMember(Value = "VLUE")]
    [IsoId("_q_EtIcnIEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the value validation of the file.")]
    Value = SignatureOriginTypeCode.Value, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Signature is provided for the technical validation of the file.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_rD_CUcnIEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the technical validation of the file.")]
    Technical = SignatureOriginTypeCode.Technical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Signature is provided for the contract validation of the file.
    /// Encoded/decoded by serializers as &quot;CTRC&quot;.
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_rI5XgcnIEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the contract validation of the file.")]
    Contract = SignatureOriginTypeCode.Contract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Signature is provided for the bank validation of the file.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_rNgKscnIEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the bank validation of the file.")]
    Bank = SignatureOriginTypeCode.Bank, // same ordinal as derivation source for type conversions
}
