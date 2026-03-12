// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a response type code and a proprietary code.
    /// </summary>
    [KnownType(typeof(ResponseType1Choice.Code))]
    [KnownType(typeof(ResponseType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ResponseType1Choice.Code),nameof(ResponseType1Choice.Code))]
    [JsonDerivedType(typeof(ResponseType1Choice.Proprietary),nameof(ResponseType1Choice.Proprietary))]
    [IsoId("_QnOWFtp-Ed-ak6NoX_4Aeg_-827637915")]
    [DisplayName("Response Type 1 Choice")]
    public abstract partial record ResponseType1Choice_
    {
    }
}
