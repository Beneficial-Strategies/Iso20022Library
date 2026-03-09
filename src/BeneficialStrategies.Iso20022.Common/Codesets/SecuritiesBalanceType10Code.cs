// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y_N7wdp-Ed-ak6NoX_4Aeg_-2001716259")]
[Description(@"Specifies the type of securities balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
public enum SecuritiesBalanceType10Code
{
    /// <summary>
    /// Balance of money or securities that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;AVLB&quot;.
    /// </summary>
    [EnumMember(Value = "AVLB")]
    [IsoId("_Y_N7wtp-Ed-ak6NoX_4Aeg_-2001716249")]
    [Description(@"Balance of money or securities that is at the disposal of the account owner on the date specified.")]
    Available = BalanceTypeCode.Available, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the &quot;escrow balance&quot; or &quot;sequestered balance&quot;.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_Y_N7w9p-Ed-ak6NoX_4Aeg_-2001716229")]
    [Description(@"Balance of cash that may only be used under certain conditions.||Balance type is used to block securities/cash in the client account e.g., in relation to elections relating to certain corporate actions. The holding is under the direct control of the system paying agent, who us the only one who can transfer securities out of this balance type.|Also known as the ""escrow balance"" or ""sequestered balance"".")]
    Restricted = BalanceTypeCode.Restricted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of financial instruments that are reserved for the distribution of the proceeds.
    /// Encoded/decoded by serializers as &quot;RDIS&quot;.
    /// </summary>
    [EnumMember(Value = "RDIS")]
    [IsoId("_Y_N7xNp-Ed-ak6NoX_4Aeg_-2001716228")]
    [Description(@"Balance of financial instruments that are reserved for the distribution of the proceeds.")]
    ReservedForDistribution = BalanceTypeCode.ReservedForDistribution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.
    /// Encoded/decoded by serializers as &quot;RREM&quot;.
    /// </summary>
    [EnumMember(Value = "RREM")]
    [IsoId("_Y_N7xdp-Ed-ak6NoX_4Aeg_-2001715950")]
    [Description(@"Balance of securities which are reserved temporarily in the SPA account before they will effectively be exchanged.")]
    ReservedForRemoval = BalanceTypeCode.ReservedForRemoval, // same ordinal as derivation source for type conversions
    
}
