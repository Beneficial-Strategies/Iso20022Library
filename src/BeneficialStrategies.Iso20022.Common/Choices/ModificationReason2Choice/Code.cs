// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModificationReason2Choice
{
    /// <summary>
    /// Specifies the reason why the related instruction is modified, or the related modification request is executed.
    /// </summary>
    [IsoId("_0jrN8wlIEeGATtfOBToyew_613709740")]
    [DisplayName("Code")]
    public record Code : ModificationReason2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that the transaction has been modified.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ModifiedStatusReason1Code Value { get; init; }
    }
}
