// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of exchange&apos;s notice of change on a derivative.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12FfkzL3EeKU9IrkkToqcw_-117083409")]
[Description(@"Specifies the status of exchange's notice of change on a derivative.")]
[Derivations(typeof(DerivativeWorkflowStatus1Code))]
public enum DerivativeWorkflowStatusCode
{
    /// <summary>
    /// Notice is an advance warning that an adjustment may be applied.
    /// Encoded/decoded by serializers as &quot;PREL&quot;.
    /// </summary>
    [EnumMember(Value = "PREL")]
    [IsoId("_12FflDL3EeKU9IrkkToqcw_1152575769")]
    [Description(@"Notice is an advance warning that an adjustment may be applied.")]
    Preliminary,
    
    /// <summary>
    /// Notice confirms that an adjustment will be applied.
    /// Encoded/decoded by serializers as &quot;ADJU&quot;.
    /// </summary>
    [EnumMember(Value = "ADJU")]
    [IsoId("_12FflTL3EeKU9IrkkToqcw_1026052659")]
    [Description(@"Notice confirms that an adjustment will be applied.")]
    Adjustment,
    
    /// <summary>
    /// Notice confirms that no adjustment will be applied.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_12FfljL3EeKU9IrkkToqcw_757086237")]
    [Description(@"Notice confirms that no adjustment will be applied.")]
    NoAction,
    
    /// <summary>
    /// GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.
    /// Encoded/decoded by serializers as &quot;UCON&quot;.
    /// </summary>
    [EnumMember(Value = "UCON")]
    [IsoId("_12PQkDL3EeKU9IrkkToqcw_1014152022")]
    [Description(@"GCA VS (Global Corporate Actions Validation Service) is unable to confirm that there is a corporate action corresponding to this notice.")]
    Unconfirmed,
    
    /// <summary>
    /// Details were entered in error. All data should be ignored.
    /// Encoded/decoded by serializers as &quot;DLTD&quot;.
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_12PQkTL3EeKU9IrkkToqcw_954160850")]
    [Description(@"Details were entered in error. All data should be ignored.")]
    Deleted,
    
}
