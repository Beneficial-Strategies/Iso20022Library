// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the outcome of other review about fair value and/or charges. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09070.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Xw-vICucEe6GGqp7D_oKtA")]
[Description(
    @"Specifies the outcome of other review about fair value and/or charges. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09070."
)]
[DerivedFrom(typeof(OtherReviewRelatedToValueAndOrChargesUKTypeCode))]
public enum OtherReviewRelatedToValueAndOrChargesUKType1Code
{
    /// <summary>
    /// In line with the ESMA supervisory briefing on the supervision of costs in UCITS and AIFs or relevant NCA supervisory activity.
    /// Encoded/decoded by serializers as &quot;REVA&quot;.
    /// </summary>
    [EnumMember(Value = "REVA")]
    [IsoId("")]
    [Description(
        @"In line with the ESMA supervisory briefing on the supervision of costs in UCITS and AIFs or relevant NCA supervisory activity."
    )]
    ESMA = OtherReviewRelatedToValueAndOrChargesUKTypeCode.ESMA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In line with other local requirements or procedures.
    /// Encoded/decoded by serializers as &quot;REVO&quot;.
    /// </summary>
    [EnumMember(Value = "REVO")]
    [IsoId("")]
    [Description(@"In line with other local requirements or procedures.")]
    Other = OtherReviewRelatedToValueAndOrChargesUKTypeCode.Other, // same ordinal as derivation source for type conversions
}
