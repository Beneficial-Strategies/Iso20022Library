// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external financial instrument product type scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ha_UsGliEeGaMcKyqKNRfQ_-926948910")]
[Description(
    @"Specifies the external financial instrument product type scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalFinancialInstrumentProductTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalFinancialInstrumentProductType1Code>))]
public enum ExternalFinancialInstrumentProductType1Code { }
