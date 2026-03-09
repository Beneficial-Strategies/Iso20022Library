// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_c6sBIIO6EeSWSLYdc10LRg")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface3Code
{
    /// <summary>
    /// Acquirer.
    /// Encoded/decoded by serializers as &quot;ACQU&quot;.
    /// </summary>
    [EnumMember(Value = "ACQU")]
    [IsoId("_ecl4wYO6EeSWSLYdc10LRg")]
    [Description(@"Acquirer.")]
    Acquirer = UserInterfaceCode.Acquirer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_ejvpoYO6EeSWSLYdc10LRg")]
    [Description(@"Agent.")]
    Agent = UserInterfaceCode.Agent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_euVJAYO6EeSWSLYdc10LRg")]
    [Description(@"Issuer.")]
    Issuer = UserInterfaceCode.Issuer, // same ordinal as derivation source for type conversions
    
}
