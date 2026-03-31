// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a document identification provided either by the account owner or by the account servicer.
    /// </summary>
    [KnownType(typeof(DocumentIdentification1Choice.AccountServicerDocumentIdentification))]
    [KnownType(typeof(DocumentIdentification1Choice.AccountOwnerDocumentIdentification))]
    [JsonDerivedType(
        typeof(DocumentIdentification1Choice.AccountServicerDocumentIdentification),
        nameof(DocumentIdentification1Choice.AccountServicerDocumentIdentification)
    )]
    [JsonDerivedType(
        typeof(DocumentIdentification1Choice.AccountOwnerDocumentIdentification),
        nameof(DocumentIdentification1Choice.AccountOwnerDocumentIdentification)
    )]
    [IsoId("_ThCb1dp-Ed-ak6NoX_4Aeg_1840824208")]
    [DisplayName("Document Identification 1 Choice")]
    public abstract record DocumentIdentification1Choice_ { }
}
