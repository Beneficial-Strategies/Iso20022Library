// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError4Choice
{
    /// <summary>
    /// Requested member data when found in the system.
    /// </summary>
    [IsoId("_jEyVkZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member")]
    [IsoXmlTag("Mmb")]
    public record Member : MemberReportOrError4Choice_
    {
        /// <summary>
        /// Word by which something is called or known or the family name of a person.
        /// </summary>
        [IsoId("_jNHLIZlCEee-Zps0fZQaFQ")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Name { get; init; }

        /// <summary>
        /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
        /// </summary>
        [IsoId("_jNHLI5lCEee-Zps0fZQaFQ")]
        [DisplayName("Return Address")]
        [IsoXmlTag("RtrAdr")]
        public MemberIdentification2Choice_? ReturnAddress { get; init; }

        /// <summary>
        /// Account to or from which a cash entry is made.
        /// </summary>
        [IsoId("_jNHLJZlCEee-Zps0fZQaFQ")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public CashAccount24? Account { get; init; }

        /// <summary>
        /// Nature of the relationship a member has with a system.
        /// </summary>
        [IsoId("_jNHLJ5lCEee-Zps0fZQaFQ")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MemberType1Code? Type { get; init; }

        /// <summary>
        /// Status of a member in a system, for example enabled or deleted.
        /// </summary>
        [IsoId("_jNHLKZlCEee-Zps0fZQaFQ")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public MemberStatus1Code? Status { get; init; }

        /// <summary>
        /// Person to be contacted in a given organisation.
        /// </summary>
        [IsoId("_jNHLK5lCEee-Zps0fZQaFQ")]
        [DisplayName("Contact Reference")]
        [IsoXmlTag("CtctRef")]
        public ContactIdentificationAndAddress1? ContactReference { get; init; }

        /// <summary>
        /// Number, or virtual address, used for communication.
        /// </summary>
        [IsoId("_jNHLLZlCEee-Zps0fZQaFQ")]
        [DisplayName("Communication Address")]
        [IsoXmlTag("ComAdr")]
        public CommunicationAddress8? CommunicationAddress { get; init; }
    }
}
