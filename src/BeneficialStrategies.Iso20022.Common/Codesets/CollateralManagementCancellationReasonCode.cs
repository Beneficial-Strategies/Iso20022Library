// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/request has been cancelled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbwCUNp-Ed-ak6NoX_4Aeg_-1054391304")]
[Description(@"Specifies the reason why the instruction/request has been cancelled.")]
[Derivations(typeof(CollateralManagementCancellationReason1Code))]
public enum CollateralManagementCancellationReasonCode
{
    /// <summary>
    /// Cancellation due to message being sent in error.
    /// Encoded/decoded by serializers as &quot;PRER&quot;.
    /// </summary>
    [EnumMember(Value = "PRER")]
    [IsoId("_YbwCUdp-Ed-ak6NoX_4Aeg_577621422")]
    [Description(@"Cancellation due to message being sent in error.")]
    ProcessingError,

    /// <summary>
    /// Cancellation due to a change in exposure or collateral or independent amount or margin terms. For collateral proposal submitting new/different collateral.
    /// Encoded/decoded by serializers as &quot;PNSU&quot;.
    /// </summary>
    [EnumMember(Value = "PNSU")]
    [IsoId("_YbwCUtp-Ed-ak6NoX_4Aeg_664607008")]
    [Description(
        @"Cancellation due to a change in exposure or collateral or independent amount or margin terms. For collateral proposal submitting new/different collateral."
    )]
    PendingNewSubmission,
}
