// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the outcome of PRIN value assessment or review about fair value of product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09060.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h9QSsCuYEe6GGqp7D_oKtA")]
[Description(@"Specifies the outcome of PRIN value assessment or review about fair value of product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09060.")]
[DerivedFrom(typeof(OutcomeOfPRINValueAssessmentOrReviewUKTypeCode))]
public enum OutcomeOfPRINValueAssessmentOrReviewUKType1Code
{
    /// <summary>
    /// Product expected to provide fair value for a reasonably foreseeable period.
    /// Encoded/decoded by serializers as &quot;PRI1&quot;.
    /// </summary>
    [EnumMember(Value = "PRI1")]
    [IsoId("")]
    [Description(@"Product expected to provide fair value for a reasonably foreseeable period.")]
    FairValue = OutcomeOfPRINValueAssessmentOrReviewUKTypeCode.FairValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Review indicates significant changes are required in order to provide fair value.
    /// Encoded/decoded by serializers as &quot;PRI2&quot;.
    /// </summary>
    [EnumMember(Value = "PRI2")]
    [IsoId("")]
    [Description(@"Review indicates significant changes are required in order to provide fair value.")]
    ChangesRequired = OutcomeOfPRINValueAssessmentOrReviewUKTypeCode.ChangesRequired, // same ordinal as derivation source for type conversions

}
