// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation2Choice
{
    /// <summary>
    /// Identification of the current reservation.
    /// </summary>
    [IsoId("_Bxla0W4-EeiU9cctagi5ow")]
    [DisplayName("Current")]
    public record Current : CurrentOrDefaultReservation2Choice_
    {
        /// <summary>
        /// Unique identification of the reservation.
        /// </summary>
        [IsoId("_B6-nY24-EeiU9cctagi5ow")]
        [DisplayName("Reservation Identification")]
        [IsoXmlTag("RsvatnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ReservationIdentification { get; init; }

        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_B6-nZW4-EeiU9cctagi5ow")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public SystemIdentification2Choice_? SystemIdentification { get; init; }

        /// <summary>
        /// Nature of the reservation.
        /// </summary>
        [IsoId("_B6-nZ24-EeiU9cctagi5ow")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ReservationType1Choice_ Type { get; init; }

        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_B6-naW4-EeiU9cctagi5ow")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; }

        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_B6-na24-EeiU9cctagi5ow")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification4Choice_? AccountIdentification { get; init; }
    }
}
