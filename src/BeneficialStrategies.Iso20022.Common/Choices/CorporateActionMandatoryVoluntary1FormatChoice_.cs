// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express whether the event is mandatory, mandatory with options or voluntary.
    /// </summary>
    [KnownType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Proprietary))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Code),nameof(CorporateActionMandatoryVoluntary1FormatChoice.Code))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1FormatChoice.Proprietary),nameof(CorporateActionMandatoryVoluntary1FormatChoice.Proprietary))]
    [IsoId("_RmZ7Itp-Ed-ak6NoX_4Aeg_1296355739")]
    [DisplayName("Corporate Action Mandatory Voluntary 1 Format Choice")]
    public abstract partial record CorporateActionMandatoryVoluntary1FormatChoice_
    {
    }
}
