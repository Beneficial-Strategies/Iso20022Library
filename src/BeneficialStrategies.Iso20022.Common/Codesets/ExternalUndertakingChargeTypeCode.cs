// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external charge type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKAG7iEeKo25nLKvGr8w_264081623")]
[Description(
    @"Specifies the external charge type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalUndertakingChargeType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalUndertakingChargeTypeCode>))]
#endif
public enum ExternalUndertakingChargeTypeCode
{
    /// <summary>
    /// Charge related to the issuance of an amendment.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_uQ7a8_RYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the issuance of an amendment.")]
    Amendment,

    /// <summary>
    /// Charge related to the processing of a claim.
    /// Encoded/decoded by serializers as &quot;CLAM&quot;.
    /// </summary>
    [EnumMember(Value = "CLAM")]
    [IsoId("_uQ7a9vRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the processing of a claim.")]
    Claim,

    /// <summary>
    /// Commission charge.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uQ7a-fRYEeuLhpyIdtJzwg")]
    [Description(@"Commission charge.")]
    Commission,

    /// <summary>
    /// Charge for confirmation.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uREk4PRYEeuLhpyIdtJzwg")]
    [Description(@"Charge for confirmation.")]
    Confirmation,

    /// <summary>
    /// Courier charge.
    /// Encoded/decoded by serializers as &quot;COUR&quot;.
    /// </summary>
    [EnumMember(Value = "COUR")]
    [IsoId("_uREk4_RYEeuLhpyIdtJzwg")]
    [Description(@"Courier charge.")]
    Courier,

    /// <summary>
    /// Charge related to the issuance of an undertaking.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uROV4PRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the issuance of an undertaking.")]
    IssuanceCharge,

    /// <summary>
    /// Miscellaneous charge.
    /// Encoded/decoded by serializers as &quot;MISC&quot;.
    /// </summary>
    [EnumMember(Value = "MISC")]
    [IsoId("_uROV4_RYEeuLhpyIdtJzwg")]
    [Description(@"Miscellaneous charge.")]
    Miscellaneous,

    /// <summary>
    /// Charge related to the payment processing.
    /// Encoded/decoded by serializers as &quot;PAYM&quot;.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_uROV5vRYEeuLhpyIdtJzwg")]
    [Description(@"Charge related to the payment processing.")]
    Payment,

    /// <summary>
    /// Postage charge.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uROV6fRYEeuLhpyIdtJzwg")]
    [Description(@"Postage charge.")]
    Postage,

    /// <summary>
    /// Telecommunication charge.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_uROV7PRYEeuLhpyIdtJzwg")]
    [Description(@"Telecommunication charge.")]
    Telecommunication,
}
