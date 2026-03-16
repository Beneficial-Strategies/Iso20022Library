// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies that the transaction has been modified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0ldWoglIEeGATtfOBToyew_1371294277")]
[Description(@"Specifies that the transaction has been modified.")]
[Derivations(typeof(ModifiedStatusReason1Code))]
public enum ModifiedStatusReasonCode
{
    /// <summary>
    /// Modification of a transaction by the account owner.
    /// Encoded/decoded by serializers as &quot;MDBY&quot;.
    /// </summary>
    [EnumMember(Value = "MDBY")]
    [IsoId("_0ldWowlIEeGATtfOBToyew_471915014")]
    [Description(@"Modification of a transaction by the account owner.")]
    ModifiedByYourself,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0ldWpAlIEeGATtfOBToyew_377855801")]
    [Description(@"Other. See Narrative.")]
    Other,
}
