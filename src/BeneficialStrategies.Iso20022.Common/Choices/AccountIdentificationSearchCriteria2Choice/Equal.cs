// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationSearchCriteria2Choice
{
    /// <summary>
    /// Search for one or more accounts based on exact identification of the account(s).
    /// </summary>
    [IsoId("_g7QEuWliEeGaMcKyqKNRfQ_-950111322")]
    [DisplayName("Equal")]
    public record Equal : AccountIdentificationSearchCriteria2Choice_ { }
}
