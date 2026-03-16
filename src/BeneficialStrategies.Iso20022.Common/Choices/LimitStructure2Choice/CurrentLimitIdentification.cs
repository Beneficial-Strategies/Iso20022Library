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
    [IsoId("__vDiY249EeiU9cctagi5ow")]
    [DisplayName("Current Limit Identification")]
    [IsoXmlTag("CurLmtId")]
    public record CurrentLimitIdentification : LimitStructure2Choice_
    {
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("__4vC1W49EeiU9cctagi5ow")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public SystemIdentification2Choice_? SystemIdentification { get; init; }

        /// <summary>
        /// Identification of the system member for which the limit is established.
        /// </summary>
        [IsoId("__4vC1249EeiU9cctagi5ow")]
        [DisplayName("Bilateral Limit Counterparty Identification")]
        [IsoXmlTag("BilLmtCtrPtyId")]
        public BranchAndFinancialInstitutionIdentification6? BilateralLimitCounterpartyIdentification { get; init; }

        /// <summary>
        /// Nature of the risk management limit.
        /// </summary>
        [IsoId("__4vC2W49EeiU9cctagi5ow")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required LimitType1Choice_ Type { get; init; }

        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("__4vC2249EeiU9cctagi5ow")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("__4vC3W49EeiU9cctagi5ow")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification4Choice_? AccountIdentification { get; init; }
    }
}
