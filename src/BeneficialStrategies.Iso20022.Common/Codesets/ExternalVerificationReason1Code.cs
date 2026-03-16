// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external verification reason code, as published in an external verification code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YWiyMNp-Ed-ak6NoX_4Aeg_914233593")]
[Description(
    @"Specifies the external verification reason code, as published in an external verification code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalVerificationReasonCode))]
public enum ExternalVerificationReason1Code
{
    /// <summary>
    /// Account number provided in the request is invalid or missing.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_uG8YjvRYEeuLhpyIdtJzwg")]
    [Description(@"Account number provided in the request is invalid or missing.")]
    IncorrectAccountNumber = ExternalVerificationReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent identification provided in the request is incorrect
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_uHFicvRYEeuLhpyIdtJzwg")]
    [Description(@"Agent identification provided in the request is incorrect")]
    IncorrectAgent = ExternalVerificationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request is a duplicate of another request
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_uHFidfRYEeuLhpyIdtJzwg")]
    [Description(@"Request is a duplicate of another request")]
    DuplicateRequest = ExternalVerificationReasonCode.DuplicateRequest, // same ordinal as derivation source for type conversions
}
