// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify a name of a unit resulting from the division of a country, dependency, or other area of special geopolitical interest contained in ISO 3166-1, on the basis of country names obtained from the United Nations (ISO 3166-2: Country subdivision code).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CountrySubDivisionCode")]
[Description(
    @"Code to identify a name of a unit resulting from the division of a country, dependency, or other area of special geopolitical interest contained in ISO 3166-1, on the basis of country names obtained from the United Nations (ISO 3166-2: Country subdivision code)."
)]
public enum CountrySubDivisionCode { }
