// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the origin of the signature.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_l-8UwMnAEeWI4cSIO9foRA")]
[Description(@"Specifies the origin of the signature.")]
[Derivations(typeof(SignatureOriginType1Code))]
public enum SignatureOriginTypeCode
{
    /// <summary>
    /// Signature is provided for the contract validation of the file.
    /// Encoded/decoded by serializers as &quot;CTRC&quot;.
    /// </summary>
    [EnumMember(Value = "CTRC")]
    [IsoId("_suYoQMnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the contract validation of the file.")]
    Contract,
    
    /// <summary>
    /// Signature is provided for the technical validation of the file.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_szS9cMnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the technical validation of the file.")]
    Technical,
    
    /// <summary>
    /// Signature is provided for the value validation of the file.
    /// Encoded/decoded by serializers as &quot;VLUE&quot;.
    /// </summary>
    [EnumMember(Value = "VLUE")]
    [IsoId("_rX9A0MnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the value validation of the file.")]
    Value,
    
    /// <summary>
    /// Signature is provided for the bank validation of the file.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_s4NSoMnAEeWI4cSIO9foRA")]
    [Description(@"Signature is provided for the bank validation of the file.")]
    Bank,
    
}
