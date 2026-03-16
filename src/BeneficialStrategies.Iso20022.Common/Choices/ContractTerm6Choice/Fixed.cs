// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractTerm6Choice
{
    /// <summary>
    /// Transaction is fixed term with a contractually agreed maturity date.
    /// </summary>
    [IsoId("__L6x065OEeuo-IflVgGqiA")]
    [DisplayName("Fixed")]
    public record Fixed : ContractTerm6Choice_ { }
}
