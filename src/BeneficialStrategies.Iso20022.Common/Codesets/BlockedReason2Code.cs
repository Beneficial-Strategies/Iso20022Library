// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason an account is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lXE7oFsMEeaY86V9afpFqA")]
[Description(@"Specifies the reason an account is blocked.")]
[DerivedFrom(typeof(BlockedReasonCode))]
public enum BlockedReason2Code
{
    /// <summary>
    /// Bankruptcy.
    /// Encoded/decoded by serializers as &quot;BKRP&quot;.
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_pAggcFsMEeaY86V9afpFqA")]
    [Description(@"Bankruptcy.")]
    Bankruptcy = BlockedReasonCode.Bankruptcy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commitment.
    /// Encoded/decoded by serializers as &quot;CMMT&quot;.
    /// </summary>
    [EnumMember(Value = "CMMT")]
    [IsoId("_pFkmoVsMEeaY86V9afpFqA")]
    [Description(@"Commitment.")]
    Commitment = BlockedReasonCode.Commitment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Confiscation.
    /// Encoded/decoded by serializers as &quot;CNFS&quot;.
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_pMHTgVsMEeaY86V9afpFqA")]
    [Description(@"Confiscation.")]
    Confiscation = BlockedReasonCode.Confiscation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reserved in contemplation of death.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_pSXFcVsMEeaY86V9afpFqA")]
    [Description(@"Reserved in contemplation of death.")]
    MortisCausa = BlockedReasonCode.MortisCausa, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pending compliance verification.
    /// Encoded/decoded by serializers as &quot;PCOM&quot;.
    /// </summary>
    [EnumMember(Value = "PCOM")]
    [IsoId("_pZNUUVsMEeaY86V9afpFqA")]
    [Description(@"Pending compliance verification.")]
    PendingComplianceVerification = BlockedReasonCode.PendingComplianceVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pledged.
    /// Encoded/decoded by serializers as &quot;PLDG&quot;.
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_pfdGQVsMEeaY86V9afpFqA")]
    [Description(@"Pledged.")]
    Pledged = BlockedReasonCode.Pledged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reregistration.
    /// Encoded/decoded by serializers as &quot;TRPE&quot;.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_pjxlkVsMEeaY86V9afpFqA")]
    [Description(@"Reregistration.")]
    Reregistration = BlockedReasonCode.Reregistration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sanctions are in place.
    /// Encoded/decoded by serializers as &quot;SANC&quot;.
    /// </summary>
    [EnumMember(Value = "SANC")]
    [IsoId("_poiJwVsMEeaY86V9afpFqA")]
    [Description(@"Sanctions are in place.")]
    Sanctions = BlockedReasonCode.Sanctions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transfer.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_pvhikVsMEeaY86V9afpFqA")]
    [Description(@"Transfer.")]
    Transfer = BlockedReasonCode.Transfer, // same ordinal as derivation source for type conversions
    
}
