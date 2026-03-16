// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Current status of the security device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dpBEkIr-EeSvuOJS0mmL0g")]
[Description(@"Current status of the security device.")]
[DerivedFrom(typeof(ATMStatusCode))]
public enum ATMStatus2Code
{
    /// <summary>
    /// Component is activated and in operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_fZ82sYr-EeSvuOJS0mmL0g")]
    [Description(@"Component is activated and in operation.")]
    InOperation = ATMStatusCode.InOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM out of service.
    /// Encoded/decoded by serializers as &quot;OUTS&quot;.
    /// </summary>
    [EnumMember(Value = "OUTS")]
    [IsoId("_fkcPc4r-EeSvuOJS0mmL0g")]
    [Description(@"ATM out of service.")]
    OutOfService = ATMStatusCode.OutOfService, // same ordinal as derivation source for type conversions
}
