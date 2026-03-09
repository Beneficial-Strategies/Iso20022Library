// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether charges are justified based on the COLL assessment. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09050.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_71siQCuWEe6GGqp7D_oKtA")]
[Description(@"Specifies whether charges are justified based on the COLL assessment. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09050.")]
[DerivedFrom(typeof(OutcomeOfCOLLAssessmentOfValueUKTypeCode))]
public enum OutcomeOfCOLLAssessmentOfValueUKType1Code
{
    /// <summary>
    /// Charges are justified based on assessment and any action identified or, where the first assessment is not yet due, based on initial product design.
    /// Encoded/decoded by serializers as &quot;COL1&quot;.
    /// </summary>
    [EnumMember(Value = "COL1")]
    [IsoId("")]
    [Description(@"Charges are justified based on assessment and any action identified or, where the first assessment is not yet due, based on initial product design.")]
    ChargesJustified = OutcomeOfCOLLAssessmentOfValueUKTypeCode.ChargesJustified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges are not justified, significant action is required.
    /// Encoded/decoded by serializers as &quot;COL2&quot;.
    /// </summary>
    [EnumMember(Value = "COL2")]
    [IsoId("")]
    [Description(@"Charges are not justified, significant action is required.")]
    ChargesNotJustified = OutcomeOfCOLLAssessmentOfValueUKTypeCode.ChargesNotJustified, // same ordinal as derivation source for type conversions

}
