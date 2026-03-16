// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZC8lN9p-Ed-ak6NoX_4Aeg_-1937993979")]
[Description(@"Specifies the type of securities balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum SecuritiesBalanceType9Code
{
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_ZC8lONp-Ed-ak6NoX_4Aeg_-1937993977")]
    [Description(
        @"Balance of money or securities that is at the disposal of the account owner on the date specified."
    )]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of instructed position.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_ZC8lOdp-Ed-ak6NoX_4Aeg_-1937993976")]
    [Description(@"Balance of instructed position.")]
    Elected = BalanceTypeCode.Elected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of uninstructed position.
    /// Encoded/decoded by serializers as &quot;UNEL&quot;.
    /// </summary>
    [EnumMember(Value = "UNEL")]
    [IsoId("_ZDFvINp-Ed-ak6NoX_4Aeg_-1937993948")]
    [Description(@"Balance of uninstructed position.")]
    Unelected = BalanceTypeCode.Unelected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of financial instruments that are reserved for the distribution of the proceeds.
    /// Encoded/decoded by serializers as &quot;RDIS&quot;.
    /// </summary>
    [EnumMember(Value = "RDIS")]
    [IsoId("_ZDFvIdp-Ed-ak6NoX_4Aeg_-1937993947")]
    [Description(
        @"Balance of financial instruments that are reserved for the distribution of the proceeds."
    )]
    ReservedForDistribution = BalanceTypeCode.ReservedForDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.
    /// Encoded/decoded by serializers as &quot;RREM&quot;.
    /// </summary>
    [EnumMember(Value = "RREM")]
    [IsoId("_ZDFvItp-Ed-ak6NoX_4Aeg_-1937993918")]
    [Description(
        @"Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged."
    )]
    ReservedForRemoval = BalanceTypeCode.ReservedForRemoval, // same ordinal as derivation source for type conversions
}
