// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractRegistrationReference2Choice
{
    /// <summary>
    /// Identification of the contract.
    /// </summary>
    [IsoId("_KVgWabMmEeueudaIbClZbQ")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public record Contract : ContractRegistrationReference2Choice_
    {
        /// <summary>
        /// Identifies the document.
        /// </summary>
        [IsoId("_zSWHUbMmEeueudaIbClZbQ")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; }

        /// <summary>
        /// Date of issuance of the document.
        /// </summary>
        [IsoId("_zSWHU7MmEeueudaIbClZbQ")]
        [DisplayName("Date Of Issue")]
        [IsoXmlTag("DtOfIsse")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateOfIssue { get; init; }
    }
}
