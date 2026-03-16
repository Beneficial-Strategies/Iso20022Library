// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the obligation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZ95oNp-Ed-ak6NoX_4Aeg_-465800539")]
[Description(@"Specifies the type of the obligation.")]
[DerivedFrom(typeof(ObligationTypeCode))]
public enum ObligationType1Code
{
    /// <summary>
    /// Specifies that the obligation is related to a failed trade.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_YZ95odp-Ed-ak6NoX_4Aeg_-590738382")]
    [Description(@"Specifies that the obligation is related to a failed trade.")]
    Fails = ObligationTypeCode.Fails, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the obligation is related to new a trade.
    /// Encoded/decoded by serializers as &quot;NEW1&quot;.
    /// </summary>
    [EnumMember(Value = "NEW1")]
    [IsoId("_YZ95otp-Ed-ak6NoX_4Aeg_155306625")]
    [Description(@"Specifies that the obligation is related to new a trade.")]
    New = ObligationTypeCode.New, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the obligation is related to a corporate event.
    /// Encoded/decoded by serializers as &quot;COEV&quot;.
    /// </summary>
    [EnumMember(Value = "COEV")]
    [IsoId("_YZ95o9p-Ed-ak6NoX_4Aeg_-1536873572")]
    [Description(@"Specifies that the obligation is related to a corporate event.")]
    CorporateEvent = ObligationTypeCode.CorporateEvent, // same ordinal as derivation source for type conversions
}
