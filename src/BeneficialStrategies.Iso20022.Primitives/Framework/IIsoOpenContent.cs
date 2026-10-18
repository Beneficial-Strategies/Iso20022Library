// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marker for an open-content slot (<c>LaxPayload</c> and the others in the ExternalSchema and UserDefined namespaces), whose content is not described by ISO 20022.
/// A marker has no members; <see cref="Iso.KindOf(Type)"/> classifies any model type.
/// </summary>
public interface IIsoOpenContent { }
