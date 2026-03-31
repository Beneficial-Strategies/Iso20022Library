// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of the agreement of the custodian record when compared to composite record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11fpsTL3EeKU9IrkkToqcw_1222518114")]
[Description(
    @"Specifies the state of the agreement of the custodian record when compared to composite record."
)]
[DerivedFrom(typeof(CustodianRecordAgreementTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CustodianRecordAgreementType1Code>))]
#endif
public enum CustodianRecordAgreementType1Code
{
    /// <summary>
    /// Custodian record agrees with the composite record.
    /// Encoded/decoded by serializers as &quot;AGRE&quot;.
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_11fpsjL3EeKU9IrkkToqcw_-291543411")]
    [Description(@"Custodian record agrees with the composite record.")]
    Agree = CustodianRecordAgreementTypeCode.Agree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Custodian record disagrees with the composite record.
    /// Encoded/decoded by serializers as &quot;DAGR&quot;.
    /// </summary>
    [EnumMember(Value = "DAGR")]
    [IsoId("_11fpszL3EeKU9IrkkToqcw_151445081")]
    [Description(@"Custodian record disagrees with the composite record.")]
    Disagree = CustodianRecordAgreementTypeCode.Disagree, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No composite record available.
    /// Encoded/decoded by serializers as &quot;NCOP&quot;.
    /// </summary>
    [EnumMember(Value = "NCOP")]
    [IsoId("_11fptDL3EeKU9IrkkToqcw_1073608391")]
    [Description(@"No composite record available.")]
    NoComposite = CustodianRecordAgreementTypeCode.NoComposite, // same ordinal as derivation source for type conversions
}
