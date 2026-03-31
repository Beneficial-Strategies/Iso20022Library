// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of identified entity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oci7cIn0EeS9F4Qrq_eaVA")]
[Description(@"Type of identified entity.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType12Code>))]
#endif
public enum PartyType12Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_rAuvcYn0EeS9F4Qrq_eaVA")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity managing the ATM.
    /// Encoded/decoded by serializers as &quot;ATMG&quot;.
    /// </summary>
    [EnumMember(Value = "ATMG")]
    [IsoId("_rM8mg4n0EeS9F4Qrq_eaVA")]
    [Description(@"Entity managing the ATM.")]
    ATMManager = PartyTypeCode.ATMManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as &quot;CISP&quot;.
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_r0egk4n0EeS9F4Qrq_eaVA")]
    [Description(
        @"Entity providing issuing card payment processing services on behalf on an issuer."
    )]
    CardIssuerProcessor = PartyTypeCode.CardIssuerProcessor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_sAb484n0EeS9F4Qrq_eaVA")]
    [Description(
        @"Party to whom the card issuer delegates to authorise card payment transactions."
    )]
    DelegateIssuer = PartyTypeCode.DelegateIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity hosting the ATM.
    /// Encoded/decoded by serializers as &quot;HSTG&quot;.
    /// </summary>
    [EnumMember(Value = "HSTG")]
    [IsoId("_s-0Mw4n0EeS9F4Qrq_eaVA")]
    [Description(@"Entity hosting the ATM.")]
    HostingEntity = PartyTypeCode.HostingEntity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_tIgUQ4n0EeS9F4Qrq_eaVA")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM initiating the transaction.
    /// Encoded/decoded by serializers as &quot;OATM&quot;.
    /// </summary>
    [EnumMember(Value = "OATM")]
    [IsoId("_t-Q3k4n0EeS9F4Qrq_eaVA")]
    [Description(@"ATM initiating the transaction.")]
    OriginatingATM = PartyTypeCode.OriginatingATM, // same ordinal as derivation source for type conversions
}
