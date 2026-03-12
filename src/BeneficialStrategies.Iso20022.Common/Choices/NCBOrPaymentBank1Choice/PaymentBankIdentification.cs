// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.NCBOrPaymentBank1Choice
{
    /// <summary>
    /// Unique business identifier code used to identify the payment bank providing the information.
    /// </summary>
    [IsoId("_jA3FAe5NEeCisYr99QEiWA_1180588846")]
    [DisplayName("Payment Bank Identification")]
    public partial record PaymentBankIdentification : NCBOrPaymentBank1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_knPM8-5NEeCisYr99QEiWA_-2106270244")]
        [DisplayName("Related Party Identification")]
        [IsoXmlTag("RltdPtyId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public required IsoBICFIIdentifier RelatedPartyIdentification { get; init; } 
        
        /// <summary>
        /// Unique identification of the party responsible for the maintenance of the party reference data.
        /// </summary>
        [IsoId("_knPM9O5NEeCisYr99QEiWA_1566757500")]
        [DisplayName("Responsible Party Identification")]
        [IsoXmlTag("RspnsblPtyId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        public required IsoBICFIIdentifier ResponsiblePartyIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
