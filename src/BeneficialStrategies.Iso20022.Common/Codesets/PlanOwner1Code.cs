// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains list of plan owners
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QBge0DEuEemzCpWiCwK4aQ")]
[Description(@"Contains list of plan owners")]
[DerivedFrom(typeof(PlanOwnerCode))]
public enum PlanOwner1Code
{
    /// <summary>
    /// Plan owner is an acceptor.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_WpL9cTEuEemzCpWiCwK4aQ")]
    [Description(@"Plan owner is an acceptor.")]
    Acceptor = PlanOwnerCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Plan owner is an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_XMzn4TEuEemzCpWiCwK4aQ")]
    [Description(@"Plan owner is an acquirer.")]
    Acquirer = PlanOwnerCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Plan owner is an issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_XNs_wTEuEemzCpWiCwK4aQ")]
    [Description(@"Plan owner is an issuer.")]
    Issuer = PlanOwnerCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// plan owner type is other national.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Xc55YTEuEemzCpWiCwK4aQ")]
    [Description(@"plan owner type is other national.")]
    OtherNational = PlanOwnerCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// plan owner type is other private.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_v8IiMTFLEemqWbBf8xprQQ")]
    [Description(@"plan owner type is other private.")]
    OtherPrivate = PlanOwnerCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
