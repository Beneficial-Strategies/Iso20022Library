// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yll61Np-Ed-ak6NoX_4Aeg_771598790")]
[Description(
    @"Specifies the result of the technical validation carried out by the receiver (forwarding or first agent)."
)]
[Derivations(typeof(TechnicalValidationStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TechnicalValidationStatusCode>))]
#endif
public enum TechnicalValidationStatusCode
{
    /// <summary>
    /// Indicates that the request has been correctly received and that the technical validation was successful.
    /// Encoded/decoded by serializers as &quot;RCCF&quot;.
    /// </summary>
    [EnumMember(Value = "RCCF")]
    [IsoId("_Yll61dp-Ed-ak6NoX_4Aeg_1506722144")]
    [Description(
        @"Indicates that the request has been correctly received and that the technical validation was successful."
    )]
    ReceptionConfirmation,

    /// <summary>
    /// Indicates there was an error in the reception of the request or that the technical validation was not successful.
    /// Encoded/decoded by serializers as &quot;RCER&quot;.
    /// </summary>
    [EnumMember(Value = "RCER")]
    [IsoId("_Yll61tp-Ed-ak6NoX_4Aeg_1529808681")]
    [Description(
        @"Indicates there was an error in the reception of the request or that the technical validation was not successful."
    )]
    ReceptionError,
}
