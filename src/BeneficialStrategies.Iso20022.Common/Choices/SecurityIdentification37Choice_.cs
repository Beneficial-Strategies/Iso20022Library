// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification37Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification37Choice.Name))]
    [KnownType(typeof(SecurityIdentification37Choice.Index))]
    [JsonDerivedType(
        typeof(SecurityIdentification37Choice.ISIN),
        nameof(SecurityIdentification37Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification37Choice.Name),
        nameof(SecurityIdentification37Choice.Name)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification37Choice.Index),
        nameof(SecurityIdentification37Choice.Index)
    )]
    [IsoId("_OtC8sTLlEeu9CrLaMVTofw")]
    [DisplayName("Security Identification 37 Choice")]
    public abstract record SecurityIdentification37Choice_ { }
}
