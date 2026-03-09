// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the direction of a cash flow.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aq9E1dp-Ed-ak6NoX_4Aeg_124504888")]
[Description(@"Specifies the direction of a cash flow.")]
[Derivations(typeof(FlowDirectionType1Code))]
public enum FlowDirectionTypeCode
{
    /// <summary>
    /// Amount of money received.
    /// Encoded/decoded by serializers as &quot;INCG&quot;.
    /// </summary>
    [EnumMember(Value = "INCG")]
    [IsoId("_aq9E1tp-Ed-ak6NoX_4Aeg_124504889")]
    [Description(@"Amount of money received.")]
    Incoming,
    
    /// <summary>
    /// Amount of money paid out.
    /// Encoded/decoded by serializers as &quot;OUTG&quot;.
    /// </summary>
    [EnumMember(Value = "OUTG")]
    [IsoId("_aq9E19p-Ed-ak6NoX_4Aeg_124504890")]
    [Description(@"Amount of money paid out.")]
    Outgoing,
    
}
