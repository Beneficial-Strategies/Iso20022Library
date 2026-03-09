// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Kipi0PS8EeiAX8EjdnKKRw")]
[Description(@"Specifies the external mandate suspension reason code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalMandateSuspensionReason1Code))]
public enum ExternalMandateSuspensionReasonCode
{
    /// <summary>
    /// Mandate suspended due to amendment of the contract.
    /// Encoded/decoded by serializers as &quot;CTAM&quot;.
    /// </summary>
    [EnumMember(Value = "CTAM")]
    [IsoId("_uY0ys_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended due to amendment of the contract.")]
    ContractAmended,
    
    /// <summary>
    /// Mandate suspended due to cancellation of the contract, requested by the debtor.
    /// Encoded/decoded by serializers as &quot;CTCA&quot;.
    /// </summary>
    [EnumMember(Value = "CTCA")]
    [IsoId("_uY98oPRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended due to cancellation of the contract, requested by the debtor.")]
    ContractCancellationInitiatedByDebtor,
    
    /// <summary>
    /// Mandate suspended due to the contract that expired.
    /// Encoded/decoded by serializers as &quot;CTEX&quot;.
    /// </summary>
    [EnumMember(Value = "CTEX")]
    [IsoId("_uY98o_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended due to the contract that expired.")]
    ContractExpired,
    
    /// <summary>
    /// Mandate suspended as final collection took place.
    /// Encoded/decoded by serializers as &quot;MCFC&quot;.
    /// </summary>
    [EnumMember(Value = "MCFC")]
    [IsoId("_uY98pvRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended as final collection took place.")]
    MandateSuspendedFinalCollection,
    
    /// <summary>
    /// Mandate suspended as the once off collection took place.
    /// Encoded/decoded by serializers as &quot;MCOC&quot;.
    /// </summary>
    [EnumMember(Value = "MCOC")]
    [IsoId("_uY98qfRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended as the once off collection took place.")]
    MandateSuspendedOnceOffCollection,
    
    /// <summary>
    /// Mandate suspended after 7 consecutive unsuccessful collections.
    /// Encoded/decoded by serializers as &quot;MSUC&quot;.
    /// </summary>
    [EnumMember(Value = "MSUC")]
    [IsoId("_uY98rPRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate suspended after 7 consecutive unsuccessful collections.")]
    MandateSuspended7ConsecutiveUnsuccessfulCollections,
    
}
