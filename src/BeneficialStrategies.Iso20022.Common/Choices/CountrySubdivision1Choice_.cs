// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the legal jurisdiction.
    /// </summary>
    [KnownType(typeof(CountrySubdivision1Choice.Code))]
    [KnownType(typeof(CountrySubdivision1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CountrySubdivision1Choice.Code),
        nameof(CountrySubdivision1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CountrySubdivision1Choice.Proprietary),
        nameof(CountrySubdivision1Choice.Proprietary)
    )]
    [IsoId("_93jww3ltEeG7BsjMvd1mEw_-652907596")]
    [DisplayName("Country Subdivision 1 Choice")]
    public abstract record CountrySubdivision1Choice_ { }
}
