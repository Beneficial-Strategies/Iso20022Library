// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountOrOperationalError4Choice
{
    /// <summary>
    /// Reports either on the account information or on a business error.
    /// </summary>
    [IsoId("_MiVdEW49EeiU9cctagi5ow")]
    [DisplayName("Account Report")]
    [IsoXmlTag("AcctRpt")]
    public record AccountReport : AccountOrOperationalError4Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_MtNQU249EeiU9cctagi5ow")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public required AccountIdentification4Choice_ AccountIdentification { get; init; }

        /// <summary>
        /// Requested information on the account or business error when information has not been found.
        /// </summary>
        [IsoId("_MtNQVW49EeiU9cctagi5ow")]
        [DisplayName("Account Or Error")]
        [IsoXmlTag("AcctOrErr")]
        public required AccountOrBusinessError4Choice_ AccountOrError { get; init; }
    }
}
