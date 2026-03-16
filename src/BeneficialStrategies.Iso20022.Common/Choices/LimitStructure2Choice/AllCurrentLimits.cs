// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitStructure2Choice
{
    /// <summary>
    /// Identification of the current limit.
    /// </summary>
    [IsoId("__vDiZW49EeiU9cctagi5ow")]
    [DisplayName("All Current Limits")]
    public record AllCurrentLimits : LimitStructure2Choice_
    {
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_ACk7U24-EeiU9cctagi5ow")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public SystemIdentification2Choice_? SystemIdentification { get; init; }

        /// <summary>
        /// Nature of the risk management limit.
        /// </summary>
        [IsoId("_ACk7VW4-EeiU9cctagi5ow")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required LimitType1Choice_ Type { get; init; }

        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_ACk7V24-EeiU9cctagi5ow")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_ACk7WW4-EeiU9cctagi5ow")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification4Choice_? AccountIdentification { get; init; }
    }
}
