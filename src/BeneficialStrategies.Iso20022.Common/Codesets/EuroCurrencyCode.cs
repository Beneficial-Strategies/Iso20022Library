// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code allocated to the Euro currency, as described in the latest edition of the international standard ISO 4217.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EuroCurrencyCode")]
[Description(@"Code allocated to the Euro currency, as described in the latest edition of the international standard ISO 4217.")]
public enum EuroCurrencyCode
{
}
