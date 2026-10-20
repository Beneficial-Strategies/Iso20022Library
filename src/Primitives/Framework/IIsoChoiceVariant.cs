// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marker for one variant of a choice. A variant interface also derives from its choice's interface, so a variant is told from its choice by this marker.
/// A marker has no members; <see cref="Iso.KindOf(Type)"/> classifies any model type.
/// </summary>
public interface IIsoChoiceVariant { }
