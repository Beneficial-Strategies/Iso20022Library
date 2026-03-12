// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of the document referred in the remittance information.
    /// </summary>
    [KnownType(typeof(ReferredDocumentType1Choice.Code))]
    [KnownType(typeof(ReferredDocumentType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReferredDocumentType1Choice.Code),nameof(ReferredDocumentType1Choice.Code))]
    [JsonDerivedType(typeof(ReferredDocumentType1Choice.Proprietary),nameof(ReferredDocumentType1Choice.Proprietary))]
    [IsoId("_T3sBRdp-Ed-ak6NoX_4Aeg_174928116")]
    [DisplayName("Referred Document Type 1 Choice")]
    public abstract partial record ReferredDocumentType1Choice_
    {
    }
}
