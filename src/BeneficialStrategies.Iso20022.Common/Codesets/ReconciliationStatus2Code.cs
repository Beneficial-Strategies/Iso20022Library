// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_y7hV0T5zEe2Z1_pdMHu4SA")]
[Description(@"Indicator if reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.")]
[DerivedFrom(typeof(ReconciliationStatusCode))]
public enum ReconciliationStatus2Code
{
    /// <summary>
    /// Indicator of reconciliation of derivatives for which all the reconcilable fields are not within the allowed tolerances.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_y9E1AT5zEe2Z1_pdMHu4SA")]
    [Description(@"Indicator of reconciliation of derivatives for which all the reconcilable fields are not within the allowed tolerances.")]
    NonReconciled = ReconciliationStatusCode.NonReconciled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicator of reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_y9E1Az5zEe2Z1_pdMHu4SA")]
    [Description(@"Indicator of reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.")]
    Reconciled = ReconciliationStatusCode.Reconciled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_zxy2gT5zEe2Z1_pdMHu4SA")]
    [Description(@"Not applicable.")]
    NotApplicable = ReconciliationStatusCode.NotApplicable, // same ordinal as derivation source for type conversions
    
}
