// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the result of an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VnJzxtp-Ed-ak6NoX_4Aeg_804338895")]
[Description(@"Indicates the result of an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestigationExecutionConfirmation1Code>))]
#endif
public enum InvestigationExecutionConfirmation1Code
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_VnJzx9p-Ed-ak6NoX_4Aeg_-2046947598")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest = InvestigationExecutionConfirmationCode.CancelledAsPerRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_VnTkwNp-Ed-ak6NoX_4Aeg_707009024")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest = InvestigationExecutionConfirmationCode.ModifiedAsPerRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as &quot;ACDA&quot;.
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_VnTkwdp-Ed-ak6NoX_4Aeg_-339444773")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation = InvestigationExecutionConfirmationCode.AcceptedDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_VnTkwtp-Ed-ak6NoX_4Aeg_873569556")]
    [Description(
        @"Used when the result of an investigation is, or will be, the initiation of a payment instruction."
    )]
    PaymentInitiated = InvestigationExecutionConfirmationCode.PaymentInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;ICOV&quot;.
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_VnTkw9p-Ed-ak6NoX_4Aeg_1763240392")]
    [Description(
        @"Used when a transfer of funds has been initiated (a cover payment) to resolve a case."
    )]
    CoverInitiated = InvestigationExecutionConfirmationCode.CoverInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;MCOV&quot;.
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_VnTkxNp-Ed-ak6NoX_4Aeg_306413424")]
    [Description(
        @"Used when a transfer of funds has been modified (a cover payment) to resolve a case."
    )]
    CoverModified = InvestigationExecutionConfirmationCode.CoverModified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as &quot;IPYI&quot;.
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_VnTkxdp-Ed-ak6NoX_4Aeg_-2074584448")]
    [Description(
        @"Used when a payment instruction (eg. MT103) has been initiated to resolve a case."
    )]
    PaymentInstructionInitiated =
        InvestigationExecutionConfirmationCode.PaymentInstructionInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_VnTkxtp-Ed-ak6NoX_4Aeg_1186128186")]
    [Description(
        @"Used when additional information has been sent to the beneficiary of a payment."
    )]
    AdditionalInformationSent = InvestigationExecutionConfirmationCode.AdditionalInformationSent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_VncusNp-Ed-ak6NoX_4Aeg_-1993347823")]
    [Description(
        @"Used when a payment has been checked and was correctly executed without any intervention."
    )]
    ConfirmationOfPayment = InvestigationExecutionConfirmationCode.ConfirmationOfPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;CWFW&quot;.
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_Vncusdp-Ed-ak6NoX_4Aeg_1747345458")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow = InvestigationExecutionConfirmationCode.CancellationWillFollow, // same ordinal as derivation source for type conversions
}
