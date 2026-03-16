// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation2Choice
{
    /// <summary>
    /// Indicates the type of contract confirmation.
    /// </summary>
    [IsoId("_qo0sYQFXEeaDfK-zDSyB6A")]
    [DisplayName("Confirmed")]
    public record Confirmed : TradeConfirmation2Choice_
    {
        /// <summary>
        /// Specifies whether the contract was confirmed electronically or non-electronically.
        /// </summary>
        [IsoId("_41eYUQFXEeaDfK-zDSyB6A")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public TradeConfirmationType1Code? Type { get; init; }

        /// <summary>
        /// Date and time of the trade confirmation, indicating time zone in which the confirmation has taken place.
        /// </summary>
        [IsoId("_41eYUwFXEeaDfK-zDSyB6A")]
        [DisplayName("Time Stamp")]
        [IsoXmlTag("TmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? TimeStamp { get; init; }
    }
}
