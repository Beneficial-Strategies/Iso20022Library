// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/request has been cancelled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ybm4aNp-Ed-ak6NoX_4Aeg_177526096")]
[Description(@"Specifies the reason why the instruction/request has been cancelled.")]
[DerivedFrom(typeof(CollateralManagementCancellationReasonCode))]
public enum CollateralManagementCancellationReason1Code
{
    /// <summary>
    /// Cancellation due to message being sent in error.
    /// Encoded/decoded by serializers as &quot;PRER&quot;.
    /// </summary>
    [EnumMember(Value = "PRER")]
    [IsoId("_Ybm4adp-Ed-ak6NoX_4Aeg_809732037")]
    [Description(@"Cancellation due to message being sent in error.")]
    ProcessingError = CollateralManagementCancellationReasonCode.ProcessingError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation due to a change in exposure or collateral or independent amount or margin terms. For collateral proposal submitting new/different collateral.
    /// Encoded/decoded by serializers as &quot;PNSU&quot;.
    /// </summary>
    [EnumMember(Value = "PNSU")]
    [IsoId("_Ybm4atp-Ed-ak6NoX_4Aeg_1570497190")]
    [Description(@"Cancellation due to a change in exposure or collateral or independent amount or margin terms. For collateral proposal submitting new/different collateral.")]
    PendingNewSubmission = CollateralManagementCancellationReasonCode.PendingNewSubmission, // same ordinal as derivation source for type conversions
    
}
