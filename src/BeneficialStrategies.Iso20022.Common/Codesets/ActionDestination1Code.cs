// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Destination of action to be performed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w1Qk0E0wEeea0Mdu1TOzDQ")]
[Description(@"Destination of action to be performed.")]
[DerivedFrom(typeof(ActionDestinationCode))]
public enum ActionDestination1Code
{
    /// <summary>
    /// Data file
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_3O1WAU0wEeea0Mdu1TOzDQ")]
    [Description(@"Data file")]
    File = ActionDestinationCode.File, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mobile telephone
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_3bOMMk0wEeea0Mdu1TOzDQ")]
    [Description(@"Mobile telephone")]
    Mobile = ActionDestinationCode.Mobile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of destination for action defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_3jrkok0wEeea0Mdu1TOzDQ")]
    [Description(@"Other type of destination for action defined at national level.")]
    OtherNational = ActionDestinationCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of destination for action defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_3tJCok0wEeea0Mdu1TOzDQ")]
    [Description(@"Other type of destination for action defined at private level.")]
    OtherPrivate = ActionDestinationCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Personal computer.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_39Imck0wEeea0Mdu1TOzDQ")]
    [Description(@"Personal computer.")]
    PersonalComputer = ActionDestinationCode.PersonalComputer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Point of sale terminal.
    /// Encoded/decoded by serializers as &quot;POFS&quot;.
    /// </summary>
    [EnumMember(Value = "POFS")]
    [IsoId("_4Fl-4U0wEeea0Mdu1TOzDQ")]
    [Description(@"Point of sale terminal.")]
    PointOfSale = ActionDestinationCode.PointOfSale, // same ordinal as derivation source for type conversions
}
