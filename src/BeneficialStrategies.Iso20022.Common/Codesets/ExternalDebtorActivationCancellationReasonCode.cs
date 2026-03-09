// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_90jEzPGAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalDebtorActivationCancellationReason1Code))]
public enum ExternalDebtorActivationCancellationReasonCode
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvBsMPRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uvBsM_RYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uvK2IPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_90jEzfGAEemQ7oqCO5NTQw")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uvUnIPRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor,
    
}
