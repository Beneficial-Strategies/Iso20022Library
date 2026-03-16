// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the direction of a cash flow.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aq9E0tp-Ed-ak6NoX_4Aeg_124504901")]
[Description(@"Specifies the direction of a cash flow.")]
[DerivedFrom(typeof(FlowDirectionTypeCode))]
public enum FlowDirectionType1Code
{
    /// <summary>
    /// Amount of money received.
    /// Encoded/decoded by serializers as &quot;INCG&quot;.
    /// </summary>
    [EnumMember(Value = "INCG")]
    [IsoId("_aq9E09p-Ed-ak6NoX_4Aeg_124504902")]
    [Description(@"Amount of money received.")]
    Incoming = FlowDirectionTypeCode.Incoming, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money paid out.
    /// Encoded/decoded by serializers as &quot;OUTG&quot;.
    /// </summary>
    [EnumMember(Value = "OUTG")]
    [IsoId("_aq9E1Np-Ed-ak6NoX_4Aeg_124504903")]
    [Description(@"Amount of money paid out.")]
    Outgoing = FlowDirectionTypeCode.Outgoing, // same ordinal as derivation source for type conversions
}
