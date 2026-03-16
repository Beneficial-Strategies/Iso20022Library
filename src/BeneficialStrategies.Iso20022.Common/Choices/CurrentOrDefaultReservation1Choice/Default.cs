// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation1Choice
{
    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_8IjoJqMgEeCJ6YNENx4h-w_-508539744")]
    [DisplayName("Default")]
    public record Default : CurrentOrDefaultReservation1Choice_
    {
        /// <summary>
        /// Unique identification of the reservation.
        /// </summary>
        [IsoId("_8IQtMKMgEeCJ6YNENx4h-w_996988035")]
        [DisplayName("Reservation Identification")]
        [IsoXmlTag("RsvatnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ReservationIdentification { get; init; }

        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_8IQtMaMgEeCJ6YNENx4h-w_-1950351602")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public SystemIdentification2Choice_? SystemIdentification { get; init; }

        /// <summary>
        /// Nature of the reservation.
        /// </summary>
        [IsoId("_8IQtMqMgEeCJ6YNENx4h-w_10956132")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ReservationType1Choice_ Type { get; init; }

        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_8IQtM6MgEeCJ6YNENx4h-w_-1367726811")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification5? AccountOwner { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_8IQtNKMgEeCJ6YNENx4h-w_-1345665819")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification4Choice_? AccountIdentification { get; init; }
    }
}
