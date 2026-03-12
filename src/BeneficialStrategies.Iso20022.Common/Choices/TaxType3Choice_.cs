// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of tax.
    /// </summary>
    [KnownType(typeof(TaxType3Choice.Code))]
    [KnownType(typeof(TaxType3Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxType3Choice.Code),nameof(TaxType3Choice.Code))]
    [JsonDerivedType(typeof(TaxType3Choice.Proprietary),nameof(TaxType3Choice.Proprietary))]
    [IsoId("_CRfa8Dh7EeaH-93K5JKmzw")]
    [DisplayName("Tax Type 3 Choice")]
    public abstract partial record TaxType3Choice_
    {
    }
}
