// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the SSI update effective date is to be applied.
/// The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mW0uMDcfEeOA3chqL9a4Rw")]
[Description(@"Specifies how the SSI update effective date is to be applied.|The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalEffectiveDateParameterCode))]
public enum ExternalEffectiveDateParameter1Code
{
    /// <summary>
    /// Relates to the settlement date.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_uU8YRfRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to the settlement date.")]
    SettlementDate = ExternalEffectiveDateParameterCode.SettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Relates to the trade date.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_uU8YSPRYEeuLhpyIdtJzwg")]
    [Description(@"Relates to the trade date.")]
    TradeDate = ExternalEffectiveDateParameterCode.TradeDate, // same ordinal as derivation source for type conversions
    
}
