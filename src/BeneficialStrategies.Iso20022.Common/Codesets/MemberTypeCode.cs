// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLzqtNp-Ed-ak6NoX_4Aeg_977880731")]
[Description(@"Specifies the nature of the membership of a party in a system. A system may recognise different types of membership, with different related rights and obligations.")]
[Derivations(typeof(MemberType1Code))]
public enum MemberTypeCode
{
    /// <summary>
    /// Member has full rights in the system. In principle, this membership status entails financial responsibility for its own operations and sponsored members&apos; operations submitted to the system.
    /// Encoded/decoded by serializers as &quot;DRCT&quot;.
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_aLzqtdp-Ed-ak6NoX_4Aeg_977880732")]
    [Description(@"Member has full rights in the system. In principle, this membership status entails financial responsibility for its own operations and sponsored members' operations submitted to the system.")]
    Direct,
    
    /// <summary>
    /// Member has limited rights in the system specifications. In principle, this membership status entails no financial responsibility for its operations submitted to the system.
    /// Encoded/decoded by serializers as &quot;IDRT&quot;.
    /// </summary>
    [EnumMember(Value = "IDRT")]
    [IsoId("_aLzqttp-Ed-ak6NoX_4Aeg_977880733")]
    [Description(@"Member has limited rights in the system specifications. In principle, this membership status entails no financial responsibility for its operations submitted to the system.")]
    Indirect,
    
    /// <summary>
    /// Member has access to the system from a remote location or through remote technical means.
    /// Encoded/decoded by serializers as &quot;RMTE&quot;.
    /// </summary>
    [EnumMember(Value = "RMTE")]
    [IsoId("_aLzqt9p-Ed-ak6NoX_4Aeg_977880734")]
    [Description(@"Member has access to the system from a remote location or through remote technical means.")]
    Remote,
    
    /// <summary>
    /// Member is entitled to access the Euro1 system of the Euro Banking Association (EBA).
    /// Encoded/decoded by serializers as &quot;EURO&quot;.
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_aLzquNp-Ed-ak6NoX_4Aeg_977880735")]
    [Description(@"Member is entitled to access the Euro1 system of the Euro Banking Association (EBA).")]
    EURO1,
    
    /// <summary>
    /// Member is entitled to access the Step1 system of the Euro Banking Association (EBA).
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_aLzqudp-Ed-ak6NoX_4Aeg_977880736")]
    [Description(@"Member is entitled to access the Step1 system of the Euro Banking Association (EBA).")]
    STEP1,
    
}
