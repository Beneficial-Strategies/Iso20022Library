// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the technical input channel.
    /// </summary>
    [KnownType(typeof(TechnicalInputChannel1Choice.Code))]
    [KnownType(typeof(TechnicalInputChannel1Choice.Proprietary))]
    [JsonDerivedType(typeof(TechnicalInputChannel1Choice.Code),nameof(TechnicalInputChannel1Choice.Code))]
    [JsonDerivedType(typeof(TechnicalInputChannel1Choice.Proprietary),nameof(TechnicalInputChannel1Choice.Proprietary))]
    [IsoId("_Rpr4odp-Ed-ak6NoX_4Aeg_-1373581543")]
    [DisplayName("Technical Input Channel 1 Choice")]
    public abstract partial record TechnicalInputChannel1Choice_
    {
    }
}
