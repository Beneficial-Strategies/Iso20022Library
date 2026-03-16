// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) defined asset class.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1mSwFTL3EeKU9IrkkToqcw_388312262")]
[Description(@"Specifies DTC (The Depository Trust Company) defined asset class.")]
[Derivations(typeof(AssetClass1Code))]
public enum AssetClassCode
{
    /// <summary>
    /// Debt instrument issued by a corporation.
    /// Encoded/decoded by serializers as &quot;CRPB&quot;.
    /// </summary>
    [EnumMember(Value = "CRPB")]
    [IsoId("_1mSwFjL3EeKU9IrkkToqcw_-183212475")]
    [Description(@"Debt instrument issued by a corporation.")]
    CorporateDebt,

    /// <summary>
    /// Equity issued by a corporation.
    /// Encoded/decoded by serializers as &quot;CRPE&quot;.
    /// </summary>
    [EnumMember(Value = "CRPE")]
    [IsoId("_1mchEDL3EeKU9IrkkToqcw_-1016289594")]
    [Description(@"Equity issued by a corporation.")]
    CorporateEquity,

    /// <summary>
    /// Debt instrument issued by municipality.
    /// Encoded/decoded by serializers as &quot;MUNB&quot;.
    /// </summary>
    [EnumMember(Value = "MUNB")]
    [IsoId("_1mchETL3EeKU9IrkkToqcw_-601795221")]
    [Description(@"Debt instrument issued by municipality.")]
    MunicipalDebt,
}
