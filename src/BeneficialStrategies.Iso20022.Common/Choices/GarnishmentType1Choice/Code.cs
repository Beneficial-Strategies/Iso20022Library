// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice
{
    /// <summary>
    /// Garnishment type in a coded form.
    /// Would suggest this to be an External Code List to contain:
    /// GNCS    Garnishment from a third party payer for Child Support
    /// GNDP    Garnishment from a Direct Payer for Child Support
    /// GTPP     Garnishment from a third party payer to taxing agency.
    /// </summary>
    [IsoId("_lG0rQ4nnEeOORMXOfBk1Bw")]
    [DisplayName("Code")]
    public partial record Code : GarnishmentType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the garnishment type as published in an external document type code list.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalGarnishmentType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
