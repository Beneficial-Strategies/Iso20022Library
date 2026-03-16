// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__SMwITQWEe2o-K1dwNg8Gg")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason79Code
{
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("__tK04TQWEe2o-K1dwNg8Gg")]
    [Description(
        @"Transaction/instruction received after the account servicer's specified deadline."
    )]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("__tK04zQWEe2o-K1dwNg8Gg")]
    [Description(@"Instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonV3Code.InstructionIrrevocable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("__tK05TQWEe2o-K1dwNg8Gg")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("__tK05zQWEe2o-K1dwNg8Gg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__tK06TQWEe2o-K1dwNg8Gg")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("__tK06zQWEe2o-K1dwNg8Gg")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled = RejectionReasonV3Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("__tK07TQWEe2o-K1dwNg8Gg")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress = RejectionReasonV3Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction rejected by the issuer agent.
    /// Encoded/decoded by serializers as &quot;REJA&quot;.
    /// </summary>
    [EnumMember(Value = "REJA")]
    [IsoId("__tK07zQWEe2o-K1dwNg8Gg")]
    [Description(@"Instruction rejected by the issuer agent.")]
    RejectedByIssuerAgent = RejectionReasonV3Code.RejectedByIssuerAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contact information is missing.
    /// Encoded/decoded by serializers as &quot;CTCT&quot;.
    /// </summary>
    [EnumMember(Value = "CTCT")]
    [IsoId("_Jk02gTQXEe2o-K1dwNg8Gg")]
    [Description(@"Contact information is missing.")]
    MissingContact = RejectionReasonV3Code.MissingContact, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid financial instrument identification.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_K1S_4jQXEe2o-K1dwNg8Gg")]
    [Description(@"Unrecognised or invalid financial instrument identification.")]
    InvalidSecurity = RejectionReasonV3Code.InvalidSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid instructed quantity.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_MmQAIjQXEe2o-K1dwNg8Gg")]
    [Description(@"Unrecognised or invalid instructed quantity.")]
    QuantityRejection = RejectionReasonV3Code.QuantityRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect date is required for cover protect instructions.
    /// Encoded/decoded by serializers as &quot;PROT&quot;.
    /// </summary>
    [EnumMember(Value = "PROT")]
    [IsoId("_OG894jQXEe2o-K1dwNg8Gg")]
    [Description(@"Protect date is required for cover protect instructions.")]
    MissingProtectDate = RejectionReasonV3Code.MissingProtectDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unrecognised or invalid message sender&apos;s safekeeping account.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_S6EHkTQXEe2o-K1dwNg8Gg")]
    [Description(@"Unrecognised or invalid message sender's safekeeping account.")]
    SafekeepingAccountRejection = RejectionReasonV3Code.SafekeepingAccountRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect identification is required for cover protect instructions.
    /// Encoded/decoded by serializers as &quot;PROI&quot;.
    /// </summary>
    [EnumMember(Value = "PROI")]
    [IsoId("_UX8a0jQXEe2o-K1dwNg8Gg")]
    [Description(@"Protect identification is required for cover protect instructions.")]
    MissingProtectIdentification = RejectionReasonV3Code.MissingProtectIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction type is missing or invalid for protect or cover protect instructions.
    /// Encoded/decoded by serializers as &quot;TRTI&quot;.
    /// </summary>
    [EnumMember(Value = "TRTI")]
    [IsoId("_V1YCIjQXEe2o-K1dwNg8Gg")]
    [Description(
        @"Transaction type is missing or invalid for protect or cover protect instructions."
    )]
    MissingTransactionType = RejectionReasonV3Code.MissingTransactionType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is rejected due to duplicate business message identifier.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_XcDFAjQXEe2o-K1dwNg8Gg")]
    [Description(@"Instruction is rejected due to duplicate business message identifier.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions
}
