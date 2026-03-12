// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Cleared12Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_Bemz8-xYEemioJdkOVFBdw")]
    [DisplayName("Intend To Clear")]
    public partial record IntendToClear : Cleared12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates that the contract is intended to be cleared.
        /// </summary>
        [IsoId("_9bAboexXEemioJdkOVFBdw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public NoReasonCode? Reason { get; init; } 
        
        /// <summary>
        /// Identifies the central counterparty (CCP) that cleared the transaction.
        /// </summary>
        [IsoId("_BpsCk-xYEemioJdkOVFBdw")]
        [DisplayName("CCP")]
        [IsoXmlTag("CCP")]
        public OrganisationIdentification10Choice_? CCP { get; init; } 
        
        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_BpsClexYEemioJdkOVFBdw")]
        [DisplayName("Clearing Date Time")]
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public IsoISODateTime? ClearingDateTime { get; init; } 
        
        
        #nullable disable
        
    }
}
