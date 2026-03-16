// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hX-RwJSZEeyTze01ewG2Qw")]
[Description(
    @"Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances."
)]
[DerivedFrom(typeof(ReconciliationStatusCode))]
public enum ReconciliationStatus1Code
{
    /// <summary>
    /// Indicator of reconciliation of derivatives for which all the reconcilable fields are not within the allowed tolerances.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_oQJDcZSZEeyTze01ewG2Qw")]
    [Description(
        @"Indicator of reconciliation of derivatives for which all the reconcilable fields are not within the allowed tolerances."
    )]
    NonReconciled = ReconciliationStatusCode.NonReconciled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicator of reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_oU6OsZSZEeyTze01ewG2Qw")]
    [Description(
        @"Indicator of reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances."
    )]
    Reconciled = ReconciliationStatusCode.Reconciled, // same ordinal as derivation source for type conversions
}
