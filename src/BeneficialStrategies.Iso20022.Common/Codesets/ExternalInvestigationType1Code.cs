// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation type, as published in an external investigation type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yrXOgFB9Ee2JFb6fZWHubw")]
[Description(
    @"Specifies the investigation type, as published in an external investigation type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationType1Code>))]
public enum ExternalInvestigationType1Code
{
    /// <summary>
    /// Investigation relating to an account.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_8Mu8IRFsEfG0NpnTSh0Zcg")]
    [Description(@"Investigation relating to an account.")]
    AccountRelatedInvestigation = ExternalInvestigationTypeCode.AccountRelatedInvestigation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor claims non-receipt of payment.
    /// Encoded/decoded by serializers as &quot;CCNR&quot;.
    /// </summary>
    [EnumMember(Value = "CCNR")]
    [IsoId("_8Mr40RFsEfG0NpnTSh0Zcg")]
    [Description(@"Creditor claims non-receipt of payment.")]
    CreditorClaimNonReceipt = ExternalInvestigationTypeCode.CreditorClaimNonReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor agent claims non-receipt of cover or settlement.
    /// Encoded/decoded by serializers as &quot;CONR&quot;.
    /// </summary>
    [EnumMember(Value = "CONR")]
    [IsoId("_8Mr40xFsEfG0NpnTSh0Zcg")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    CreditorAgentClaimCoverNonReceipt = ExternalInvestigationTypeCode.CreditorAgentClaimCoverNonReceipt, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other request type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_8MxYYRFsEfG0NpnTSh0Zcg")]
    [Description(@"Other request type.")]
    Other = ExternalInvestigationTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment initiation has not been settled or confirmed.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_8Msf4xFsEfG0NpnTSh0Zcg")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    PaymentInitiationNotConfirmed = ExternalInvestigationTypeCode.PaymentInitiationNotConfirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request from International Monetary Fund.
    /// Encoded/decoded by serializers as &quot;RIMF&quot;.
    /// </summary>
    [EnumMember(Value = "RIMF")]
    [IsoId("_8MwxURFsEfG0NpnTSh0Zcg")]
    [Description(@"Request from International Monetary Fund.")]
    RequestFromIMF = ExternalInvestigationTypeCode.RequestFromIMF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investigation relating to charges that have been taken or are requested.
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("_8MwKQRFsEfG0NpnTSh0Zcg")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    RequestRelatedToCharges = ExternalInvestigationTypeCode.RequestRelatedToCharges, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit authorisation on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_8MuVERFsEfG0NpnTSh0Zcg")]
    [Description(@"Debit authorisation on an entry is requested.")]
    RequestDebitAuthorisation = ExternalInvestigationTypeCode.RequestDebitAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information is required on a payment, entry, message or instruction.
    /// Encoded/decoded by serializers as &quot;RQFI&quot;.
    /// </summary>
    [EnumMember(Value = "RQFI")]
    [IsoId("_8Msf4RFsEfG0NpnTSh0Zcg")]
    [Description(@"Further information is required on a payment, entry, message or instruction.")]
    RequestForInformation = ExternalInvestigationTypeCode.RequestForInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Use of funds on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQUF&quot;.
    /// </summary>
    [EnumMember(Value = "RQUF")]
    [IsoId("_8MtG8xFsEfG0NpnTSh0Zcg")]
    [Description(@"Use of funds on an entry is requested.")]
    RequestUseOfFunds = ExternalInvestigationTypeCode.RequestUseOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Revaluation of an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQVA&quot;.
    /// </summary>
    [EnumMember(Value = "RQVA")]
    [IsoId("_8MtG8RFsEfG0NpnTSh0Zcg")]
    [Description(@"Revaluation of an entry is requested.")]
    RequestValueDateAdjustment = ExternalInvestigationTypeCode.RequestValueDateAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A booked entry cannot be applied by the creditor.
    /// Encoded/decoded by serializers as &quot;UTAP&quot;.
    /// </summary>
    [EnumMember(Value = "UTAP")]
    [IsoId("_8MrRwRFsEfG0NpnTSh0Zcg")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    UnableToApplyByCreditor = ExternalInvestigationTypeCode.UnableToApplyByCreditor, // same ordinal as derivation source for type conversions
}
