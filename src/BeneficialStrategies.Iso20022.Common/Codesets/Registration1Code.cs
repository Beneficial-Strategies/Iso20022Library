// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether registration should occur upon receipt.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Za7nY9p-Ed-ak6NoX_4Aeg_-423738675")]
[Description(@"Specifies whether registration should occur upon receipt.")]
[DerivedFrom(typeof(RegistrationCode))]
public enum Registration1Code
{
    /// <summary>
    /// Hold the securities in street name. If there is a standing instruction in place to register on receipt, then this standing instruction is to be ignored.
    /// Encoded/decoded by serializers as &quot;NREG&quot;.
    /// </summary>
    [EnumMember(Value = "NREG")]
    [IsoId("_Za7nZNp-Ed-ak6NoX_4Aeg_-365554140")]
    [Description(@"Hold the securities in street name. If there is a standing instruction in place to register on receipt, then this standing instruction is to be ignored.")]
    StreetName = RegistrationCode.StreetName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Register on receipt. If there is a standing instruction in place to hold the securities in street name, then this standing instruction is to be ignored.
    /// Encoded/decoded by serializers as &quot;YREG&quot;.
    /// </summary>
    [EnumMember(Value = "YREG")]
    [IsoId("_Za7nZdp-Ed-ak6NoX_4Aeg_-165149890")]
    [Description(@"Register on receipt. If there is a standing instruction in place to hold the securities in street name, then this standing instruction is to be ignored.")]
    Registered = RegistrationCode.Registered, // same ordinal as derivation source for type conversions
    
}
