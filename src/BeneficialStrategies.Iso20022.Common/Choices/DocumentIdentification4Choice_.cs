// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a document identification provided either by the account owner or by the account servicer.
    /// </summary>
    [KnownType(typeof(DocumentIdentification4Choice.AccountServicerDocumentIdentification))]
    [KnownType(typeof(DocumentIdentification4Choice.AccountOwnerDocumentIdentification))]
    [JsonDerivedType(
        typeof(DocumentIdentification4Choice.AccountServicerDocumentIdentification),
        nameof(DocumentIdentification4Choice.AccountServicerDocumentIdentification)
    )]
    [JsonDerivedType(
        typeof(DocumentIdentification4Choice.AccountOwnerDocumentIdentification),
        nameof(DocumentIdentification4Choice.AccountOwnerDocumentIdentification)
    )]
    [IsoId("_celQvZKQEeWHWpTQn1FFVg")]
    [DisplayName("Document Identification 4 Choice")]
    public abstract record DocumentIdentification4Choice_ { }
}
