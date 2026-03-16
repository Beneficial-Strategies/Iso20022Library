// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of membership the collateral provider holds with the CCP.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DohbkAGeEeutW5-TpeYJhA")]
[Description(@"Specifies the type of membership the collateral provider holds with the CCP.")]
[Derivations(typeof(CCPMemberType1Code))]
public enum CCPMemberTypeCode
{
    /// <summary>
    /// Futures Commission Merchant.
    /// Encoded/decoded by serializers as &quot;FCMC&quot;.
    /// </summary>
    [EnumMember(Value = "FCMC")]
    [IsoId("_P0ZikAGeEeutW5-TpeYJhA")]
    [Description(@"Futures Commission Merchant.||")]
    FuturesCommissionMerchant,

    /// <summary>
    /// General Clearing Member.
    /// Encoded/decoded by serializers as &quot;GCMB&quot;.
    /// </summary>
    [EnumMember(Value = "GCMB")]
    [IsoId("_clwVMAGeEeutW5-TpeYJhA")]
    [Description(@"General Clearing Member.|")]
    GeneralClearingMember,

    /// <summary>
    /// Direct Clearing Member.
    /// Encoded/decoded by serializers as &quot;DCMB&quot;.
    /// </summary>
    [EnumMember(Value = "DCMB")]
    [IsoId("_hDGqQAGeEeutW5-TpeYJhA")]
    [Description(@"Direct Clearing Member.|")]
    DirectClearingMember,

    /// <summary>
    /// Sponsored Clearing Member.
    /// Encoded/decoded by serializers as &quot;SCMB&quot;.
    /// </summary>
    [EnumMember(Value = "SCMB")]
    [IsoId("_rxAXYAGeEeutW5-TpeYJhA")]
    [Description(@"Sponsored Clearing Member.| ")]
    SponsoredClearingMember,

    /// <summary>
    /// Agent Clearing Member.
    /// Encoded/decoded by serializers as &quot;ACMB&quot;.
    /// </summary>
    [EnumMember(Value = "ACMB")]
    [IsoId("_xBv4QAGeEeutW5-TpeYJhA")]
    [Description(@"Agent Clearing Member.|")]
    AgentClearingMember,

    /// <summary>
    /// Clearing House.
    /// Encoded/decoded by serializers as &quot;CCPX&quot;.
    /// </summary>
    [EnumMember(Value = "CCPX")]
    [IsoId("_57SEwAGeEeutW5-TpeYJhA")]
    [Description(@"Clearing House.")]
    ClearingHouse,
}
