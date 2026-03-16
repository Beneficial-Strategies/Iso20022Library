// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of identification used for the Cardholder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTtRRwEcEeCQm6a_G2yO_w_1636457147")]
[Description(@"Type of identification used for the Cardholder.")]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
public enum PersonIdentificationType4Code
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_TTtRSAEcEeCQm6a_G2yO_w_1917785203")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = PersonIdentificationTypeCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_TTtRSQEcEeCQm6a_G2yO_w_349884811")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber = PersonIdentificationTypeCode.DriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Employee number assigned by the company.
    /// Encoded/decoded by serializers as &quot;EEID&quot;.
    /// </summary>
    [EnumMember(Value = "EEID")]
    [IsoId("_TTtRSgEcEeCQm6a_G2yO_w_338786034")]
    [Description(@"Employee number assigned by the company.")]
    EmployeeNumber = PersonIdentificationTypeCode.EmployeeNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Driver number, assigned by the fleet manager.
    /// Encoded/decoded by serializers as &quot;DRVR&quot;.
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_TTtRSwEcEeCQm6a_G2yO_w_-1660072047")]
    [Description(@"Driver number, assigned by the fleet manager.")]
    DriverNumber = PersonIdentificationTypeCode.DriverNumber, // same ordinal as derivation source for type conversions
}
