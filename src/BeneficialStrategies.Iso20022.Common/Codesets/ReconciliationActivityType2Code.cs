// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to indicate the activity type to be reconciled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rmsr8XSAEfC68Y4jZPNEug")]
[Description(@"Code to indicate the activity type to be reconciled.")]
[DerivedFrom(typeof(ReconciliationActivityTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ReconciliationActivityType2Code>))]
public enum ReconciliationActivityType2Code
{
    /// <summary>
    /// Acquiring activity.
    /// Encoded/decoded by serializers as &quot;ACQG&quot;.
    /// </summary>
    [EnumMember(Value = "ACQG")]
    [IsoId("_RpSF4XSAEfC68Y4jZPNEug")]
    [Description(@"Acquiring activity.")]
    Acquiring = ReconciliationActivityTypeCode.Acquiring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All types of activity.
    /// Encoded/decoded by serializers as &quot;CNSD&quot;.
    /// </summary>
    [EnumMember(Value = "CNSD")]
    [IsoId("_RpSF43SAEfC68Y4jZPNEug")]
    [Description(@"All types of activity.")]
    Consolidated = ReconciliationActivityTypeCode.Consolidated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuing activity.
    /// Encoded/decoded by serializers as &quot;ISSG&quot;.
    /// </summary>
    [EnumMember(Value = "ISSG")]
    [IsoId("_RpSF5XSAEfC68Y4jZPNEug")]
    [Description(@"Issuing activity.")]
    Issuing = ReconciliationActivityTypeCode.Issuing, // same ordinal as derivation source for type conversions
}
