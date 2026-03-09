// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_I0b5MOzkEeSBf_ghFpb9rQ")]
[Description(@"Side taken by a party on an order.")]
[DerivedFrom(typeof(SideCode))]
public enum Side5Code
{
    /// <summary>
    /// An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick.
    /// Encoded/decoded by serializers as &quot;SESH&quot;.
    /// </summary>
    [EnumMember(Value = "SESH")]
    [IsoId("_J93mcezkEeSBf_ghFpb9rQ")]
    [Description(@"An order to sell a security that the seller does not own; a sale effected by delivering a security borrowed by, or for the account of, the seller. Can only be executed on a plus or zero plus tick.")]
    SellShort = SideCode.SellShort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order is sell driven.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_KGQtcezkEeSBf_ghFpb9rQ")]
    [Description(@"Order is sell driven.")]
    Sell = SideCode.Sell, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Short sale exempt from short-sale rules.
    /// Encoded/decoded by serializers as &quot;SSEX&quot;.
    /// </summary>
    [EnumMember(Value = "SSEX")]
    [IsoId("_Kaep8ezkEeSBf_ghFpb9rQ")]
    [Description(@"Short sale exempt from short-sale rules.")]
    SellShortExempt = SideCode.SellShortExempt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The side of the indication of interest is not disclosed.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_KA-CwaiqEeWRLJcxVQAwmw")]
    [Description(@"The side of the indication of interest is not disclosed.")]
    Undisclosed = SideCode.Undisclosed, // same ordinal as derivation source for type conversions
    
}
