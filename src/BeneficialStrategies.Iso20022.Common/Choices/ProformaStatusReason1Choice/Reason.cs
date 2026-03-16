// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProformaStatusReason1Choice
{
    /// <summary>
    /// Reason for the proforma account status.
    /// </summary>
    [IsoId("_5BVa80zCEeafiMTDrtSnyw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : ProformaStatusReason1Choice_
    {
        /// <summary>
        /// Reason for the proforma account status.
        /// </summary>
        [IsoId("_G4DTIUzDEeafiMTDrtSnyw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ProformaStatusReason2Choice_ Code { get; init; }

        /// <summary>
        /// Additional information about the reason for the proforma account status.
        /// </summary>
        [IsoId("_G4DTI0zDEeafiMTDrtSnyw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; }
    }
}
