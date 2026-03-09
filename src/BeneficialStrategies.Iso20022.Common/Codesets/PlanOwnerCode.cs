// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains list of plan owners
/// </summary>
[DataContract]
[Serializable]
[IsoId("_799uQNuJEei2qvU6FBLZYA")]
[Description(@"Contains list of plan owners")]
[Derivations(typeof(PlanOwner1Code))]
public enum PlanOwnerCode
{
    /// <summary>
    /// Plan owner is an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_79-8YNuJEei2qvU6FBLZYA")]
    [Description(@"Plan owner is an acquirer.")]
    Acquirer,
    
    /// <summary>
    /// Plan owner is an acceptor.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_799uQduJEei2qvU6FBLZYA")]
    [Description(@"Plan owner is an acceptor.")]
    Acceptor,
    
    /// <summary>
    /// Plan owner is an issuer.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_7-AxkduJEei2qvU6FBLZYA")]
    [Description(@"Plan owner is an issuer.")]
    Issuer,
    
    /// <summary>
    /// plan owner type is other national.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_7-AxkNuJEei2qvU6FBLZYA")]
    [Description(@"plan owner type is other national.")]
    OtherNational,
    
    /// <summary>
    /// plan owner type is other private.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_7-Axk9uJEei2qvU6FBLZYA")]
    [Description(@"plan owner type is other private.")]
    OtherPrivate,
    
}
