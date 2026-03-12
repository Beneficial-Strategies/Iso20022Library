// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation3Choice
{
    /// <summary>
    /// Identification of the default reservation.
    /// </summary>
    [IsoId("_hBG6U9cZEeqRFcf2R4bPBw")]
    [DisplayName("Default")]
    public partial record Default : CurrentOrDefaultReservation3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique identification of the reservation.
        /// </summary>
        [IsoId("_eMNw0dcZEeqRFcf2R4bPBw")]
        [DisplayName("Reservation Identification")]
        [IsoXmlTag("RsvatnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ReservationIdentification { get; init; } 
        
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_eMNw09cZEeqRFcf2R4bPBw")]
        [DisplayName("System Identification")]
        [IsoXmlTag("SysId")]
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        
        /// <summary>
        /// Nature of the reservation.
        /// </summary>
        [IsoId("_eMNw1dcZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ReservationType2Choice_ Type { get; init; } 
        
        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_eMNw19cZEeqRFcf2R4bPBw")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_eMNw2dcZEeqRFcf2R4bPBw")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
