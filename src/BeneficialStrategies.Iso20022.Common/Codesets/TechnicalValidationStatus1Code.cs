// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yll60dp-Ed-ak6NoX_4Aeg_1971021769")]
[Description(
    @"Specifies the result of the technical validation carried out by the receiver (forwarding or first agent)."
)]
[DerivedFrom(typeof(TechnicalValidationStatusCode))]
public enum TechnicalValidationStatus1Code
{
    /// <summary>
    /// Indicates that the request has been correctly received and that the technical validation was successful.
    /// Encoded/decoded by serializers as &quot;RCCF&quot;.
    /// </summary>
    [EnumMember(Value = "RCCF")]
    [IsoId("_Yll60tp-Ed-ak6NoX_4Aeg_1971021771")]
    [Description(
        @"Indicates that the request has been correctly received and that the technical validation was successful."
    )]
    ReceptionConfirmation = TechnicalValidationStatusCode.ReceptionConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates there was an error in the reception of the request or that the technical validation was not successful.
    /// Encoded/decoded by serializers as &quot;RCER&quot;.
    /// </summary>
    [EnumMember(Value = "RCER")]
    [IsoId("_Yll609p-Ed-ak6NoX_4Aeg_1971021772")]
    [Description(
        @"Indicates there was an error in the reception of the request or that the technical validation was not successful."
    )]
    ReceptionError = TechnicalValidationStatusCode.ReceptionError, // same ordinal as derivation source for type conversions
}
