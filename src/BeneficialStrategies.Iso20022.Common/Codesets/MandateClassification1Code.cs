// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of direct debit amount, such as fixed or variable.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dYdaoGVREeacpJ-gG9kyUQ")]
[Description(@"Specifies the type of direct debit amount, such as fixed or variable.")]
[DerivedFrom(typeof(MandateClassificationCode))]
public enum MandateClassification1Code
{
    /// <summary>
    /// Direct debit amount is fixed.
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_nHOmAWVREeacpJ-gG9kyUQ")]
    [Description(@"Direct debit amount is fixed.")]
    Fixed = MandateClassificationCode.Fixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit amount is based on usage.
    /// Encoded/decoded by serializers as &quot;USGB&quot;.
    /// </summary>
    [EnumMember(Value = "USGB")]
    [IsoId("_nMlnIWVREeacpJ-gG9kyUQ")]
    [Description(@"Direct debit amount is based on usage.")]
    UsageBased = MandateClassificationCode.UsageBased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit amount is variable.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_nVz0kWVREeacpJ-gG9kyUQ")]
    [Description(@"Direct debit amount is variable.")]
    Variable = MandateClassificationCode.Variable, // same ordinal as derivation source for type conversions
}
