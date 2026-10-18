// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marker for an ISO 20022 simple (primitive) data type: <c>Max35Text</c>, a date, an identifier and the like.
/// The non-generic base of <see cref="IIsoSimpleValue{T}"/>, so code can ask "is this a simple type" without searching
/// for a generic interface. A marker has no members; <see cref="Iso.KindOf(Type)"/> classifies any model type.
/// </summary>
public interface IIsoSimpleType { }
