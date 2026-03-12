// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies a product in coded form or free text.
    /// </summary>
    [KnownType(typeof(ProductIdentifier2Choice.StructuredProductIdentifier))]
    [KnownType(typeof(ProductIdentifier2Choice.OtherProductIdentifier))]
    [JsonDerivedType(typeof(ProductIdentifier2Choice.StructuredProductIdentifier),nameof(ProductIdentifier2Choice.StructuredProductIdentifier))]
    [JsonDerivedType(typeof(ProductIdentifier2Choice.OtherProductIdentifier),nameof(ProductIdentifier2Choice.OtherProductIdentifier))]
    [IsoId("_Rb1C0Np-Ed-ak6NoX_4Aeg_-1291805290")]
    [DisplayName("Product Identifier 2 Choice")]
    public abstract partial record ProductIdentifier2Choice_
    {
    }
}
