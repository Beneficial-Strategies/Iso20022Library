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
[IsoId("_agVCUEk0Ee2pGuIgvBXIzg")]
[Description(
    @"Specifies the investigation type, as published in an external investigation type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationTypeCode>))]
public enum ExternalInvestigationTypeCode
{
    /// <summary>
    /// Investigation relating to an account.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("__-YKL9YUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to an account.")]
    AccountRelatedInvestigation,

    /// <summary>
    /// Creditor claims non-receipt of payment.
    /// Encoded/decoded by serializers as &quot;CCNR&quot;.
    /// </summary>
    [EnumMember(Value = "CCNR")]
    [IsoId("__-YKKNYUEe68t8Cw380-tA")]
    [Description(@"Creditor claims non-receipt of payment.")]
    CreditorClaimNonReceipt,

    /// <summary>
    /// Creditor agent claims non-receipt of cover or settlement.
    /// Encoded/decoded by serializers as &quot;CONR&quot;.
    /// </summary>
    [EnumMember(Value = "CONR")]
    [IsoId("__-YKKdYUEe68t8Cw380-tA")]
    [Description(@"Creditor agent claims non-receipt of cover or settlement.")]
    CreditorAgentClaimCoverNonReceipt,

    /// <summary>
    /// Other request type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__-YKMtYUEe68t8Cw380-tA")]
    [Description(@"Other request type.")]
    Other,

    /// <summary>
    /// Payment initiation has not been settled or confirmed.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("__-YKK9YUEe68t8Cw380-tA")]
    [Description(@"Payment initiation has not been settled or confirmed.")]
    PaymentInitiationNotConfirmed,

    /// <summary>
    /// Request from International Monetary Fund.
    /// Encoded/decoded by serializers as &quot;RIMF&quot;.
    /// </summary>
    [EnumMember(Value = "RIMF")]
    [IsoId("__-YKMdYUEe68t8Cw380-tA")]
    [Description(@"Request from International Monetary Fund.")]
    RequestFromIMF,

    /// <summary>
    /// Investigation relating to charges that have been taken or are requested.
    /// Encoded/decoded by serializers as &quot;RQCH&quot;.
    /// </summary>
    [EnumMember(Value = "RQCH")]
    [IsoId("__-YKMNYUEe68t8Cw380-tA")]
    [Description(@"Investigation relating to charges that have been taken or are requested.")]
    RequestRelatedToCharges,

    /// <summary>
    /// Debit authorisation on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("__-YKLtYUEe68t8Cw380-tA")]
    [Description(@"Debit authorisation on an entry is requested.")]
    RequestDebitAuthorisation,

    /// <summary>
    /// Further information is required on a payment, entry, message or instruction.
    /// Encoded/decoded by serializers as &quot;RQFI&quot;.
    /// </summary>
    [EnumMember(Value = "RQFI")]
    [IsoId("__-YKKtYUEe68t8Cw380-tA")]
    [Description(@"Further information is required on a payment, entry, message or instruction.")]
    RequestForInformation,

    /// <summary>
    /// Use of funds on an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQUF&quot;.
    /// </summary>
    [EnumMember(Value = "RQUF")]
    [IsoId("__-YKLdYUEe68t8Cw380-tA")]
    [Description(@"Use of funds on an entry is requested.")]
    RequestUseOfFunds,

    /// <summary>
    /// Revaluation of an entry is requested.
    /// Encoded/decoded by serializers as &quot;RQVA&quot;.
    /// </summary>
    [EnumMember(Value = "RQVA")]
    [IsoId("__-YKLNYUEe68t8Cw380-tA")]
    [Description(@"Revaluation of an entry is requested.")]
    RequestValueDateAdjustment,

    /// <summary>
    /// A booked entry cannot be applied by the creditor.
    /// Encoded/decoded by serializers as &quot;UTAP&quot;.
    /// </summary>
    [EnumMember(Value = "UTAP")]
    [IsoId("__-YKJ9YUEe68t8Cw380-tA")]
    [Description(@"A booked entry cannot be applied by the creditor.")]
    UnableToApplyByCreditor,
}
