// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Proxy2Choice
{
    /// <summary>
    /// Specifies the elements required to assign a proxy.
    /// </summary>
    [IsoId("_7fsSgVtgEeSwKe7KuKvXhg")]
    [DisplayName("Proxy")]
    public partial record Proxy : Proxy2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies how to register the proxy.
        /// </summary>
        [IsoId("_79clg1tgEeSwKe7KuKvXhg")]
        [DisplayName("Registration Method")]
        [IsoXmlTag("RegnMtd")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? RegistrationMethod { get; init; } 
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the intermediary.
        /// </summary>
        [IsoId("_79clhVtgEeSwKe7KuKvXhg")]
        [DisplayName("Deadline")]
        [IsoXmlTag("Ddln")]
        public DateFormat29Choice_? Deadline { get; init; } 
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the intermediary (STP mode).
        /// </summary>
        [IsoId("_79clh1tgEeSwKe7KuKvXhg")]
        [DisplayName("STP Deadline")]
        [IsoXmlTag("STPDdln")]
        public DateFormat29Choice_? STPDeadline { get; init; } 
        
        /// <summary>
        /// Date by which the information on the proxy assignment must be received by the issuer.
        /// </summary>
        [IsoId("_79cliVtgEeSwKe7KuKvXhg")]
        [DisplayName("Market Deadline")]
        [IsoXmlTag("MktDdln")]
        public DateFormat29Choice_? MarketDeadline { get; init; } 
        
        /// <summary>
        /// Specifies the proxy person that is authorised by the issuer.
        /// </summary>
        [IsoId("_79cli1tgEeSwKe7KuKvXhg")]
        [DisplayName("Authorised Proxy")]
        [IsoXmlTag("AuthrsdPrxy")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Proxy5> AuthorisedProxy { get; init; } = new ValueList<Proxy5>(){};
        
        
        #nullable disable
        
    }
}
