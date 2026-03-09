// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of a standing instruction cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZgdAlNp-Ed-ak6NoX_4Aeg_1761795494")]
[Description(@"Specifies the reason of a rejection of a standing instruction cancellation request.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason10Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZgdAldp-Ed-ak6NoX_4Aeg_-611576163")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions
    
}
