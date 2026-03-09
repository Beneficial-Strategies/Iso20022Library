// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of DTC (The Depository Trust Company) service, for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_14xnMDL3EeKU9IrkkToqcw_393105217")]
[Description(@"Indicates the type of DTC (The Depository Trust Company) service, for example Cash In Lieu/ Round Up, Foreign Tax Relief, etc.")]
[Derivations(typeof(DTCServiceType1Code))]
public enum DTCServiceType
{
    /// <summary>
    /// Cash In Lieu or Round Up service.
    /// Encoded/decoded by serializers as &quot;CILR&quot;.
    /// </summary>
    [EnumMember(Value = "CILR")]
    [IsoId("_14xnMTL3EeKU9IrkkToqcw_1528822829")]
    [Description(@"Cash In Lieu or Round Up service.")]
    CashInLieuRoundUp,
    
    /// <summary>
    /// U.S. Tax Withholding service.
    /// Encoded/decoded by serializers as &quot;USTX&quot;.
    /// </summary>
    [EnumMember(Value = "USTX")]
    [IsoId("_14xnMjL3EeKU9IrkkToqcw_744518473")]
    [Description(@"U.S. Tax Withholding service.")]
    USTaxWithholding,
    
    /// <summary>
    /// Foreign Tax Relief service.
    /// Encoded/decoded by serializers as &quot;FTXR&quot;.
    /// </summary>
    [EnumMember(Value = "FTXR")]
    [IsoId("_14xnMzL3EeKU9IrkkToqcw_4781110")]
    [Description(@"Foreign Tax Relief service.")]
    ForeignTaxRelief,
    
}
