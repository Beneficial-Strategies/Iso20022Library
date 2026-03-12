// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the document type.
    /// </summary>
    [KnownType(typeof(UndertakingDocumentType2Choice.Code))]
    [KnownType(typeof(UndertakingDocumentType2Choice.Proprietary))]
    [JsonDerivedType(typeof(UndertakingDocumentType2Choice.Code),nameof(UndertakingDocumentType2Choice.Code))]
    [JsonDerivedType(typeof(UndertakingDocumentType2Choice.Proprietary),nameof(UndertakingDocumentType2Choice.Proprietary))]
    [IsoId("_we6lgDPGEeKaav-uUgD4RA")]
    [DisplayName("Undertaking Document Type 2 Choice")]
    public abstract partial record UndertakingDocumentType2Choice_
    {
    }
}
