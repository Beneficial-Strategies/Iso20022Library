// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the type of corporate action event.
    /// </summary>
    [KnownType(typeof(CorporateActionEventType1CodeChoice.Structured))]
    [KnownType(typeof(CorporateActionEventType1CodeChoice.Unstructured))]
    [JsonDerivedType(typeof(CorporateActionEventType1CodeChoice.Structured),nameof(CorporateActionEventType1CodeChoice.Structured))]
    [JsonDerivedType(typeof(CorporateActionEventType1CodeChoice.Unstructured),nameof(CorporateActionEventType1CodeChoice.Unstructured))]
    [IsoId("_UyZ9GNp-Ed-ak6NoX_4Aeg_853392558")]
    [DisplayName("Corporate Action Event Type 1 Code Choice")]
    public abstract partial record CorporateActionEventType1CodeChoice_
    {
    }
}
