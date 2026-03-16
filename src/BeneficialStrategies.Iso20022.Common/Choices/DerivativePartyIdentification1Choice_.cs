// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reference entity of a single name credit default swap (CDS) or a derivative on single name credit default swap (CDS).
    /// </summary>
    [KnownType(typeof(DerivativePartyIdentification1Choice.Country))]
    [KnownType(typeof(DerivativePartyIdentification1Choice.CountrySubDivision))]
    [KnownType(typeof(DerivativePartyIdentification1Choice.LEI))]
    [JsonDerivedType(
        typeof(DerivativePartyIdentification1Choice.Country),
        nameof(DerivativePartyIdentification1Choice.Country)
    )]
    [JsonDerivedType(
        typeof(DerivativePartyIdentification1Choice.CountrySubDivision),
        nameof(DerivativePartyIdentification1Choice.CountrySubDivision)
    )]
    [JsonDerivedType(
        typeof(DerivativePartyIdentification1Choice.LEI),
        nameof(DerivativePartyIdentification1Choice.LEI)
    )]
    [IsoId("_adARgEW8EeWaZZ6gWK8UVw")]
    [DisplayName("Derivative Party Identification 1 Choice")]
    public abstract record DerivativePartyIdentification1Choice_ { }
}
