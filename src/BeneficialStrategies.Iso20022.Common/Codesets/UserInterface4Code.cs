// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Destination of the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xKxc4IO_EeSWSLYdc10LRg")]
[Description(@"Destination of the message.")]
[DerivedFrom(typeof(UserInterfaceCode))]
public enum UserInterface4Code
{
    /// <summary>
    /// Cardholder display or interface.
    /// Encoded/decoded by serializers as &quot;CDSP&quot;.
    /// </summary>
    [EnumMember(Value = "CDSP")]
    [IsoId("_y9Xb4YO_EeSWSLYdc10LRg")]
    [Description(@"Cardholder display or interface.")]
    CardholderDisplay = UserInterfaceCode.CardholderDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder receipt.
    /// Encoded/decoded by serializers as &quot;CRCP&quot;.
    /// </summary>
    [EnumMember(Value = "CRCP")]
    [IsoId("_zakVQYO_EeSWSLYdc10LRg")]
    [Description(@"Cardholder receipt.")]
    CardholderReceipt = UserInterfaceCode.CardholderReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant display or interface.
    /// Encoded/decoded by serializers as &quot;MDSP&quot;.
    /// </summary>
    [EnumMember(Value = "MDSP")]
    [IsoId("_zpBoAYO_EeSWSLYdc10LRg")]
    [Description(@"Merchant display or interface.")]
    MerchantDisplay = UserInterfaceCode.MerchantDisplay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant receipt.
    /// Encoded/decoded by serializers as &quot;MRCP&quot;.
    /// </summary>
    [EnumMember(Value = "MRCP")]
    [IsoId("_zwx10YO_EeSWSLYdc10LRg")]
    [Description(@"Merchant receipt.")]
    MerchantReceipt = UserInterfaceCode.MerchantReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other interface of the cardholder, for instance e-mail or smartphone message.
    /// Encoded/decoded by serializers as &quot;CRDO&quot;.
    /// </summary>
    [EnumMember(Value = "CRDO")]
    [IsoId("_0DQF4YO_EeSWSLYdc10LRg")]
    [Description(@"Other interface of the cardholder, for instance e-mail or smartphone message.")]
    OtherCardholderInterface = UserInterfaceCode.OtherCardholderInterface, // same ordinal as derivation source for type conversions
    
}
