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
[IsoId("_cThgQDkUEem897H7zB2RJg")]
[Description(@"Specifies the calculation method for the penalty.")]
[DerivedFrom(typeof(PenaltyCalculationMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyCalculationMethod1Code>))]
public enum PenaltyCalculationMethod1Code
{
    /// <summary>
    /// Sum of the penalty based on the quantity of securities failed to be delivered and penalty rate of the securities and the penalty based on the amount of cash failed to be delivered and the discount rate of the currency.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_deUfcTkUEem897H7zB2RJg")]
    [Description(
        @"Sum of the penalty based on the quantity of securities failed to be delivered and penalty rate of the securities and the penalty based on the amount of cash failed to be delivered and the discount rate of the currency."
    )]
    Both = PenaltyCalculationMethodCode.Both, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is based on the amount of cash failed to be delivered and the penalty rate is the discount rate of the relevant currency.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_dmXoMjkUEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the amount of cash failed to be delivered and the penalty rate is the discount rate of the relevant currency."
    )]
    Cash = PenaltyCalculationMethodCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is based on the quantity of securities failed to be delivered and penalty rate is the discount rate of the relevant currency.
    /// Encoded/decoded by serializers as &quot;MIXE&quot;.
    /// </summary>
    [EnumMember(Value = "MIXE")]
    [IsoId("_drlfYTkUEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the quantity of securities failed to be delivered and penalty rate is the discount rate of the relevant currency."
    )]
    Mixed = PenaltyCalculationMethodCode.Mixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is based on the quantity of securities failed to be delivered and penalty rate of the securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_d3WqgjkUEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the quantity of securities failed to be delivered and penalty rate of the securities."
    )]
    Securities = PenaltyCalculationMethodCode.Securities, // same ordinal as derivation source for type conversions
}
