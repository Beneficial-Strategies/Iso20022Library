// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of drawdown event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QXH9UFNiEeijdq8ilaxyOA")]
[Description(@"Specifies a type of drawdown event.")]
[Derivations(typeof(DrawdownEventType1Code))]
public enum DrawdownEventTypeCode
{
    /// <summary>
    /// Event is an uncrystallised funds pension lump sum (UFPLS).
    /// Encoded/decoded by serializers as &quot;UFPL&quot;.
    /// </summary>
    [EnumMember(Value = "UFPL")]
    [IsoId("_Tk4SwFNiEeijdq8ilaxyOA")]
    [Description(@"Event is an uncrystallised funds pension lump sum (UFPLS).")]
    UncrystallisedFundsPensionLumpSum,

    /// <summary>
    /// Event is a drawdown.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_ZAtpUFNiEeijdq8ilaxyOA")]
    [Description(@"Event is a drawdown.")]
    Drawdown,
}
