// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of tax as a code or free text.
    /// </summary>
    [KnownType(typeof(TaxType2Choice.Type))]
    [KnownType(typeof(TaxType2Choice.OtherTaxType))]
    [JsonDerivedType(typeof(TaxType2Choice.Type), nameof(TaxType2Choice.Type))]
    [JsonDerivedType(typeof(TaxType2Choice.OtherTaxType), nameof(TaxType2Choice.OtherTaxType))]
    [IsoId("_Xf3zQBrfEeOVR9VN6fAMUg")]
    [DisplayName("Tax Type 2 Choice")]
    public abstract record TaxType2Choice_ { }
}
