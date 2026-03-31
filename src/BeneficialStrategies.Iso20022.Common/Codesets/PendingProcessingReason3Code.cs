// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mzacAlIEeGATtfOBToyew_-1857836071")]
[Description(
    @"Specifies the reason the transaction/instruction is failing settlement. Settlement on the instructed settlement date is no longer possible."
)]
[DerivedFrom(typeof(PendingFailingReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingProcessingReason3Code>))]
#endif
public enum PendingProcessingReason3Code
{
    /// <summary>
    /// Instruction was received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_0mzacQlIEeGATtfOBToyew_-1793556465")]
    [Description(
        @"Instruction was received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = PendingFailingReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_0mzacglIEeGATtfOBToyew_1504338478")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingFailingReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MUNO&quot;.
    /// </summary>
    [EnumMember(Value = "MUNO")]
    [IsoId("_0mzacwlIEeGATtfOBToyew_442986519")]
    [Description(
        @"Quantity instructed is not a multiple of an existing settlement quantity lot for the financial instrument."
    )]
    MultipleSettlementAmount = PendingFailingReasonCode.MultipleSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Next process is launched. No processing pending problems to be reported.
    /// Encoded/decoded by serializers as &quot;NEXT&quot;.
    /// </summary>
    [EnumMember(Value = "NEXT")]
    [IsoId("_0mzadAlIEeGATtfOBToyew_-375967162")]
    [Description(@"Next process is launched. No processing pending problems to be reported.")]
    NextProcess = PendingFailingReasonCode.NextProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument.
    /// Encoded/decoded by serializers as &quot;MINO&quot;.
    /// </summary>
    [EnumMember(Value = "MINO")]
    [IsoId("_0mzadQlIEeGATtfOBToyew_-1373039515")]
    [Description(
        @"Quantity instructed is lower than the minimum existing settlement quantity for the financial instrument."
    )]
    MinimumSettlementAmount = PendingFailingReasonCode.MinimumSettlementAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0m9LcAlIEeGATtfOBToyew_-1664997253")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities.
    /// Encoded/decoded by serializers as &quot;DENO&quot;.
    /// </summary>
    [EnumMember(Value = "DENO")]
    [IsoId("_0m9LcQlIEeGATtfOBToyew_-1486878581")]
    [Description(
        @"Quantity instructed does not match the denomination available/deliverable. Physical securities need to be obtained in deliverable denominated quantities."
    )]
    UnavailableDeliverableDenominatedQuantity =
        PendingFailingReasonCode.UnavailableDeliverableDenominatedQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate number error.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_0m9LcglIEeGATtfOBToyew_1924855428")]
    [Description(@"Certificate number error.")]
    WrongCertificatesNumbers = PendingFailingReasonCode.WrongCertificatesNumbers, // same ordinal as derivation source for type conversions
}
