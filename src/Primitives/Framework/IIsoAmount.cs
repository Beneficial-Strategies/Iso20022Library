// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marker for an amount data type of the ISO 20022 dictionary (the Amounts namespace): a record with a <c>Currency</c> and an
/// <c>Amount</c> (<c>ActiveCurrencyAndAmount</c> and the others), or, where the dictionary leaves the currency to the context, a
/// decimal struct with no currency (<c>ImpliedCurrencyAndAmount</c> and the two like it).
/// A marker has no members; <see cref="Iso.KindOf(Type)"/> classifies any model type.
/// </summary>
public interface IIsoAmount { }
