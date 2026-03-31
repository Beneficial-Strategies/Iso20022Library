// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError8Choice
{
    /// <summary>
    /// Requested member data when found in the system.
    /// </summary>
    [IsoId("_fSe1UdcZEeqRFcf2R4bPBw")]
    [DisplayName("Member")]
    [IsoXmlTag("Mmb")]
    public record Member : MemberReportOrError8Choice_
    {
        /// <summary>
        /// Word by which something is called or known or the family name of a person.
        /// </summary>
        [IsoId("_fUF-4dcZEeqRFcf2R4bPBw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Name { get; init; }

        /// <summary>
        /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
        /// </summary>
        [IsoId("_fUF-49cZEeqRFcf2R4bPBw")]
        [DisplayName("Return Address")]
        [IsoXmlTag("RtrAdr")]
        public MemberIdentification3Choice_? ReturnAddress { get; init; }

        /// <summary>
        /// Account to or from which a cash entry is made.
        /// </summary>
        [IsoId("_fUF-5dcZEeqRFcf2R4bPBw")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public CashAccount40? Account { get; init; }

        /// <summary>
        /// Nature of the relationship a member has with a system.
        /// </summary>
        [IsoId("_fUF-59cZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public SystemMemberType1Choice_? Type { get; init; }

        /// <summary>
        /// Status of a member in a system, for example enabled or deleted.
        /// </summary>
        [IsoId("_fUF-6dcZEeqRFcf2R4bPBw")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public SystemMemberStatus1Choice_? Status { get; init; }

        /// <summary>
        /// Person to be contacted in a given organisation.
        /// </summary>
        [IsoId("_fUF-69cZEeqRFcf2R4bPBw")]
        [DisplayName("Contact Reference")]
        [IsoXmlTag("CtctRef")]
        public ContactIdentificationAndAddress2? ContactReference { get; init; }

        /// <summary>
        /// Number, or virtual address, used for communication.
        /// </summary>
        [IsoId("_fUF-7dcZEeqRFcf2R4bPBw")]
        [DisplayName("Communication Address")]
        [IsoXmlTag("ComAdr")]
        public CommunicationAddress10? CommunicationAddress { get; init; }
    }
}
