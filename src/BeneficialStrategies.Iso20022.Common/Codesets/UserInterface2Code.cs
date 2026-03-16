// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of interface to display a message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUmCEgEcEeCQm6a_G2yO_w_-457047932")]
[Description(@"Type of interface to display a message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface2Code
{
    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as &quot;MDSP&quot;.
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_TUmCEwEcEeCQm6a_G2yO_w_-1877868390")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay = UserInterfaceCode.MerchantDisplay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as &quot;CDSP&quot;.
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_TUmCFAEcEeCQm6a_G2yO_w_-44704637")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions
}
