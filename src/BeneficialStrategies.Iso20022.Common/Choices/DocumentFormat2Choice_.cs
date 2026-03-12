// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of document format.
    /// </summary>
    [KnownType(typeof(DocumentFormat2Choice.Code))]
    [KnownType(typeof(DocumentFormat2Choice.Proprietary))]
    [JsonDerivedType(typeof(DocumentFormat2Choice.Code),nameof(DocumentFormat2Choice.Code))]
    [JsonDerivedType(typeof(DocumentFormat2Choice.Proprietary),nameof(DocumentFormat2Choice.Proprietary))]
    [IsoId("_EjTq0eatEeqCKaUycnDWEg")]
    [DisplayName("Document Format 2 Choice")]
    public abstract partial record DocumentFormat2Choice_
    {
    }
}
