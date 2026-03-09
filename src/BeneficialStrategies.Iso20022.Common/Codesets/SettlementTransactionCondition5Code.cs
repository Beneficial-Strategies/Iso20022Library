// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ku3YgeBFEd-D2OAFXdoRmA")]
[Description(@"Specifies the conditions under which the order/trade is to be settled.")]
[DerivedFrom(typeof(SettlementTransactionConditionCode))]
public enum SettlementTransactionCondition5Code
{
    /// <summary>
    /// Partial settlement is allowed.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_q6dmBWtdEeCY4-KZ9JEyUQ_-817672077")]
    [Description(@"Partial settlement is allowed.")]
    PartialAllowed = SettlementTransactionConditionCode.PartialAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial settlement is not allowed.
    /// Encoded/decoded by serializers as &quot;NPAR&quot;.
    /// </summary>
    [EnumMember(Value = "NPAR")]
    [IsoId("_q6dmBmtdEeCY4-KZ9JEyUQ_-1814744430")]
    [Description(@"Partial settlement is not allowed.")]
    PartialNotAllowed = SettlementTransactionConditionCode.PartialNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial settlement is allowed but must satisfy a cash value minimum (value defined in static data).
    /// Encoded/decoded by serializers as &quot;PARC&quot;.
    /// </summary>
    [EnumMember(Value = "PARC")]
    [IsoId("_q6nXAGtdEeCY4-KZ9JEyUQ_374187327")]
    [Description(@"Partial settlement is allowed but must satisfy a cash value minimum (value defined in static data).")]
    PartialSettlementCashThresholdAllowed = SettlementTransactionConditionCode.PartialSettlementCashThresholdAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Partial settlement is allowed but must satisfy a minimum quantity of securities (quantity defined in static data).
    /// Encoded/decoded by serializers as &quot;PARQ&quot;.
    /// </summary>
    [EnumMember(Value = "PARQ")]
    [IsoId("_q6nXAWtdEeCY4-KZ9JEyUQ_1425320399")]
    [Description(@"Partial settlement is allowed but must satisfy a minimum quantity of securities (quantity defined in static data).")]
    PartialSettlementQuantityThresholdAllowed = SettlementTransactionConditionCode.PartialSettlementQuantityThresholdAllowed, // same ordinal as derivation source for type conversions
    
}
