// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the technical error.
    /// </summary>
    [KnownType(typeof(TechnicalError1Choice.Code))]
    [KnownType(typeof(TechnicalError1Choice.Proprietary))]
    [JsonDerivedType(typeof(TechnicalError1Choice.Code),nameof(TechnicalError1Choice.Code))]
    [JsonDerivedType(typeof(TechnicalError1Choice.Proprietary),nameof(TechnicalError1Choice.Proprietary))]
    [IsoId("_pDbrZA3BEeWH49U6bkyMaA")]
    [DisplayName("Technical Error 1 Choice")]
    public abstract partial record TechnicalError1Choice_
    {
    }
}
