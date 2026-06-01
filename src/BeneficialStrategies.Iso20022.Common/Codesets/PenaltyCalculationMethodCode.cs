// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation method for the penalty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PCcrwDkUEem897H7zB2RJg")]
[Description(@"Specifies the calculation method for the penalty.")]
[Derivations(
    typeof(PenaltyAmountType1Code),
    typeof(PenaltyCalculationMethod1Code)
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyCalculationMethodCode>))]
public enum PenaltyCalculationMethodCode
{
    /// <summary>
    /// Sum of the penalty based on the quantity of securities failed to be delivered and penalty rate of the securities and the penalty based on the amount of cash failed to be delivered and the discount rate of the currency.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_R7-doDkUEem897H7zB2RJg")]
    [Description(
        @"Sum of the penalty based on the quantity of securities failed to be delivered and penalty rate of the securities and the penalty based on the amount of cash failed to be delivered and the discount rate of the currency."
    )]
    Both,

    /// <summary>
    /// Penalty is based on the amount of cash failed to be delivered and the penalty rate is the discount rate of the relevant currency.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_R5l4ADkUEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the amount of cash failed to be delivered and the penalty rate is the discount rate of the relevant currency."
    )]
    Cash,

    /// <summary>
    /// Penalty is based on the quantity of securities failed to be delivered and penalty rate is the discount rate of the relevant currency.
    /// Encoded/decoded by serializers as &quot;MIXE&quot;.
    /// </summary>
    [EnumMember(Value = "MIXE")]
    [IsoId("_R3WcUDkUEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the quantity of securities failed to be delivered and penalty rate is the discount rate of the relevant currency."
    )]
    Mixed,

    /// <summary>
    /// Penalty is based on the quantity of securities failed to be delivered and penalty rate of the securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_RrlRMDkUEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the quantity of securities failed to be delivered and penalty rate of the securities."
    )]
    Securities,
}
