// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.BlockedReason1Choice
{
    /// <summary>
    /// Reason expressed as a code.
    /// </summary>
    [IsoId("_rKbmwBHdEeKVqeHljBM1MQ")]
    [DisplayName("Reason")]
    public partial record Reason : BlockedReason1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason an account is blocked.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required BlockedReason1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
