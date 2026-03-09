// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to indicate the activity type to be reconciled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4hc1MCYAEeym0KcvJF9aDQ")]
[Description(@"Code to indicate the activity type to be reconciled.")]
[DerivedFrom(typeof(ReconciliationActivityTypeCode))]
public enum ReconciliationActivityType1Code
{
    /// <summary>
    /// Acquiring activity.
    /// Encoded/decoded by serializers as &quot;ACQG&quot;.
    /// </summary>
    [EnumMember(Value = "ACQG")]
    [IsoId("_6rj8USYAEeym0KcvJF9aDQ")]
    [Description(@"Acquiring activity.")]
    Acquiring = ReconciliationActivityTypeCode.Acquiring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All types of activity.
    /// Encoded/decoded by serializers as &quot;CNSD&quot;.
    /// </summary>
    [EnumMember(Value = "CNSD")]
    [IsoId("_6yCXwSYAEeym0KcvJF9aDQ")]
    [Description(@"All types of activity.")]
    Consolidated = ReconciliationActivityTypeCode.Consolidated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuing activity
    /// Encoded/decoded by serializers as &quot;ISSG&quot;.
    /// </summary>
    [EnumMember(Value = "ISSG")]
    [IsoId("_62jEUSYAEeym0KcvJF9aDQ")]
    [Description(@"Issuing activity")]
    Issuing = ReconciliationActivityTypeCode.Issuing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other reconciliation activity type defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6-gGcSYAEeym0KcvJF9aDQ")]
    [Description(@"Other reconciliation activity type defined at national level")]
    OtherNational = ReconciliationActivityTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other reconciliation activity type defined at private level 
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_7DqTQSYAEeym0KcvJF9aDQ")]
    [Description(@"Other reconciliation activity type defined at private level ")]
    OtherPrivate = ReconciliationActivityTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
}
