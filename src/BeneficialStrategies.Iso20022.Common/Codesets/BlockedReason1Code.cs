// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason an account is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cRRFABHbEeKVqeHljBM1MQ")]
[Description(@"Specifies the reason an account is blocked.")]
[DerivedFrom(typeof(BlockedReasonCode))]
public enum BlockedReason1Code
{
    /// <summary>
    /// Bankruptcy.
    /// Encoded/decoded by serializers as &quot;BKRP&quot;.
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_WeMLwRHeEeKVqeHljBM1MQ")]
    [Description(@"Bankruptcy.")]
    Bankruptcy = BlockedReasonCode.Bankruptcy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commitment.
    /// Encoded/decoded by serializers as &quot;CMMT&quot;.
    /// </summary>
    [EnumMember(Value = "CMMT")]
    [IsoId("_Wm-7YRHeEeKVqeHljBM1MQ")]
    [Description(@"Commitment.")]
    Commitment = BlockedReasonCode.Commitment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confiscation.
    /// Encoded/decoded by serializers as &quot;CNFS&quot;.
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_WyKQoRHeEeKVqeHljBM1MQ")]
    [Description(@"Confiscation.")]
    Confiscation = BlockedReasonCode.Confiscation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved in contemplation of death.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_XAKQYRHeEeKVqeHljBM1MQ")]
    [Description(@"Reserved in contemplation of death.")]
    MortisCausa = BlockedReasonCode.MortisCausa, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pledged.
    /// Encoded/decoded by serializers as &quot;PLDG&quot;.
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_XOK3MRHeEeKVqeHljBM1MQ")]
    [Description(@"Pledged.")]
    Pledged = BlockedReasonCode.Pledged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reregistration.
    /// Encoded/decoded by serializers as &quot;TRPE&quot;.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_XYTqoRHeEeKVqeHljBM1MQ")]
    [Description(@"Reregistration.")]
    Reregistration = BlockedReasonCode.Reregistration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_Xmw9YRHeEeKVqeHljBM1MQ")]
    [Description(@"Transfer.")]
    Transfer = BlockedReasonCode.Transfer, // same ordinal as derivation source for type conversions
    
}
