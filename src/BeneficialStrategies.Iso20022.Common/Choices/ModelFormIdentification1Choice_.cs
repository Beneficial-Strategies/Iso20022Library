// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the model form identification.
    /// </summary>
    [KnownType(typeof(ModelFormIdentification1Choice.Code))]
    [KnownType(typeof(ModelFormIdentification1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModelFormIdentification1Choice.Code),
        nameof(ModelFormIdentification1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(ModelFormIdentification1Choice.Proprietary),
        nameof(ModelFormIdentification1Choice.Proprietary)
    )]
    [IsoId("_929T03ltEeG7BsjMvd1mEw_-115804936")]
    [DisplayName("Model Form Identification 1 Choice")]
    public abstract record ModelFormIdentification1Choice_ { }
}
