// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification73Choice
{
    /// <summary>
    /// Party Identification specified as a list of values per element.
    /// </summary>
    [IsoId("_XthjsIKPEeKmtdhZXgREOQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public record PartyIdentification : PartyIdentification73Choice_
    {
        /// <summary>
        /// Identification of the party expressed as the party&apos;s name.
        /// </summary>
        [IsoId("_MtaPwIKQEeKmtdhZXgREOQ")]
        [DisplayName("Party Name")]
        [IsoXmlTag("PtyNm")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public IsoMax34Text? PartyName { get; init; }

        /// <summary>
        /// Identification of the party expressed as a BIC and an optional alternative identifier.
        /// </summary>
        [IsoId("_ocnb44YsEeKuscgzs7HVKw")]
        [DisplayName("Any BIC")]
        [IsoXmlTag("AnyBIC")]
        public PartyIdentification44? AnyBIC { get; init; }

        /// <summary>
        /// Identification of the party&apos;s account number.
        /// </summary>
        [IsoId("_vbjUsIKOEeKmtdhZXgREOQ")]
        [DisplayName("Account Number")]
        [IsoXmlTag("AcctNb")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public IsoMax34Text? AccountNumber { get; init; }

        /// <summary>
        /// Identification of the party&apos;s address.
        /// </summary>
        [IsoId("_nGNk8IKPEeKmtdhZXgREOQ")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105, MinimumLength = 1)]
        public IsoMax105Text? Address { get; init; }

        /// <summary>
        /// Choice of a clearing system identifier.
        /// </summary>
        [IsoId("_VwsfQIoREeKINPO736UM8w")]
        [DisplayName("Clearing System Identification")]
        [IsoXmlTag("ClrSysId")]
        public ClearingSystemIdentification2Choice_? ClearingSystemIdentification { get; init; }

        /// <summary>
        /// Identification of the Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
        /// </summary>
        [IsoId("_HxyqUIKQEeKmtdhZXgREOQ")]
        [DisplayName("Legal Entity Identifier")]
        [IsoXmlTag("LglNttyIdr")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }
    }
}
