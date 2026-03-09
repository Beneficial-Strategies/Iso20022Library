// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indication whether both counterparties to the transaction have reported to the same trade repository or each counteraprty to the transaction reported two different trade repository.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gIoLANIFEeiG-o-KpBT4-g")]
[Description(@"Indication whether both counterparties to the transaction have reported to the same trade repository or each counteraprty to the transaction reported two different trade repository.")]
[Derivations(typeof(TradeRepositoryReportingType1Code))]
public enum TradeRepositoryReportingTypeCode
{
    /// <summary>
    /// Only one counterparty to the transaction has reported to the same trade repository.
    /// Encoded/decoded by serializers as &quot;SWOS&quot;.
    /// </summary>
    [EnumMember(Value = "SWOS")]
    [IsoId("_iPyr0NIFEeiG-o-KpBT4-g")]
    [Description(@"Only one counterparty to the transaction has reported to the same trade repository.")]
    SingleSided,
    
    /// <summary>
    ///  Both counterparties to the transaction have reported to the same trade repository.
    /// Encoded/decoded by serializers as &quot;TWOS&quot;.
    /// </summary>
    [EnumMember(Value = "TWOS")]
    [IsoId("_jlMYgNIFEeiG-o-KpBT4-g")]
    [Description(@" Both counterparties to the transaction have reported to the same trade repository.")]
    DualSided,
    
}
