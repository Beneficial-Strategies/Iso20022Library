// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to further detail the information related to the type of payment.
/// </summary>
[IsoId("_TFxcONp-Ed-ak6NoX_4Aeg_1015976937")]
[DisplayName("Mandate Type Information")]
public record MandateTypeInformation1
{
    /// <summary>
    /// Agreement under which or rules under which the mandate resides.
    /// </summary>
    [IsoId("_TF7NINp-Ed-ak6NoX_4Aeg_1015977061")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel8Choice_? ServiceLevel { get; init; }

    /// <summary>
    /// User community specific instrument.|Usage: This element is used to specify a local instrument, local clearing option and/or further qualify the service or service level.
    /// </summary>
    [IsoId("_TF7NIdp-Ed-ak6NoX_4Aeg_405655354")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument2Choice_? LocalInstrument { get; init; }
}
