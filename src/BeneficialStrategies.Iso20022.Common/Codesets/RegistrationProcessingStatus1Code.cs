// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the registration processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZbFYYNp-Ed-ak6NoX_4Aeg_-586829209")]
[Description(@"Specifies the status of the registration processing.")]
[DerivedFrom(typeof(RegistrationProcessingStatusCode))]
public enum RegistrationProcessingStatus1Code
{
    /// <summary>
    /// Registration has been acknowledged/accepted by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZbFYYdp-Ed-ak6NoX_4Aeg_-586829178")]
    [Description(@"Registration has been acknowledged/accepted by the issuer/registrar.")]
    AcknowledgedAccepted = RegistrationProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Registration has been rejected by the issuer/registrar.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_ZbFYYtp-Ed-ak6NoX_4Aeg_-586829177")]
    [Description(@"Registration has been rejected by the issuer/registrar.")]
    Rejected = RegistrationProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
}
