// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_90jEyPGAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalDebtorActivationAmendmentReason1Code))]
public enum ExternalDebtorActivationAmendmentReasonCode
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuSFWfRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication,
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uubPQPRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference,
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uulAQPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_90jEyfGAEemQ7oqCO5NTQw")]
    [Description(@"Technical rejection.")]
    TechnicalRejection,
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_90jEyvGAEemQ7oqCO5NTQw")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor,
    
}
