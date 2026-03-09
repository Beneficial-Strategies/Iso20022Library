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
[IsoId("_90jEx_GAEemQ7oqCO5NTQw")]
[Description(@"Specifies the debtor activation amendment reason code, as published in an external debtor activation amendment reason code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalDebtorActivationAmendmentReasonCode))]
public enum ExternalDebtorActivationAmendmentReason1Code
{
    /// <summary>
    /// Duplication.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_uuSFW_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication.")]
    Duplication = ExternalDebtorActivationAmendmentReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reference is not unique.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uubPQvRYEeuLhpyIdtJzwg")]
    [Description(@"Reference is not unique.")]
    NotUniqueReference = ExternalDebtorActivationAmendmentReasonCode.NotUniqueReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uulAQvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason = ExternalDebtorActivationAmendmentReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical rejection.
    /// Encoded/decoded by serializers as &quot;TRJT&quot;.
    /// </summary>
    [EnumMember(Value = "TRJT")]
    [IsoId("_uulARfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical rejection.")]
    TechnicalRejection = ExternalDebtorActivationAmendmentReasonCode.TechnicalRejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_uuuxQvRYEeuLhpyIdtJzwg")]
    [Description(@"Unknown creditor.")]
    UnknownCreditor = ExternalDebtorActivationAmendmentReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
    
}
