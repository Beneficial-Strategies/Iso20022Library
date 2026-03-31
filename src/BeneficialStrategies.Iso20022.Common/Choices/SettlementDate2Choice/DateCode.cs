// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementDate2Choice
{
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_Qu0y4Np-Ed-ak6NoX_4Aeg_-691184816")]
    [DisplayName("Date Code")]
    public record DateCode : SettlementDate2Choice_ { }
}
