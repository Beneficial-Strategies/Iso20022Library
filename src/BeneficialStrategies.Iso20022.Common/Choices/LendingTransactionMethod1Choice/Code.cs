// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LendingTransactionMethod1Choice
{
    /// <summary>
    /// Lending transaction method expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_AXB1YdokEeC60axPepSq7g_-1992970841")]
    [DisplayName("Code")]
    public record Code : LendingTransactionMethod1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Lending method applied to the securities financing contract.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required LendingTransactionMethod1Code Value { get; init; }
    }
}
