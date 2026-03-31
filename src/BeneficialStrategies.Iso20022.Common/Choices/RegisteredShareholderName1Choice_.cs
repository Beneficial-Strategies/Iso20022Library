// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of individual or organisation name and address.
    /// </summary>
    [KnownType(typeof(RegisteredShareholderName1Choice.IndividualPerson))]
    [KnownType(typeof(RegisteredShareholderName1Choice.Organisation))]
    [JsonDerivedType(
        typeof(RegisteredShareholderName1Choice.IndividualPerson),
        nameof(RegisteredShareholderName1Choice.IndividualPerson)
    )]
    [JsonDerivedType(
        typeof(RegisteredShareholderName1Choice.Organisation),
        nameof(RegisteredShareholderName1Choice.Organisation)
    )]
    [IsoId("_ijIuEFxYEeWvPv3PXpS3fw")]
    [DisplayName("Registered Shareholder Name 1 Choice")]
    public abstract record RegisteredShareholderName1Choice_ { }
}
