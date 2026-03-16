// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies what action needs to be taken by the validation service for this particular record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_118VojL3EeKU9IrkkToqcw_-1756186614")]
[Description(
    @"Specifies what action needs to be taken by the validation service for this particular record."
)]
[DerivedFrom(typeof(GCAActionTypeCode))]
public enum GCAActionType1Code
{
    /// <summary>
    /// Custodian needs to be contacted.
    /// Encoded/decoded by serializers as &quot;RCON&quot;.
    /// </summary>
    [EnumMember(Value = "RCON")]
    [IsoId("_118VozL3EeKU9IrkkToqcw_-770650333")]
    [Description(@"Custodian needs to be contacted.")]
    ContactCustodian = GCAActionTypeCode.ContactCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further research is required.
    /// Encoded/decoded by serializers as &quot;FREA&quot;.
    /// </summary>
    [EnumMember(Value = "FREA")]
    [IsoId("_118VpDL3EeKU9IrkkToqcw_-1093140369")]
    [Description(@"Further research is required.")]
    ResearchRequired = GCAActionTypeCode.ResearchRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custodian has been contacted.
    /// Encoded/decoded by serializers as &quot;CDCU&quot;.
    /// </summary>
    [EnumMember(Value = "CDCU")]
    [IsoId("_118VpTL3EeKU9IrkkToqcw_-15120031")]
    [Description(@"Custodian has been contacted.")]
    CustodianContacted = GCAActionTypeCode.CustodianContacted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custodian does not need to be contacted.
    /// Encoded/decoded by serializers as &quot;NQCU&quot;.
    /// </summary>
    [EnumMember(Value = "NQCU")]
    [IsoId("_118VpjL3EeKU9IrkkToqcw_-26218808")]
    [Description(@"Custodian does not need to be contacted.")]
    DoNotContactCustodian = GCAActionTypeCode.DoNotContactCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No further action is required.
    /// Encoded/decoded by serializers as &quot;NFAC&quot;.
    /// </summary>
    [EnumMember(Value = "NFAC")]
    [IsoId("_12FfkDL3EeKU9IrkkToqcw_1024914264")]
    [Description(@"No further action is required.")]
    NoFurtherActionRequired = GCAActionTypeCode.NoFurtherActionRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Not supported by the GCA VA (Global Corporate Actions Validation service).
    /// Encoded/decoded by serializers as &quot;NSUP&quot;.
    /// </summary>
    [EnumMember(Value = "NSUP")]
    [IsoId("_12FfkTL3EeKU9IrkkToqcw_-47090795")]
    [Description(@"Not supported by the GCA VA (Global Corporate Actions Validation service).")]
    NotSupportedByGCA = GCAActionTypeCode.NotSupportedByGCA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_12FfkjL3EeKU9IrkkToqcw_1420057968")]
    [Description(@"Invalid.")]
    Invalid = GCAActionTypeCode.Invalid, // same ordinal as derivation source for type conversions
}
