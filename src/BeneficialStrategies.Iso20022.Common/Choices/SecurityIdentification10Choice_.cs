// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification10Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification10Choice.OtherIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification10Choice.ISIN),nameof(SecurityIdentification10Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification10Choice.OtherIdentification),nameof(SecurityIdentification10Choice.OtherIdentification))]
    [IsoId("_RiFb19p-Ed-ak6NoX_4Aeg_2117119129")]
    [DisplayName("Security Identification 10 Choice")]
    public abstract partial record SecurityIdentification10Choice_
    {
    }
}
