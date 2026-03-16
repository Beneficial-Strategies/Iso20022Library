// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of a global movement authorisation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zir1Odp-Ed-ak6NoX_4Aeg_1364680565")]
[Description(@"Specifies the reason of a rejection of a global movement authorisation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason19Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Zi1mMNp-Ed-ak6NoX_4Aeg_-856637114")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
}
