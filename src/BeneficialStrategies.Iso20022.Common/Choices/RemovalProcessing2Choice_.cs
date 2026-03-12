// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the removal processing change requested and the reason.
    /// </summary>
    [KnownType(typeof(RemovalProcessing2Choice.FinancialInstrumentIdentification))]
    [KnownType(typeof(RemovalProcessing2Choice.IndexIdentification))]
    [KnownType(typeof(RemovalProcessing2Choice.IssuerCountry))]
    [JsonDerivedType(typeof(RemovalProcessing2Choice.FinancialInstrumentIdentification),nameof(RemovalProcessing2Choice.FinancialInstrumentIdentification))]
    [JsonDerivedType(typeof(RemovalProcessing2Choice.IndexIdentification),nameof(RemovalProcessing2Choice.IndexIdentification))]
    [JsonDerivedType(typeof(RemovalProcessing2Choice.IssuerCountry),nameof(RemovalProcessing2Choice.IssuerCountry))]
    [IsoId("__MbGwRIoEeyZaPkaPAzTvQ")]
    [DisplayName("Removal Processing 2 Choice")]
    public abstract partial record RemovalProcessing2Choice_
    {
    }
}
