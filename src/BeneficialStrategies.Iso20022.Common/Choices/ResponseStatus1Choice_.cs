// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the response status.
    /// </summary>
    [KnownType(typeof(ResponseStatus1Choice.Code))]
    [KnownType(typeof(ResponseStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(ResponseStatus1Choice.Code),nameof(ResponseStatus1Choice.Code))]
    [JsonDerivedType(typeof(ResponseStatus1Choice.Proprietary),nameof(ResponseStatus1Choice.Proprietary))]
    [IsoId("_UYUpJNp-Ed-ak6NoX_4Aeg_-688354467")]
    [DisplayName("Response Status 1 Choice")]
    public abstract partial record ResponseStatus1Choice_
    {
    }
}
