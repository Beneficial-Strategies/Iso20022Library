// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Marker for a currency-and-amount data type (<c>ActiveCurrencyAndAmount</c> and the others in the Amounts namespace).
/// A marker has no members; <see cref="Iso.KindOf(Type)"/> classifies any model type.
/// </summary>
public interface IIsoAmount { }
