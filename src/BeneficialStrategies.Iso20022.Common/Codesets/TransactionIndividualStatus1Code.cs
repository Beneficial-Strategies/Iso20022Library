// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a single payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yrsi2Np-Ed-ak6NoX_4Aeg_-1851702308")]
[Description(@"Specifies the status of a single payment transaction.")]
[DerivedFrom(typeof(PaymentStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionIndividualStatus1Code>))]
#endif
public enum TransactionIndividualStatus1Code
{
    /// <summary>
    /// Authentication and syntactical and semantical validation are successful.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_Yrsi2dp-Ed-ak6NoX_4Aeg_-1851702290")]
    [Description(@"Authentication and syntactical and semantical validation are successful.")]
    AcceptedTechnicalValidation = PaymentStatusCode.AcceptedTechnicalValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_Yr2T0Np-Ed-ak6NoX_4Aeg_-1851702013")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation has been rejected."
    )]
    Rejected = PaymentStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_Yr2T0dp-Ed-ak6NoX_4Aeg_-1851701978")]
    [Description(
        @"Payment initiation or individual transaction included in the payment initiation is pending.  Further checks and status update will be performed."
    )]
    Pending = PaymentStatusCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preceding check of technical validation was successful. Customer profile check was also successful.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_Yr2T0tp-Ed-ak6NoX_4Aeg_-1851701953")]
    [Description(
        @"Preceding check of technical validation was successful. Customer profile check was also successful."
    )]
    AcceptedCustomerProfile = PaymentStatusCode.AcceptedCustomerProfile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution.
    /// Encoded/decoded by serializers as &quot;ACSP&quot;.
    /// </summary>
    [EnumMember(Value = "ACSP")]
    [IsoId("_Yr2T09p-Ed-ak6NoX_4Aeg_-1851701936")]
    [Description(
        @"All preceding checks such as technical validation and customer profile were successful and therefore the payment initiation has been accepted for execution."
    )]
    AcceptedSettlementInProcess = PaymentStatusCode.AcceptedSettlementInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement on the debtor&apos;s account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement
    /// Encoded/decoded by serializers as &quot;ACSC&quot;.
    /// </summary>
    [EnumMember(Value = "ACSC")]
    [IsoId("_Yr2T1Np-Ed-ak6NoX_4Aeg_-1851701918")]
    [Description(
        @"Settlement on the debtor's account has been completed. ||Usage : this can be used by the first agent to report to the debtor that the transaction has been completed. Warning : this status is provided for transaction status reasons, not for financial information. It can only be used after bilateral agreement"
    )]
    AcceptedSettlementCompleted = PaymentStatusCode.AcceptedSettlementCompleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation is accepted.
    /// Encoded/decoded by serializers as &quot;ACCR&quot;.
    /// </summary>
    [EnumMember(Value = "ACCR")]
    [IsoId("_Yr2T1dp-Ed-ak6NoX_4Aeg_-1478599372")]
    [Description(@"Cancellation is accepted.")]
    AcceptedCancellationRequest = PaymentStatusCode.AcceptedCancellationRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but a change will be made, such as date or remittance not sent.
    /// Encoded/decoded by serializers as &quot;ACWC&quot;.
    /// </summary>
    [EnumMember(Value = "ACWC")]
    [IsoId("_Yr2T1tp-Ed-ak6NoX_4Aeg_-1456435332")]
    [Description(
        @"Instruction is accepted but a change will be made, such as date or remittance not sent."
    )]
    AcceptedWithChange = PaymentStatusCode.AcceptedWithChange, // same ordinal as derivation source for type conversions
}
