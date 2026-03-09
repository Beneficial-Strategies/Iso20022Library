// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether charges are justified based on the COLL assessment. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09050.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpgwgCuVEe6GGqp7D_oKtA")]
[Description(@"Specifies whether charges are justified based on the COLL assessment. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09050.")]
[Derivations(typeof(OutcomeOfCOLLAssessmentOfValueUKType1Code))]
public enum OutcomeOfCOLLAssessmentOfValueUKTypeCode
{
    /// <summary>
    /// Charges are justified based on assessment and any action identified or, where the first assessment is not yet due, based on initial product design.
    /// Encoded/decoded by serializers as &quot;COL1&quot;.
    /// </summary>
    [EnumMember(Value = "COL1")]
    [IsoId("")]
    [Description(@"Charges are justified based on assessment and any action identified or, where the first assessment is not yet due, based on initial product design.")]
    ChargesJustified,

    /// <summary>
    /// Charges are not justified, significant action is required.
    /// Encoded/decoded by serializers as &quot;COL2&quot;.
    /// </summary>
    [EnumMember(Value = "COL2")]
    [IsoId("")]
    [Description(@"Charges are not justified, significant action is required.")]
    ChargesNotJustified,

}
