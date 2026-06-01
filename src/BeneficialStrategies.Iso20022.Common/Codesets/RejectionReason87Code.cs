// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o1t24d78Ee-NrtAAlrBEgQ")]
[Description(@"Specifies the reason why the instruction request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RejectionReason87Code>))]
public enum RejectionReason87Code
{
    /// <summary>
    /// Counterparty disagreement on the chosen corporate action outturn.
    /// Encoded/decoded by serializers as &quot;BUMM&quot;.
    /// </summary>
    [EnumMember(Value = "BUMM")]
    [IsoId("_TsIawd8MEe-NrtAAlrBEgQ")]
    [Description(@"Counterparty disagreement on the chosen corporate action outturn.")]
    BuyerProtectionMismatch = RejectionReasonV3Code.BuyerProtectionMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_o6Ic5d78Ee-NrtAAlrBEgQ")]
    [Description(@"Option is not valid; it has been cancelled by the market or service provider, and cannot be responded to. Any responses already processed against this option are considered void and new responses will be required.")]
    OptionCancelled = RejectionReasonV3Code.OptionCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_3UIkEd8DEe-NrtAAlrBEgQ")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonV3Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid instructed currency.
    /// Encoded/decoded by serializers as &quot;DQCC&quot;.
    /// </summary>
    [EnumMember(Value = "DQCC")]
    [IsoId("_o6Ic9978Ee-NrtAAlrBEgQ")]
    [Description(@"Invalid instructed currency.")]
    CurrencyRejection = RejectionReasonV3Code.CurrencyRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_o6Ic2978Ee-NrtAAlrBEgQ")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was denied because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;DSET&quot;.
    /// </summary>
    [EnumMember(Value = "DSET")]
    [IsoId("_Nuefod8DEe-NrtAAlrBEgQ")]
    [Description(@"Cancellation request was denied because the instruction was already settled.")]
    DeniedSinceAlreadySettled = RejectionReasonV3Code.DeniedSinceAlreadySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying transaction type/status does not allow for a buyer protection.
    /// Encoded/decoded by serializers as &quot;DSNA&quot;.
    /// </summary>
    [EnumMember(Value = "DSNA")]
    [IsoId("_vrP60TPsEfCIZLORDJsr-g")]
    [Description(@"Underlying transaction type/status does not allow for a buyer protection.")]
    NoBuyerProtectionAllowed = RejectionReasonV3Code.NoBuyerProtectionAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buyer Protection instruction rejected since underlying settlement transaction has been cancelled.
    /// Encoded/decoded by serializers as &quot;DUCK&quot;.
    /// </summary>
    [EnumMember(Value = "DUCK")]
    [IsoId("_uLVnQTPsEfCIZLORDJsr-g")]
    [Description(@"Buyer Protection instruction rejected since underlying settlement transaction has been cancelled.")]
    UnderlyingTransactionCancelled = RejectionReasonV3Code.UnderlyingTransactionCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_o6IdD978Ee-NrtAAlrBEgQ")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Buyer Protection instruction was rejected, because the underlying settlement transaction has already been settled.
    /// Encoded/decoded by serializers as &quot;DUST&quot;.
    /// </summary>
    [EnumMember(Value = "DUST")]
    [IsoId("_uTKGgTPsEfCIZLORDJsr-g")]
    [Description(@"Buyer Protection instruction was rejected, because the underlying settlement transaction has already been settled.")]
    UnderlyingTransactionAlreadySettled = RejectionReasonV3Code.UnderlyingTransactionAlreadySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the election to counterparty market deadline.
    /// Encoded/decoded by serializers as &quot;ECMD&quot;.
    /// </summary>
    [EnumMember(Value = "ECMD")]
    [IsoId("_7GGaURXsEfCxL6UOgkdrJg")]
    [Description(@"Received after the election to counterparty market deadline.")]
    ElectionToCounterpartyMarketDeadlineMissed = RejectionReasonV3Code.ElectionToCounterpartyMarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the election to counterparty response market deadline.
    /// Encoded/decoded by serializers as &quot;ECRD&quot;.
    /// </summary>
    [EnumMember(Value = "ECRD")]
    [IsoId("_7MpuQRXsEfCxL6UOgkdrJg")]
    [Description(@"Received after the election to counterparty response market deadline.")]
    ElectionToCounterpartyResponseDeadlineMissed = RejectionReasonV3Code.ElectionToCounterpartyResponseDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised event number.
    /// Encoded/decoded by serializers as &quot;EVNM&quot;.
    /// </summary>
    [EnumMember(Value = "EVNM")]
    [IsoId("_o6Ic8978Ee-NrtAAlrBEgQ")]
    [Description(@"Unrecognised event number.")]
    UnrecognisedIdentification = RejectionReasonV3Code.UnrecognisedIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.
    /// Encoded/decoded by serializers as &quot;INTV&quot;.
    /// </summary>
    [EnumMember(Value = "INTV")]
    [IsoId("_o6Ic5978Ee-NrtAAlrBEgQ")]
    [Description(@"Option is not active and can no longer be responded to. Any responses already processed against this option will remain valid, for example, expired option.")]
    OptionInactive = RejectionReasonV3Code.OptionInactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_o6Ic3978Ee-NrtAAlrBEgQ")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mismatch between option number and option type.
    /// Encoded/decoded by serializers as &quot;NMTY&quot;.
    /// </summary>
    [EnumMember(Value = "NMTY")]
    [IsoId("_o6Ic4d78Ee-NrtAAlrBEgQ")]
    [Description(@"Mismatch between option number and option type.")]
    Mismatch = RejectionReasonV3Code.Mismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised option number.
    /// Encoded/decoded by serializers as &quot;OPNM&quot;.
    /// </summary>
    [EnumMember(Value = "OPNM")]
    [IsoId("_o6Ic6d78Ee-NrtAAlrBEgQ")]
    [Description(@"Unrecognised option number.")]
    OptionNumberRejection = RejectionReasonV3Code.OptionNumberRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid option type.
    /// Encoded/decoded by serializers as &quot;OPTY&quot;.
    /// </summary>
    [EnumMember(Value = "OPTY")]
    [IsoId("_o6Ic1978Ee-NrtAAlrBEgQ")]
    [Description(@"Invalid option type.")]
    InvalidOptionType = RejectionReasonV3Code.InvalidOptionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_o6Ic6978Ee-NrtAAlrBEgQ")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction type is incorrect.
    /// Encoded/decoded by serializers as &quot;TRTY&quot;.
    /// </summary>
    [EnumMember(Value = "TRTY")]
    [IsoId("_gVS0Ud8EEe-NrtAAlrBEgQ")]
    [Description(@"Transaction type is incorrect.")]
    IncorrectTransactionType = RejectionReasonV3Code.IncorrectTransactionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_o6Ic2d78Ee-NrtAAlrBEgQ")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
}
