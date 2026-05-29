// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 "Codes for the representation of currencies and funds".
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bqIp6tp-Ed-ak6NoX_4Aeg_1823330336")]
[Description(@"A code allocated to a currency by a Maintenance Agency under an international identification scheme, as described in the latest edition of the international standard ISO 4217 ""Codes for the representation of currencies and funds"".")]
public enum ActiveOrHistoricCurrencyCode { }
