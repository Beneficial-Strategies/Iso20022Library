// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification6Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification6Choice.OtherIdentification))]
    [KnownType(typeof(SecurityIdentification6Choice.InstrumentDescription))]
    [JsonDerivedType(typeof(SecurityIdentification6Choice.ISIN),nameof(SecurityIdentification6Choice.ISIN))]
    [JsonDerivedType(typeof(SecurityIdentification6Choice.OtherIdentification),nameof(SecurityIdentification6Choice.OtherIdentification))]
    [JsonDerivedType(typeof(SecurityIdentification6Choice.InstrumentDescription),nameof(SecurityIdentification6Choice.InstrumentDescription))]
    [IsoId("_TBKB79p-Ed-ak6NoX_4Aeg_-1421894985")]
    [DisplayName("Security Identification 6 Choice")]
    public abstract partial record SecurityIdentification6Choice_
    {
    }
}
