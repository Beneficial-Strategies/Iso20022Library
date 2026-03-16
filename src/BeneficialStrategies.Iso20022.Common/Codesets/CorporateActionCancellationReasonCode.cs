// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies reasons for cancellation of a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCpMFtp-Ed-ak6NoX_4Aeg_-484210840")]
[Description(@"Specifies reasons for cancellation of a corporate action event.")]
[Derivations(typeof(CorporateActionCancellationReason1Code))]
public enum CorporateActionCancellationReasonCode
{
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_bCpMF9p-Ed-ak6NoX_4Aeg_401443465")]
    [Description(@"Cancellation due to a processing error.")]
    Processing,

    /// <summary>
    /// Cancellation due to the corporate action event being cancelled by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bCpMGNp-Ed-ak6NoX_4Aeg_779163570")]
    [Description(@"Cancellation due to the corporate action event being cancelled by the issuer.")]
    Withrawal,
}
