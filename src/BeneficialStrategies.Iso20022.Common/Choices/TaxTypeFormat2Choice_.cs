// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of tax expressed in structured or free text form.
    /// </summary>
    [KnownType(typeof(TaxTypeFormat2Choice.Unstructured))]
    [KnownType(typeof(TaxTypeFormat2Choice.Structured))]
    [JsonDerivedType(
        typeof(TaxTypeFormat2Choice.Unstructured),
        nameof(TaxTypeFormat2Choice.Unstructured)
    )]
    [JsonDerivedType(
        typeof(TaxTypeFormat2Choice.Structured),
        nameof(TaxTypeFormat2Choice.Structured)
    )]
    [IsoId("_Uy2pBdp-Ed-ak6NoX_4Aeg_2019279092")]
    [DisplayName("Tax Type Format 2 Choice")]
    public abstract record TaxTypeFormat2Choice_ { }
}
