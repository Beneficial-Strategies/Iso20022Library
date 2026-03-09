// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of risk management answer from an Acquirer (or its IntermediaryAgent) to aPOI through a NonFinancialResponse. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3ljzQC_wEeugIJ3Gvoevmg")]
[Description(@"Type of risk management answer from an Acquirer (or its IntermediaryAgent) to aPOI through a NonFinancialResponse. ")]
[DerivedFrom(typeof(NonFinancialResponseRiskCode))]
public enum NonFinancialResponseRisk1Code
{
    /// <summary>
    /// A decline of the transaction is expected by the POI to manage risk.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_8f_F4S_wEeugIJ3Gvoevmg")]
    [Description(@"A decline of the transaction is expected by the POI to manage risk.")]
    Decline = NonFinancialResponseRiskCode.Decline, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI is able to assess the risk by himself.
    /// Encoded/decoded by serializers as &quot;NCHG&quot;.
    /// </summary>
    [EnumMember(Value = "NCHG")]
    [IsoId("_8ja0YS_wEeugIJ3Gvoevmg")]
    [Description(@"The POI is able to assess the risk by himself.")]
    LocallyManaged = NonFinancialResponseRiskCode.LocallyManaged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An authorisation is expected from the POI to manage risk.
    /// Encoded/decoded by serializers as &quot;ONLN&quot;.
    /// </summary>
    [EnumMember(Value = "ONLN")]
    [IsoId("_8oNNwS_wEeugIJ3Gvoevmg")]
    [Description(@"An authorisation is expected from the POI to manage risk.")]
    RequestOnline = NonFinancialResponseRiskCode.RequestOnline, // same ordinal as derivation source for type conversions
    
}
