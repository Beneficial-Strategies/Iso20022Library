// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a component belonging to a POI Terminal (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HFWpsAxxEeKa_56Jbsi1RQ")]
[Description(@"Status of a component belonging to a POI Terminal (Point of Interaction).")]
[DerivedFrom(typeof(POIComponentStatusCode))]
public enum POIComponentStatus1Code
{
    /// <summary>
    /// Component not yet activated.
    /// Encoded/decoded by serializers as &quot;WAIT&quot;.
    /// </summary>
    [EnumMember(Value = "WAIT")]
    [IsoId("_LHVRYQxxEeKa_56Jbsi1RQ")]
    [Description(@"Component not yet activated.")]
    WaitingActivation = POIComponentStatusCode.WaitingActivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component not working properly.
    /// Encoded/decoded by serializers as &quot;OUTD&quot;.
    /// </summary>
    [EnumMember(Value = "OUTD")]
    [IsoId("_LO6gEQxxEeKa_56Jbsi1RQ")]
    [Description(@"Component not working properly.")]
    OutOfOrder = POIComponentStatusCode.OutOfOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component activated and in operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_LUHwMwxxEeKa_56Jbsi1RQ")]
    [Description(@"Component activated and in operation.")]
    InOperation = POIComponentStatusCode.InOperation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component has been deactivated.
    /// Encoded/decoded by serializers as &quot;DACT&quot;.
    /// </summary>
    [EnumMember(Value = "DACT")]
    [IsoId("_Lbj08QxxEeKa_56Jbsi1RQ")]
    [Description(@"Component has been deactivated.")]
    Deactivated = POIComponentStatusCode.Deactivated, // same ordinal as derivation source for type conversions
}
