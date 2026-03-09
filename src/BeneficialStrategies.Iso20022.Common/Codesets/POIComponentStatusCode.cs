// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a component belonging to a POI Terminal (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d4opsAxwEeKa_56Jbsi1RQ")]
[Description(@"Status of a component belonging to a POI Terminal (Point of Interaction).")]
[Derivations(typeof(POIComponentStatus1Code))]
public enum POIComponentStatusCode
{
    /// <summary>
    /// Component not yet activated.
    /// Encoded/decoded by serializers as &quot;WAIT&quot;.
    /// </summary>
    [EnumMember(Value = "WAIT")]
    [IsoId("_rAURoAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component not yet activated.")]
    WaitingActivation,
    
    /// <summary>
    /// Component activated and in operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_09qrkAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component activated and in operation.")]
    InOperation,
    
    /// <summary>
    /// Component not working properly.
    /// Encoded/decoded by serializers as &quot;OUTD&quot;.
    /// </summary>
    [EnumMember(Value = "OUTD")]
    [IsoId("_6gMgAAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component not working properly.")]
    OutOfOrder,
    
    /// <summary>
    /// Component has been deactivated.
    /// Encoded/decoded by serializers as &quot;DACT&quot;.
    /// </summary>
    [EnumMember(Value = "DACT")]
    [IsoId("__5DbEAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component has been deactivated.")]
    Deactivated,
    
}
