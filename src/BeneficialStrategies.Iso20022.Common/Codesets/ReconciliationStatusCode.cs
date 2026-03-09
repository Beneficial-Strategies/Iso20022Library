// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the process type used for the trade repository reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zvl6MJSQEeyb24yfD-3rmg")]
[Description(@"Specifies the process type used for the trade repository reconciliation.")]
[Derivations(typeof(ReconciliationStatus1Code),typeof(ReconciliationStatus2Code))]
public enum ReconciliationStatusCode
{
    /// <summary>
    /// Indicator of reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.
    /// Encoded/decoded by serializers as &quot;RECO&quot;.
    /// </summary>
    [EnumMember(Value = "RECO")]
    [IsoId("_gOWGUJSQEeyb24yfD-3rmg")]
    [Description(@"Indicator of reconciliation of derivatives for which all the reconcilable fields are within the allowed tolerances.")]
    Reconciled,
    
    /// <summary>
    /// Indicator of reconciliation of derivatives for which all the reconcilable fields are not within the allowed tolerances.
    /// Encoded/decoded by serializers as &quot;NREC&quot;.
    /// </summary>
    [EnumMember(Value = "NREC")]
    [IsoId("_kOStsJSQEeyb24yfD-3rmg")]
    [Description(@"Indicator of reconciliation of derivatives for which all the reconcilable fields are not within the allowed tolerances.")]
    NonReconciled,
    
    /// <summary>
    /// Not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_tZFoAD5zEe2Z1_pdMHu4SA")]
    [Description(@"Not applicable.")]
    NotApplicable,
    
}
