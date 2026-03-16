// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zkxf4tp-Ed-ak6NoX_4Aeg_-699938374")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason2Code
{
    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_Zkxf49p-Ed-ak6NoX_4Aeg_-438583092")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference = RejectionReasonCode.InvalidReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer or Registrar has rejected the instruction.
    /// Encoded/decoded by serializers as &quot;RBIS&quot;.
    /// </summary>
    [EnumMember(Value = "RBIS")]
    [IsoId("_Zkxf5Np-Ed-ak6NoX_4Aeg_-413646475")]
    [Description(@"Issuer or Registrar has rejected the instruction.")]
    RejectedByIssuerOrRegistrar = RejectionReasonCode.RejectedByIssuerOrRegistrar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_Zkxf5dp-Ed-ak6NoX_4Aeg_-354541132")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonCode.InstructionIrrevocable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_Zkxf5tp-Ed-ak6NoX_4Aeg_-325913625")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_Zkxf59p-Ed-ak6NoX_4Aeg_-43315191")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_Zkxf6Np-Ed-ak6NoX_4Aeg_-13761369")]
    [Description(
        @"Cancellation request was rejected since the instruction has already been cancelled."
    )]
    RejectedSinceAlreadyCancelled = RejectionReasonCode.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_Zkxf6dp-Ed-ak6NoX_4Aeg_4708938")]
    [Description(
        @"Cancellation request has been rejected because the instruction process is in progress or has been processed."
    )]
    RejectedSinceInProgress = RejectionReasonCode.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
}
