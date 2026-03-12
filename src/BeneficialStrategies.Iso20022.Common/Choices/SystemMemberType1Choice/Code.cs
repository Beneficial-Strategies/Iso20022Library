// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemMemberType1Choice
{
    /// <summary>
    /// System member type, in a coded form.
    /// </summary>
    [IsoId("_cFGbMHhgEeidzqjNEfehPg")]
    [DisplayName("Code")]
    public partial record Code : SystemMemberType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the membership of a party in a system, as published in an external system member type code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSystemMemberType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
