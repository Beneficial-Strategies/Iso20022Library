// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the membership of a party in a system, as published in an external system member type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7geSZnhfEeidzqjNEfehPg")]
[Description(@"Specifies the nature of the membership of a party in a system, as published in an external system member type code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalSystemMemberTypeCode))]
public enum ExternalSystemMemberType1Code
{
    /// <summary>
    /// Member has full rights in the system. In principle, this membership status entails financial responsibility for its own operations and sponsored members&apos; operations submitted to the system.
    /// Encoded/decoded by serializers as &quot;DRCT&quot;.
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_uiDnNfRYEeuLhpyIdtJzwg")]
    [Description(@"Member has full rights in the system. In principle, this membership status entails financial responsibility for its own operations and sponsored members' operations submitted to the system.")]
    Direct = ExternalSystemMemberTypeCode.Direct, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member has limited rights in the system specifications. In principle, this membership status entails no financial responsibility for its operations submitted to the system.
    /// Encoded/decoded by serializers as &quot;IDRT&quot;.
    /// </summary>
    [EnumMember(Value = "IDRT")]
    [IsoId("_uiDnOPRYEeuLhpyIdtJzwg")]
    [Description(@"Member has limited rights in the system specifications. In principle, this membership status entails no financial responsibility for its operations submitted to the system.")]
    Indirect = ExternalSystemMemberTypeCode.Indirect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member has access to the system from a remote location or through remote technical means.
    /// Encoded/decoded by serializers as &quot;RMTE&quot;.
    /// </summary>
    [EnumMember(Value = "RMTE")]
    [IsoId("_uiDnO_RYEeuLhpyIdtJzwg")]
    [Description(@"Member has access to the system from a remote location or through remote technical means.")]
    Remote = ExternalSystemMemberTypeCode.Remote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member is entitled to access the Euro1 system of the Euro Banking Association (EBA).
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_uiNYMvRYEeuLhpyIdtJzwg")]
    [Description(@"Member is entitled to access the Euro1 system of the Euro Banking Association (EBA).")]
    EURO1 = ExternalSystemMemberTypeCode.EURO1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member is entitled to access the Step1 system of the Euro Banking Association (EBA).
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_uiNYNfRYEeuLhpyIdtJzwg")]
    [Description(@"Member is entitled to access the Step1 system of the Euro Banking Association (EBA).")]
    STEP1 = ExternalSystemMemberTypeCode.STEP1, // same ordinal as derivation source for type conversions
    
}
