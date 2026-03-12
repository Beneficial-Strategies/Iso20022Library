// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a document identification provided either by the account owner or by the account servicer.
    /// </summary>
    [KnownType(typeof(DocumentIdentification3Choice.AccountServicerDocumentIdentification))]
    [KnownType(typeof(DocumentIdentification3Choice.AccountOwnerDocumentIdentification))]
    [JsonDerivedType(typeof(DocumentIdentification3Choice.AccountServicerDocumentIdentification),nameof(DocumentIdentification3Choice.AccountServicerDocumentIdentification))]
    [JsonDerivedType(typeof(DocumentIdentification3Choice.AccountOwnerDocumentIdentification),nameof(DocumentIdentification3Choice.AccountOwnerDocumentIdentification))]
    [IsoId("_E5kPkTnaEeWLJsP1cO-amg")]
    [DisplayName("Document Identification 3 Choice")]
    public abstract partial record DocumentIdentification3Choice_
    {
    }
}
