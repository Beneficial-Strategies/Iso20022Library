// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Current status of the key.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8pbQsItCEeSxlKlAGYErFg")]
[Description(@"Current status of the key.")]
[DerivedFrom(typeof(ATMStatusCode))]
public enum ATMStatus3Code
{
    /// <summary>
    /// Component is activated and in operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_EcoHQYtDEeSxlKlAGYErFg")]
    [Description(@"Component is activated and in operation.")]
    InOperation = ATMStatusCode.InOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component has been stopped.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_Esa2wYtDEeSxlKlAGYErFg")]
    [Description(@"Component has been stopped.")]
    Stopped = ATMStatusCode.Stopped, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component has been loaded, but not yet activated.
    /// Encoded/decoded by serializers as &quot;WACT&quot;.
    /// </summary>
    [EnumMember(Value = "WACT")]
    [IsoId("_Ey1AwYtDEeSxlKlAGYErFg")]
    [Description(@"Component has been loaded, but not yet activated.")]
    WaitingActivation = ATMStatusCode.WaitingActivation, // same ordinal as derivation source for type conversions
}
