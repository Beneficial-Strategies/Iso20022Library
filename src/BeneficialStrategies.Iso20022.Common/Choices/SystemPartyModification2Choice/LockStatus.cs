// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification2Choice
{
    /// <summary>
    /// Specifies whether the party is locked or not, and the reason for this status, when required.
    /// </summary>
    [IsoId("__edeA4v_Eei289CGNqs21g")]
    [DisplayName("Lock Status")]
    public partial record LockStatus : SystemPartyModification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the date from which the lock status is valid.
        /// </summary>
        [IsoId("_WiPMQGjNEeiRg5NzP0jkQg")]
        [DisplayName("Valid From")]
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValidFrom { get; init; } 
        
        /// <summary>
        /// Lock status of the party.
        /// </summary>
        [IsoId("_JfT982jMEeiRg5NzP0jkQg")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required LockStatus1Code Status { get; init; } 
        
        /// <summary>
        /// Specifies the underlying reason for the locking of the party.
        /// </summary>
        [IsoId("_JfT99GjMEeiRg5NzP0jkQg")]
        [DisplayName("Lock Reason")]
        [IsoXmlTag("LckRsn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? LockReason { get; init; } 
        
        
        #nullable disable
        
    }
}
