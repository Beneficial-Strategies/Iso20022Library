// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the type of taxes.
    /// </summary>
    [KnownType(typeof(TaxType3FormatChoice.Code))]
    [KnownType(typeof(TaxType3FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(TaxType3FormatChoice.Code),nameof(TaxType3FormatChoice.Code))]
    [JsonDerivedType(typeof(TaxType3FormatChoice.Proprietary),nameof(TaxType3FormatChoice.Proprietary))]
    [IsoId("_RpFbsdp-Ed-ak6NoX_4Aeg_215638433")]
    [DisplayName("Tax Type 3 Format Choice")]
    public abstract partial record TaxType3FormatChoice_
    {
    }
}
