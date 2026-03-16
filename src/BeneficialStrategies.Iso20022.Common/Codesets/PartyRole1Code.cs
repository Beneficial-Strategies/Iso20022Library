// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of the party in the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xiDWkCDSEeWCLu74WLgP4w")]
[Description(@"Specifies the role of the party in the transaction.")]
[DerivedFrom(typeof(PartyRoleCode))]
public enum PartyRole1Code
{
    /// <summary>
    /// Party that safekeeps and administers assets on behalf of the owner.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_zsaVUSDSEeWCLu74WLgP4w")]
    [Description(@"Party that safekeeps and administers assets on behalf of the owner.")]
    Custodian = PartyRoleCode.Custodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// Encoded/decoded by serializers as &quot;INVS&quot;.
    /// </summary>
    [EnumMember(Value = "INVS")]
    [IsoId("_0PE9gSDSEeWCLu74WLgP4w")]
    [Description(@"Party, either an individual or organisation, whose assets are being invested.")]
    Investor = PartyRoleCode.Investor, // same ordinal as derivation source for type conversions
}
