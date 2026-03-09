// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of membership the collateral provider holds with the CCP.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mKuBsAIJEeutW5-TpeYJhA")]
[Description(@"Specifies the type of membership the collateral provider holds with the CCP.")]
[DerivedFrom(typeof(CCPMemberTypeCode))]
public enum CCPMemberType1Code
{
    /// <summary>
    /// Agent Clearing Member.
    /// Encoded/decoded by serializers as &quot;ACMB&quot;.
    /// </summary>
    [EnumMember(Value = "ACMB")]
    [IsoId("_oMEOYQIJEeutW5-TpeYJhA")]
    [Description(@"Agent Clearing Member.|")]
    AgentClearingMember = CCPMemberTypeCode.AgentClearingMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing House.
    /// Encoded/decoded by serializers as &quot;CCPX&quot;.
    /// </summary>
    [EnumMember(Value = "CCPX")]
    [IsoId("_oVkIogIJEeutW5-TpeYJhA")]
    [Description(@"Clearing House.")]
    ClearingHouse = CCPMemberTypeCode.ClearingHouse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Direct Clearing Member.
    /// Encoded/decoded by serializers as &quot;DCMB&quot;.
    /// </summary>
    [EnumMember(Value = "DCMB")]
    [IsoId("_ofNM0gIJEeutW5-TpeYJhA")]
    [Description(@"Direct Clearing Member.|")]
    DirectClearingMember = CCPMemberTypeCode.DirectClearingMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Futures Commission Merchant.
    /// Encoded/decoded by serializers as &quot;FCMC&quot;.
    /// </summary>
    [EnumMember(Value = "FCMC")]
    [IsoId("_oo9lwgIJEeutW5-TpeYJhA")]
    [Description(@"Futures Commission Merchant.||")]
    FuturesCommissionMerchant = CCPMemberTypeCode.FuturesCommissionMerchant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// General Clearing Member.
    /// Encoded/decoded by serializers as &quot;GCMB&quot;.
    /// </summary>
    [EnumMember(Value = "GCMB")]
    [IsoId("_otx0UQIJEeutW5-TpeYJhA")]
    [Description(@"General Clearing Member.|")]
    GeneralClearingMember = CCPMemberTypeCode.GeneralClearingMember, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sponsored Clearing Member.
    /// Encoded/decoded by serializers as &quot;SCMB&quot;.
    /// </summary>
    [EnumMember(Value = "SCMB")]
    [IsoId("_o53vkgIJEeutW5-TpeYJhA")]
    [Description(@"Sponsored Clearing Member.| ")]
    SponsoredClearingMember = CCPMemberTypeCode.SponsoredClearingMember, // same ordinal as derivation source for type conversions
    
}
