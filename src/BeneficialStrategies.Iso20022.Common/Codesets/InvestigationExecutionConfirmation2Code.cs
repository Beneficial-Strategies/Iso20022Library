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
[IsoId("_aa3aZ9p-Ed-ak6NoX_4Aeg_-904367584")]
[Description(@"Indicates the result of an investigation.")]
[DerivedFrom(typeof(InvestigationExecutionConfirmationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InvestigationExecutionConfirmation2Code>))]
#endif
public enum InvestigationExecutionConfirmation2Code
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_abAkUNp-Ed-ak6NoX_4Aeg_-904367506")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest = InvestigationExecutionConfirmationCode.CancelledAsPerRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_abAkUdp-Ed-ak6NoX_4Aeg_-904367489")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest = InvestigationExecutionConfirmationCode.ModifiedAsPerRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_abAkUtp-Ed-ak6NoX_4Aeg_-904367212")]
    [Description(
        @"Used when the result of an investigation is, or will be, the initiation of a payment instruction."
    )]
    PaymentInitiated = InvestigationExecutionConfirmationCode.PaymentInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;ICOV&quot;.
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_abAkU9p-Ed-ak6NoX_4Aeg_-904367187")]
    [Description(
        @"Used when a transfer of funds has been initiated (a cover payment) to resolve a case."
    )]
    CoverInitiated = InvestigationExecutionConfirmationCode.CoverInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;MCOV&quot;.
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_abAkVNp-Ed-ak6NoX_4Aeg_-904367170")]
    [Description(
        @"Used when a transfer of funds has been modified (a cover payment) to resolve a case."
    )]
    CoverModified = InvestigationExecutionConfirmationCode.CoverModified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_abAkVdp-Ed-ak6NoX_4Aeg_-904367151")]
    [Description(
        @"Used when additional information has been sent to the beneficiary of a payment."
    )]
    AdditionalInformationSent = InvestigationExecutionConfirmationCode.AdditionalInformationSent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_abAkVtp-Ed-ak6NoX_4Aeg_-904367135")]
    [Description(
        @"Used when a payment has been checked and was correctly executed without any intervention."
    )]
    ConfirmationOfPayment = InvestigationExecutionConfirmationCode.ConfirmationOfPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;CWFW&quot;.
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_abAkV9p-Ed-ak6NoX_4Aeg_-904367092")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow = InvestigationExecutionConfirmationCode.CancellationWillFollow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;MWFW&quot;.
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_abAkWNp-Ed-ak6NoX_4Aeg_-904367091")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow = InvestigationExecutionConfirmationCode.ModificationWillFollow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as &quot;UWFW&quot;.
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_abAkWdp-Ed-ak6NoX_4Aeg_-1265299711")]
    [Description(
        @"Used when sender wants to respond to an assignment with an Unable To Apply workflow."
    )]
    UnableToApplyWillFollow = InvestigationExecutionConfirmationCode.UnableToApplyWillFollow, // same ordinal as derivation source for type conversions
}
