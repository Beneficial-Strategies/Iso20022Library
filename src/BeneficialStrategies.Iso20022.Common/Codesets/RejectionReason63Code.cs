// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_momukhIvEeyHZKWo4KVxBw")]
[Description(@"Specifies the reason why a cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason63Code
{
    /// <summary>
    /// Instruction has a reference identical to another previously received instruction.
    /// Encoded/decoded by serializers as &quot;REFE&quot;.
    /// </summary>
    [EnumMember(Value = "REFE")]
    [IsoId("_svdYARIvEeyHZKWo4KVxBw")]
    [Description(@"Instruction has a reference identical to another previously received instruction.")]
    ReferenceRejection = RejectionReasonV3Code.ReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction/instruction received after the account servicer&apos;s specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_svdYAxIvEeyHZKWo4KVxBw")]
    [Description(@"Transaction/instruction received after the account servicer's specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonV3Code.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid client collateral instruction identification.
    /// Encoded/decoded by serializers as &quot;CCIX&quot;.
    /// </summary>
    [EnumMember(Value = "CCIX")]
    [IsoId("_svdYBRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid client collateral instruction identification.")]
    ClientCollateralInstructionIdentification = RejectionReasonV3Code.ClientCollateralInstructionIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid Client Collateral Transaction Identification.
    /// Encoded/decoded by serializers as &quot;CCTI&quot;.
    /// </summary>
    [EnumMember(Value = "CCTI")]
    [IsoId("_svdYBxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid Client Collateral Transaction Identification.")]
    ClientCollateralTransactionIdentification = RejectionReasonV3Code.ClientCollateralTransactionIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised, invalid or missing common reference.
    /// Encoded/decoded by serializers as &quot;IIND&quot;.
    /// </summary>
    [EnumMember(Value = "IIND")]
    [IsoId("_svdYCRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised, invalid or missing common reference.")]
    CommonReferenceRejection = RejectionReasonV3Code.CommonReferenceRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or Invalid Party A.
    /// Encoded/decoded by serializers as &quot;PTYA&quot;.
    /// </summary>
    [EnumMember(Value = "PTYA")]
    [IsoId("_svdYCxIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Party A.")]
    InvalidPartyA = RejectionReasonV3Code.InvalidPartyA, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or Invalid Party B
    /// Encoded/decoded by serializers as &quot;PTYB&quot;.
    /// </summary>
    [EnumMember(Value = "PTYB")]
    [IsoId("_svdYDRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Party B")]
    InvalidPartyB = RejectionReasonV3Code.InvalidPartyB, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_svdYDxIvEeyHZKWo4KVxBw")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or Invalid Triparty Agent
    /// Encoded/decoded by serializers as &quot;ITPA&quot;.
    /// </summary>
    [EnumMember(Value = "ITPA")]
    [IsoId("_svdYERIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Triparty Agent")]
    InvalidTripartyAgent = RejectionReasonV3Code.InvalidTripartyAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or invalid Party A Safekeeping Account
    /// Encoded/decoded by serializers as &quot;SAFA&quot;.
    /// </summary>
    [EnumMember(Value = "SAFA")]
    [IsoId("_svdYExIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or invalid Party A Safekeeping Account")]
    PartyASafekeepingAccount = RejectionReasonV3Code.PartyASafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unrecognised or Invalid Party B Safekeeping Account.
    /// Encoded/decoded by serializers as &quot;SAFB&quot;.
    /// </summary>
    [EnumMember(Value = "SAFB")]
    [IsoId("_svdYFRIvEeyHZKWo4KVxBw")]
    [Description(@"Unrecognised or Invalid Party B Safekeeping Account.")]
    PartyBSafekeepingAccount = RejectionReasonV3Code.PartyBSafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid execution date/time
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_svdYFxIvEeyHZKWo4KVxBw")]
    [Description(@"Invalid execution date/time")]
    RequestedExecutionDateTime = RejectionReasonV3Code.RequestedExecutionDateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_svdYGRIvEeyHZKWo4KVxBw")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonV3Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_svdYGxIvEeyHZKWo4KVxBw")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonV3Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected because the instruction was already settled.
    /// Encoded/decoded by serializers as &quot;RSET&quot;.
    /// </summary>
    [EnumMember(Value = "RSET")]
    [IsoId("_svdYHRIvEeyHZKWo4KVxBw")]
    [Description(@"Cancellation request was rejected because the instruction was already settled.")]
    RejectedSinceAlreadySettled = RejectionReasonV3Code.RejectedSinceAlreadySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected because the repurchase was cancelled.
    /// Encoded/decoded by serializers as &quot;RREP&quot;.
    /// </summary>
    [EnumMember(Value = "RREP")]
    [IsoId("_svdYHxIvEeyHZKWo4KVxBw")]
    [Description(@"Cancellation request was rejected because the repurchase was cancelled.")]
    RejectedSinceRepoEnded = RejectionReasonV3Code.RejectedSinceRepoEnded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation, modification or termination request has been rejected since the instruction could not be found.
    /// Encoded/decoded by serializers as &quot;NRJN&quot;.
    /// </summary>
    [EnumMember(Value = "NRJN")]
    [IsoId("_svdYIRIvEeyHZKWo4KVxBw")]
    [Description(@"Cancellation, modification or termination request has been rejected since the instruction could not be found.")]
    NotFoundRejectionForCancellationModificationOrTermination = RejectionReasonV3Code.NotFoundRejectionForCancellationModificationOrTermination, // same ordinal as derivation source for type conversions
    
}
