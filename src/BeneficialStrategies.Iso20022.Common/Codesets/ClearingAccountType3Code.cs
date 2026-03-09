// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8eUqAHX-Eee_qcLXasnA4g")]
[Description(@"Specifies the clearing account type.")]
[DerivedFrom(typeof(ClearingAccountTypeCode))]
public enum ClearingAccountType3Code
{
    /// <summary>
    /// Specifies that the client positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled while initial margin requirements are calculated on a net basis across all related margining or position accounts.
    /// Encoded/decoded by serializers as &quot;NOSA&quot;.
    /// </summary>
    [EnumMember(Value = "NOSA")]
    [IsoId("_-IqE4XX-Eee_qcLXasnA4g")]
    [Description(@"Specifies that the client positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled while initial margin requirements are calculated on a net basis across all related margining or position accounts.")]
    NetOmnibusClientAccount = ClearingAccountTypeCode.NetOmnibusClientAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that customer positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally segregated.
    /// Encoded/decoded by serializers as &quot;ISEG&quot;.
    /// </summary>
    [EnumMember(Value = "ISEG")]
    [IsoId("_-StYwXX-Eee_qcLXasnA4g")]
    [Description(@"Specifies that customer positions and assets within the associated position and collateral accounts of the clearing account are operationally and legally segregated.")]
    IndividuallySegregatedAccount = ClearingAccountTypeCode.IndividuallySegregatedAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.
    /// Encoded/decoded by serializers as &quot;HOUS&quot;.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_-afbwXX-Eee_qcLXasnA4g")]
    [Description(@"Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.")]
    House = ClearingAccountTypeCode.House, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that client position and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled, however initial margin requirements are calculated on a gross basis for each related margining account.
    /// Encoded/decoded by serializers as &quot;GOSA&quot;.
    /// </summary>
    [EnumMember(Value = "GOSA")]
    [IsoId("_-iXlYXX-Eee_qcLXasnA4g")]
    [Description(@"Specifies that client position and assets within the associated position and collateral accounts of the clearing account are operationally and legally commingled, however initial margin requirements are calculated on a gross basis for each related margining account.")]
    GrossOmnibusClientAccount = ClearingAccountTypeCode.GrossOmnibusClientAccount, // same ordinal as derivation source for type conversions
    
}
