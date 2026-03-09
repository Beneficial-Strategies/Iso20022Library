// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZhNstp-Ed-ak6NoX_4Aeg_-735267908")]
[Description(@"Specifies the clearing account type.")]
[Derivations(typeof(ClearingAccountType1Code),typeof(ClearingAccountType3Code),typeof(ClearingAccountType4Code))]
public enum ClearingAccountTypeCode
{
    /// <summary>
    /// Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.
    /// Encoded/decoded by serializers as &quot;HOUS&quot;.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_YZhNs9p-Ed-ak6NoX_4Aeg_1631677656")]
    [Description(@"Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.")]
    House,
    
    /// <summary>
    /// Specifies that the account is used to register trades executed for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_YZhNtNp-Ed-ak6NoX_4Aeg_2062824443")]
    [Description(@"Specifies that the account is used to register trades executed for the clearing member's customers.")]
    Client,
    
    /// <summary>
    /// Specifies that the account is used to register trades executed for liquidity providers (also known as market maker) activities.
    /// Encoded/decoded by serializers as &quot;LIPR&quot;.
    /// </summary>
    [EnumMember(Value = "LIPR")]
    [IsoId("_YZhNtdp-Ed-ak6NoX_4Aeg_124536150")]
    [Description(@"Specifies that the account is used to register trades executed for liquidity providers (also known as market maker) activities.")]
    LiquidityProvider,
    
    /// <summary>
    /// Specifies that client position and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled, however initial margin requirements are calculated on a gross basis for each related margining account.
    /// Encoded/decoded by serializers as &quot;GOSA&quot;.
    /// </summary>
    [EnumMember(Value = "GOSA")]
    [IsoId("_u-y54HXqEee_qcLXasnA4g")]
    [Description(@"Specifies that client position and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled, however initial margin requirements are calculated on a gross basis for each related margining account.")]
    GrossOmnibusClientAccount,
    
    /// <summary>
    /// Specifies that the client positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled while initial margin requirements are calculated on a net basis across all related margining or position accounts.
    /// Encoded/decoded by serializers as &quot;NOSA&quot;.
    /// </summary>
    [EnumMember(Value = "NOSA")]
    [IsoId("_N0QyMHXrEee_qcLXasnA4g")]
    [Description(@"Specifies that the client positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled while initial margin requirements are calculated on a net basis across all related margining or position accounts.")]
    NetOmnibusClientAccount,
    
    /// <summary>
    /// Specifies that customer positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally segregated.
    /// Encoded/decoded by serializers as &quot;ISEG&quot;.
    /// </summary>
    [EnumMember(Value = "ISEG")]
    [IsoId("__4cu4HX7Eee_qcLXasnA4g")]
    [Description(@"Specifies that customer positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally segregated.")]
    IndividuallySegregatedAccount,
    
}
