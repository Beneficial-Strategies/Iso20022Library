// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
[IsoId("_QbdK-dp-Ed-ak6NoX_4Aeg_2112357361")]
[DisplayName("Cheque")]
public record Cheque4
{
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    [IsoId("_QbdK-tp-Ed-ak6NoX_4Aeg_-2038541815")]
    [DisplayName("Payee Identification")]
    [IsoXmlTag("PyeeId")]
    public required NameAndAddress5 PayeeIdentification { get; init; }
}
