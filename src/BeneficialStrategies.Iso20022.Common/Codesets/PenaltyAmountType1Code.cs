// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the penalty amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Pffv8DkbEem897H7zB2RJg")]
[Description(@"Specifies the type of the penalty amount.")]
[DerivedFrom(typeof(PenaltyCalculationMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyAmountType1Code>))]
public enum PenaltyAmountType1Code
{
    /// <summary>
    /// Penalty is based on the amount of cash failed to be delivered and the penalty rate is the discount rate of the relevant currency.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_n1H3ATkbEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the amount of cash failed to be delivered and the penalty rate is the discount rate of the relevant currency."
    )]
    Cash = PenaltyCalculationMethodCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty is based on the quantity of securities failed to be delivered and penalty rate of the securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_oCrx4jkbEem897H7zB2RJg")]
    [Description(
        @"Penalty is based on the quantity of securities failed to be delivered and penalty rate of the securities."
    )]
    Securities = PenaltyCalculationMethodCode.Securities, // same ordinal as derivation source for type conversions
}
