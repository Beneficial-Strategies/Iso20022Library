// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marker for a message component (for example <c>GroupHeader131</c>). Put on the component's interface, so a record and a foreign implementation are both recognised.
/// A marker has no members; <see cref="Iso.KindOf(Type)"/> classifies any model type.
/// </summary>
public interface IIsoComponent { }
