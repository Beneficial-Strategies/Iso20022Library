// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of additional information.
    /// </summary>
    [KnownType(typeof(InformationType1Choice.Code))]
    [KnownType(typeof(InformationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InformationType1Choice.Code),nameof(InformationType1Choice.Code))]
    [JsonDerivedType(typeof(InformationType1Choice.Proprietary),nameof(InformationType1Choice.Proprietary))]
    [IsoId("_RX8oaNp-Ed-ak6NoX_4Aeg_202651859")]
    [DisplayName("Information Type 1 Choice")]
    public abstract partial record InformationType1Choice_
    {
    }
}
