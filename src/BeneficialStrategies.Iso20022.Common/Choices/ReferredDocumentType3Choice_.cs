// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of the document referred in the remittance information.
    /// </summary>
    [KnownType(typeof(ReferredDocumentType3Choice.Code))]
    [KnownType(typeof(ReferredDocumentType3Choice.Proprietary))]
    [JsonDerivedType(typeof(ReferredDocumentType3Choice.Code),nameof(ReferredDocumentType3Choice.Code))]
    [JsonDerivedType(typeof(ReferredDocumentType3Choice.Proprietary),nameof(ReferredDocumentType3Choice.Proprietary))]
    [IsoId("_XxL1Jx77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document Type 3 Choice")]
    public abstract partial record ReferredDocumentType3Choice_
    {
    }
}
