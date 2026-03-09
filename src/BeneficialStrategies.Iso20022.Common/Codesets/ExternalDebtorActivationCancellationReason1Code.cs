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
[IsoId("_90jEy_GAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation cancellation reason code, as published in an external debtor activation cancellation reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDebtorActivationCancellationReasonCode))]
public enum ExternalDebtorActivationCancellationReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uvBsMvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalDebtorActivationCancellationReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uvBsNfRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalDebtorActivationCancellationReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uvK2IvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalDebtorActivationCancellationReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uvK2JfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalDebtorActivationCancellationReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uvUnIvRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor = ExternalDebtorActivationCancellationReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
    
}
