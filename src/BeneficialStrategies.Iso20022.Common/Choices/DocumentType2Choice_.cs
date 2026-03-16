// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Document Type2Choice.
    /// </summary>
    [KnownType(typeof(DocumentType2Choice.Code))]
    [KnownType(typeof(DocumentType2Choice.Proprietary))]
    [JsonDerivedType(typeof(DocumentType2Choice.Code), nameof(DocumentType2Choice.Code))]
    [JsonDerivedType(
        typeof(DocumentType2Choice.Proprietary),
        nameof(DocumentType2Choice.Proprietary)
    )]
    [IsoId("_O4jeMzE0Ee62xuUQ2zyZww")]
    [DisplayName("Document Type2Choice")]
    public abstract record DocumentType2Choice_ { }
}
