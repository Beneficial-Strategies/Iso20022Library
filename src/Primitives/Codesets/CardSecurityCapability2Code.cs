// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Card security code list.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__QJPkXR4EfC68Y4jZPNEug")]
[Description(@"Card security code list.")]
[DerivedFrom(typeof(CardSecurityCapabilityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardSecurityCapability2Code>))]
public enum CardSecurityCapability2Code
{
    /// <summary>
    /// Card contains an integrated circuit card.
    /// Encoded/decoded by serializers as &quot;ICCD&quot;.
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("__SyT4XR4EfC68Y4jZPNEug")]
    [Description(@"Card contains an integrated circuit card.")]
    ICC = CardSecurityCapabilityCode.ICC,

    /// <summary>
    /// Card does not contain a card security code in the magstripe
    /// Encoded/decoded by serializers as &quot;MWOS&quot;.
    /// </summary>
    [EnumMember(Value = "MWOS")]
    [IsoId("__SyT43R4EfC68Y4jZPNEug")]
    [Description(@"Card does not contain a card security code in the magstripe")]
    MagneticStripeWithoutSecurityCode = CardSecurityCapabilityCode.MagneticStripeWithoutSecurityCode,

    /// <summary>
    /// Card contains a card security code in the magstripe
    /// Encoded/decoded by serializers as &quot;MSWS&quot;.
    /// </summary>
    [EnumMember(Value = "MSWS")]
    [IsoId("__SyT5XR4EfC68Y4jZPNEug")]
    [Description(@"Card contains a card security code in the magstripe")]
    MagneticStripeWithSecurityCode = CardSecurityCapabilityCode.MagneticStripeWithSecurityCode,

    /// <summary>
    /// Off line PIN card
    /// Encoded/decoded by serializers as &quot;OLPN&quot;.
    /// </summary>
    [EnumMember(Value = "OLPN")]
    [IsoId("__SyT63R4EfC68Y4jZPNEug")]
    [Description(@"Off line PIN card")]
    OffLinePIN = CardSecurityCapabilityCode.OffLinePIN,
}
