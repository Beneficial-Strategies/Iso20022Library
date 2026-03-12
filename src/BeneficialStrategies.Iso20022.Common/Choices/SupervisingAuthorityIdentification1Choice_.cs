// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of the relevant supervising authority.
    /// </summary>
    [KnownType(typeof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification))]
    [KnownType(typeof(SupervisingAuthorityIdentification1Choice.FullName))]
    [JsonDerivedType(typeof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification),nameof(SupervisingAuthorityIdentification1Choice.ProprietaryIdentification))]
    [JsonDerivedType(typeof(SupervisingAuthorityIdentification1Choice.FullName),nameof(SupervisingAuthorityIdentification1Choice.FullName))]
    [IsoId("_4ZQrMPH-Eeaz_YGUGLjP6A")]
    [DisplayName("Supervising Authority Identification 1 Choice")]
    public abstract partial record SupervisingAuthorityIdentification1Choice_
    {
    }
}
