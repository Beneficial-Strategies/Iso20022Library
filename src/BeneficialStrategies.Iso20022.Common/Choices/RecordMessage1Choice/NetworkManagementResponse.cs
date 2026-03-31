// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice
{
    /// <summary>
    /// Network management response message record.
    /// </summary>
    [IsoId("_mMMRkRs8EeqrvK3udMUsNQ")]
    [DisplayName("Network Management Response")]
    public record NetworkManagementResponse : RecordMessage1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 2MB maximum.
        /// </summary>
        [IsoXmlTag("NtwkMgmtRspn")]
        [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
