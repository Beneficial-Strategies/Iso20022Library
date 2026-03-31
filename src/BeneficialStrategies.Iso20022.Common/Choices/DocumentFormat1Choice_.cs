// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of document format.
    /// </summary>
    [KnownType(typeof(DocumentFormat1Choice.Code))]
    [KnownType(typeof(DocumentFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(DocumentFormat1Choice.Code), nameof(DocumentFormat1Choice.Code))]
    [JsonDerivedType(
        typeof(DocumentFormat1Choice.Proprietary),
        nameof(DocumentFormat1Choice.Proprietary)
    )]
    [IsoId("_932rtHltEeG7BsjMvd1mEw_-1666043325")]
    [DisplayName("Document Format 1 Choice")]
    public abstract record DocumentFormat1Choice_ { }
}
