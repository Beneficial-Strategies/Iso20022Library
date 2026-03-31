// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transfer or settlement instruction settlement pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VjSAYdp-Ed-ak6NoX_4Aeg_1304044269")]
[Description(
    @"Specifies the reason for a transfer or settlement instruction settlement pending status."
)]
[DerivedFrom(typeof(PendingSettlementStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PendingSettlementStatusReason1Code>))]
#endif
public enum PendingSettlementStatusReason1Code
{
    /// <summary>
    /// Securities have not yet been received from the counterparty.
    /// Encoded/decoded by serializers as &quot;AWSH&quot;.
    /// </summary>
    [EnumMember(Value = "AWSH")]
    [IsoId("_VjSAYtp-Ed-ak6NoX_4Aeg_-938732240")]
    [Description(@"Securities have not yet been received from the counterparty.")]
    AwaitingSharesFromCounterparty =
        PendingSettlementStatusReasonCode.AwaitingSharesFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your account is blocked, no instruction can settle over the account.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_VjSAY9p-Ed-ak6NoX_4Aeg_-912873576")]
    [Description(@"Your account is blocked, no instruction can settle over the account.")]
    AccountBlocked = PendingSettlementStatusReasonCode.AccountBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc.
    /// Encoded/decoded by serializers as &quot;CAIS&quot;.
    /// </summary>
    [EnumMember(Value = "CAIS")]
    [IsoId("_VjSAZNp-Ed-ak6NoX_4Aeg_-911948803")]
    [Description(
        @"Awaiting securities from corporate action issue or other procedures, for example, conversion, dematerialisation, exchange, registration, stamping, splitting, etc."
    )]
    AwaitingSecurities = PendingSettlementStatusReasonCode.AwaitingSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable securities in the counterparty&apos;s account, or counterparty does not hold the securities.
    /// Encoded/decoded by serializers as &quot;CLAC&quot;.
    /// </summary>
    [EnumMember(Value = "CLAC")]
    [IsoId("_VjSAZdp-Ed-ak6NoX_4Aeg_-838990050")]
    [Description(
        @"Insufficient deliverable securities in the counterparty's account, or counterparty does not hold the securities."
    )]
    CounterpartyInsufficientSecurities =
        PendingSettlementStatusReasonCode.CounterpartyInsufficientSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from the counterparty.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_VjSAZtp-Ed-ak6NoX_4Aeg_-764186707")]
    [Description(@"Awaiting documents or endorsements from the counterparty.")]
    AwaitingDocumentsOrEndorsementsFromCounterparty =
        PendingSettlementStatusReasonCode.AwaitingDocumentsOrEndorsementsFromCounterparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Awaiting documents or endorsements from you.
    /// Encoded/decoded by serializers as &quot;DOCY&quot;.
    /// </summary>
    [EnumMember(Value = "DOCY")]
    [IsoId("_VjSAZ9p-Ed-ak6NoX_4Aeg_-512988206")]
    [Description(@"Awaiting documents or endorsements from you.")]
    AwaitingDocumentsOrEndorsementsFromYou =
        PendingSettlementStatusReasonCode.AwaitingDocumentsOrEndorsementsFromYou, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending reason is being investigated.
    /// Encoded/decoded by serializers as &quot;IAAD&quot;.
    /// </summary>
    [EnumMember(Value = "IAAD")]
    [IsoId("_VjSAaNp-Ed-ak6NoX_4Aeg_-466811723")]
    [Description(@"Pending reason is being investigated.")]
    StatusReasonInvestigation = PendingSettlementStatusReasonCode.StatusReasonInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Insufficient deliverable securities in your account.
    /// Encoded/decoded by serializers as &quot;LACK&quot;.
    /// </summary>
    [EnumMember(Value = "LACK")]
    [IsoId("_VjSAadp-Ed-ak6NoX_4Aeg_-426177626")]
    [Description(@"Insufficient deliverable securities in your account.")]
    LackOfSecurities = PendingSettlementStatusReasonCode.LackOfSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Your instruction is pending settlement because the instruction linked to it is pending.
    /// Encoded/decoded by serializers as &quot;LINK&quot;.
    /// </summary>
    [EnumMember(Value = "LINK")]
    [IsoId("_VjbKUNp-Ed-ak6NoX_4Aeg_-397547233")]
    [Description(
        @"Your instruction is pending settlement because the instruction linked to it is pending."
    )]
    PendingLinkedInstruction = PendingSettlementStatusReasonCode.PendingLinkedInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another settlement pending reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VjbKUdp-Ed-ak6NoX_4Aeg_-52149357")]
    [Description(@"Another settlement pending reason.")]
    Other = PendingSettlementStatusReasonCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Physical shares have been received and are being checked for authenticity.
    /// Encoded/decoded by serializers as &quot;PHCK&quot;.
    /// </summary>
    [EnumMember(Value = "PHCK")]
    [IsoId("_VjbKUtp-Ed-ak6NoX_4Aeg_-40145471")]
    [Description(@"Physical shares have been received and are being checked for authenticity.")]
    PhysicalSecuritiesVerification =
        PendingSettlementStatusReasonCode.PhysicalSecuritiesVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is physical and securities are being delivered.
    /// Encoded/decoded by serializers as &quot;PHSE&quot;.
    /// </summary>
    [EnumMember(Value = "PHSE")]
    [IsoId("_VjbKU9p-Ed-ak6NoX_4Aeg_8803575")]
    [Description(@"Settlement is physical and securities are being delivered.")]
    PhysicalDeliveryDelay = PendingSettlementStatusReasonCode.PhysicalDeliveryDelay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment.
    /// Encoded/decoded by serializers as &quot;SBLO&quot;.
    /// </summary>
    [EnumMember(Value = "SBLO")]
    [IsoId("_VjbKVNp-Ed-ak6NoX_4Aeg_77141633")]
    [Description(
        @"Settlement is pending. The securities are blocked due to, for example, a corporate action event, re-alignment."
    )]
    SecuritiesBlocked = PendingSettlementStatusReasonCode.SecuritiesBlocked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information, for example, telephone number, contact person, is missing.
    /// Encoded/decoded by serializers as &quot;MINF&quot;.
    /// </summary>
    [EnumMember(Value = "MINF")]
    [IsoId("_VjbKVdp-Ed-ak6NoX_4Aeg_95611060")]
    [Description(@"Information, for example, telephone number, contact person, is missing.")]
    MissingInformation = PendingSettlementStatusReasonCode.MissingInformation, // same ordinal as derivation source for type conversions
}
