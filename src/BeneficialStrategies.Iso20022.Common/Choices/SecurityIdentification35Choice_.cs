// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification35Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification35Choice.Name))]
    [KnownType(typeof(SecurityIdentification35Choice.Index))]
    [JsonDerivedType(typeof(SecurityIdentification35Choice.ISIN),nameof(SecurityIdentification35Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification35Choice.Name),nameof(SecurityIdentification35Choice.Name))]
    [JsonDerivedType(typeof(SecurityIdentification35Choice.Index),nameof(SecurityIdentification35Choice.Index))]
    [IsoId("_Zlr-rQ1HEeqV4s5SpzR1dQ")]
    [DisplayName("Security Identification 35 Choice")]
    public abstract partial record SecurityIdentification35Choice_
    {
    }
}
