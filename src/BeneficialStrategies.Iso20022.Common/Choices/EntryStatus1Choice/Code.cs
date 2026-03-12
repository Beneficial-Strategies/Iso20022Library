// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.EntryStatus1Choice
{
    /// <summary>
    /// Entry status, in a coded form.
    /// </summary>
    [IsoId("_H_H9sIaoEeeUws0ZryHQ2w")]
    [DisplayName("Code")]
    public partial record Code : EntryStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of an entry on the books of the account servicer, as published in an external code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalEntryStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
