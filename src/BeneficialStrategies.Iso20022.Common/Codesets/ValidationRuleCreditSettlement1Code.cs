// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the accepted credit settlement completed status code for the cross-element validation rules.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_el78sCE5EeuIZ4Hf6difAw")]
[Description(
    @"Specifies the accepted credit settlement completed status code for the cross-element validation rules."
)]
[DerivedFrom(typeof(ValidationRuleCode))]
public enum ValidationRuleCreditSettlement1Code
{
    /// <summary>
    /// AcceptedCreditSettlementCompleted
    /// Encoded/decoded by serializers as &quot;ACCC&quot;.
    /// </summary>
    [EnumMember(Value = "ACCC")]
    [IsoId("_yFd3gSE5EeuIZ4Hf6difAw")]
    [Description(@"AcceptedCreditSettlementCompleted")]
    AcceptedCreditSettlementCompleted = ValidationRuleCode.AcceptedCreditSettlementCompleted, // same ordinal as derivation source for type conversions
}
