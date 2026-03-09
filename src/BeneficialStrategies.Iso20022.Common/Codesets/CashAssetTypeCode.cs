// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a source of the cash asset.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gdIMkEyIEeir2sRRVd9XhA")]
[Description(@"Specifies a source of the cash asset.")]
[Derivations(typeof(CashAssetType1Code))]
public enum CashAssetTypeCode
{
    /// <summary>
    /// Cash is attributed to a cash investment.
    /// Encoded/decoded by serializers as &quot;CSH1&quot;.
    /// </summary>
    [EnumMember(Value = "CSH1")]
    [IsoId("_ikEq8EyIEeir2sRRVd9XhA")]
    [Description(@"Cash is attributed to a cash investment.")]
    CashInvestment,
    
    /// <summary>
    /// Cash is cash in the holding not yet invested.
    /// Encoded/decoded by serializers as &quot;CSH2&quot;.
    /// </summary>
    [EnumMember(Value = "CSH2")]
    [IsoId("_lv5GsEyIEeir2sRRVd9XhA")]
    [Description(@"Cash is cash in the holding not yet invested.")]
    CashInHolding,
    
}
