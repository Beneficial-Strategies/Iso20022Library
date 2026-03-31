// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the registration processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZbFYY9p-Ed-ak6NoX_4Aeg_-770609526")]
[Description(@"Specifies the status of the registration processing.")]
[Derivations(typeof(RegistrationProcessingStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RegistrationProcessingStatusCode>))]
#endif
public enum RegistrationProcessingStatusCode
{
    /// <summary>
    /// Registration has been acknowledged/accepted by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZbFYZNp-Ed-ak6NoX_4Aeg_-713352141")]
    [Description(@"Registration has been acknowledged/accepted by the issuer/registrar.")]
    AcknowledgedAccepted,

    /// <summary>
    /// Registration has been rejected by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZbFYZdp-Ed-ak6NoX_4Aeg_-712428249")]
    [Description(@"Registration has been rejected by the issuer/registrar.")]
    Rejected,
}
