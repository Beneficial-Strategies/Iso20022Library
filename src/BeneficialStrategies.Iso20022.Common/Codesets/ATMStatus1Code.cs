// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n7mq8IqLEeSRT5rEzcAHEw")]
[Description(@"Status of the ATM.")]
[DerivedFrom(typeof(ATMStatusCode))]
public enum ATMStatus1Code
{
    /// <summary>
    /// Component is in service.
    /// Encoded/decoded by serializers as &quot;INSV&quot;.
    /// </summary>
    [EnumMember(Value = "INSV")]
    [IsoId("_pVnK0YqLEeSRT5rEzcAHEw")]
    [Description(@"Component is in service.")]
    InService = ATMStatusCode.InService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ATM out of service.
    /// Encoded/decoded by serializers as &quot;OUTS&quot;.
    /// </summary>
    [EnumMember(Value = "OUTS")]
    [IsoId("_pZx5IYqLEeSRT5rEzcAHEw")]
    [Description(@"ATM out of service.")]
    OutOfService = ATMStatusCode.OutOfService, // same ordinal as derivation source for type conversions
    
}
