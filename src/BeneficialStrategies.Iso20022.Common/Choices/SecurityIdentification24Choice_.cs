// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification24Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification24Choice.OtherIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification24Choice.ISIN),nameof(SecurityIdentification24Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification24Choice.OtherIdentification),nameof(SecurityIdentification24Choice.OtherIdentification))]
    [IsoId("_jLJhQeGXEeWCAvUNsZ5u6g")]
    [DisplayName("Security Identification 24 Choice")]
    public abstract partial record SecurityIdentification24Choice_
    {
    }
}
