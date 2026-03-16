// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies security capabilties of the card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_w7olUJitEeefZKJHxQTztg")]
[Description(@"Identifies security capabilties of the card.")]
[Derivations(typeof(CardSecurityCapability1Code))]
public enum CardSecurityCapabilityCode
{
    /// <summary>
    /// Card contains a card security code in the magstripe
    /// Encoded/decoded by serializers as &quot;MSWS&quot;.
    /// </summary>
    [EnumMember(Value = "MSWS")]
    [IsoId("_5aLe8JitEeefZKJHxQTztg")]
    [Description(@"Card contains a card security code in the magstripe")]
    MagneticStripeWithSecurityCode,

    /// <summary>
    /// Card does not contain a card security code in the magstripe
    /// Encoded/decoded by serializers as &quot;MWOS&quot;.
    /// </summary>
    [EnumMember(Value = "MWOS")]
    [IsoId("_KDR_MJiuEeefZKJHxQTztg")]
    [Description(@"Card does not contain a card security code in the magstripe")]
    MagneticStripeWithoutSecurityCode,

    /// <summary>
    /// Card contains an integrated circuit card.
    /// Encoded/decoded by serializers as &quot;ICCD&quot;.
    /// </summary>
    [EnumMember(Value = "ICCD")]
    [IsoId("_TLtjUJiuEeefZKJHxQTztg")]
    [Description(@"Card contains an integrated circuit card.")]
    ICC,

    /// <summary>
    /// Other type of card defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_hSvIYJiuEeefZKJHxQTztg")]
    [Description(@"Other type of card defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of card defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_nHPdoJiuEeefZKJHxQTztg")]
    [Description(@"Other type of card defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Off line PIN card
    /// Encoded/decoded by serializers as &quot;OLPN&quot;.
    /// </summary>
    [EnumMember(Value = "OLPN")]
    [IsoId("_lrKEsJivEeefZKJHxQTztg")]
    [Description(@"Off line PIN card")]
    OffLinePIN,
}
