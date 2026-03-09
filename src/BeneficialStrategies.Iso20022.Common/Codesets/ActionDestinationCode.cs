// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of destination for a specific action.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DsgNEE0wEeea0Mdu1TOzDQ")]
[Description(@"Type of destination for a specific action.")]
[Derivations(typeof(ActionDestination1Code))]
public enum ActionDestinationCode
{
    /// <summary>
    /// Personal computer.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_JiPRYE0wEeea0Mdu1TOzDQ")]
    [Description(@"Personal computer.")]
    PersonalComputer,
    
    /// <summary>
    /// Mobile telephone
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_RgGf0U0wEeea0Mdu1TOzDQ")]
    [Description(@"Mobile telephone")]
    Mobile,
    
    /// <summary>
    /// Point of sale terminal.
    /// Encoded/decoded by serializers as &quot;POFS&quot;.
    /// </summary>
    [EnumMember(Value = "POFS")]
    [IsoId("_XwLWwE0wEeea0Mdu1TOzDQ")]
    [Description(@"Point of sale terminal.")]
    PointOfSale,
    
    /// <summary>
    /// Data file
    /// Encoded/decoded by serializers as &quot;FILE&quot;.
    /// </summary>
    [EnumMember(Value = "FILE")]
    [IsoId("_eYyCcE0wEeea0Mdu1TOzDQ")]
    [Description(@"Data file")]
    File,
    
    /// <summary>
    /// Other type of destination for action defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_jyGQgE0wEeea0Mdu1TOzDQ")]
    [Description(@"Other type of destination for action defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of destination for action defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_o2RVAE0wEeea0Mdu1TOzDQ")]
    [Description(@"Other type of destination for action defined at private level.")]
    OtherPrivate,
    
}
