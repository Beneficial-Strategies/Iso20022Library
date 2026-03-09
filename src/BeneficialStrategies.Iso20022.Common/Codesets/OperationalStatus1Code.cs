// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the operational status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EwU6kCDZEeWCLu74WLgP4w")]
[Description(@"Specifies the operational status.")]
[DerivedFrom(typeof(OperationalStatusCode))]
public enum OperationalStatus1Code
{
    /// <summary>
    /// Enabled.
    /// Encoded/decoded by serializers as &quot;ENAB&quot;.
    /// </summary>
    [EnumMember(Value = "ENAB")]
    [IsoId("_G4T6wSDZEeWCLu74WLgP4w")]
    [Description(@"Enabled.")]
    Enabled = OperationalStatusCode.Enabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special circumstances.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_G_dEkSDZEeWCLu74WLgP4w")]
    [Description(@"Special circumstances.")]
    SpecialCircumstances = OperationalStatusCode.SpecialCircumstances, // same ordinal as derivation source for type conversions
    
}
