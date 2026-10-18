// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Semantic marker for ISO 20022 "external" code sets — those whose valid values are maintained
/// in a registry published separately from the eRepository (e.g. bank transaction domain codes,
/// country codes, mandate setup reason codes).
/// </summary>
/// <remarks>
/// Extends <see cref="IIsoSimpleValue{T}"/> with <c>T = string</c>. All serialization behavior
/// is inherited from that interface; this interface exists solely to distinguish external-registry
/// types from spec-fixed string types at the type-system level.
/// </remarks>
public interface IIsoExternalCode : IIsoSimpleValue<string> { }
