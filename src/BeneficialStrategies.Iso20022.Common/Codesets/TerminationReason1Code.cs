// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the termination reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0mEXMHyiEeGWJuGCfvwOsQ")]
[Description(@"Specifies the termination reason.")]
[DerivedFrom(typeof(TerminationReasonCode))]
public enum TerminationReason1Code
{
    /// <summary>
    /// Reason for termination is reduction terms have been fulfilled.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_946n4RSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is reduction terms have been fulfilled.")]
    ReductionTermsFulfilled = TerminationReasonCode.ReductionTermsFulfilled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for termination is non-acceptance of a tender.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_-CKDcRSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is non-acceptance of a tender.")]
    TenderNonAcceptance = TerminationReasonCode.TenderNonAcceptance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for termination is underlying business has finished.
    /// Encoded/decoded by serializers as &quot;BUFI&quot;.
    /// </summary>
    [EnumMember(Value = "BUFI")]
    [IsoId("_-NLnsRSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is underlying business has finished.")]
    UnderlyingBusinessFinished = TerminationReasonCode.UnderlyingBusinessFinished, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason for termination is warranty obligation period has expired.
    /// Encoded/decoded by serializers as &quot;WOEX&quot;.
    /// </summary>
    [EnumMember(Value = "WOEX")]
    [IsoId("_-Yp34RSKEeKyNbjzgBLUcA")]
    [Description(@"Reason for termination is warranty obligation period has expired.")]
    WarrantyObligationPeriodExpired = TerminationReasonCode.WarrantyObligationPeriodExpired, // same ordinal as derivation source for type conversions
    
}
